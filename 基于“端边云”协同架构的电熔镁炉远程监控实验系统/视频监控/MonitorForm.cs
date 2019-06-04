using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using AForge.Video;
using AForge.Video.VFW;
using log4net;

using Monitor.Models;
using Monitor.Tcp;
using Monitor.DB;


namespace Monitor {
    public partial class MonitorForm: Form {
        public static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        AVIWriter videoWriter;
        MJPEGStream videoStream;
        string videoUrlFormatter = "http://{0}:{1}/?action=stream";

        public PgsqlDB pgsql;
        public SqliteDB sqlite;
        List<Camera> cameras;
        Camera curCamera = null;

        //AsyncTCPServer tcpServer;

        #region Methods
        public void addCamera(Camera camera) {
            cameras.Add(camera);
            lbCameras.Items.Add(camera);
        }

        public void setCameraData(CameraData cd) {
            setCameraData(cd.factory_no, cd.furnace_no,
                          cd.a_i, cd.b_i, cd.c_i, cd.i_default,
                          cd.a_v, cd.b_v, cd.c_v,
                          cd.e_speed, cd.r_speed,
                          cd.a_action, cd.b_action, cd.c_action,
                          cd.status, cd.feed, cd.exhaust, cd.d_time);
        }

        /// <summary>
        /// 设置数据显示的值
        /// </summary>
        /// <param name="fac_no">厂房编号</param>
        /// <param name="fur_no">电熔镁炉编号</param>
        /// <param name="a_i">A相电流</param>
        /// <param name="b_i">B相电流</param>
        /// <param name="c_i">C相电流</param>
        /// <param name="i_defalut">电流设定值</param>
        /// <param name="a_v">A相电压</param>
        /// <param name="b_v">B相电压</param>
        /// <param name="c_v">C相电压</param>
        /// <param name="e_speed">手动电极速度</param>
        /// <param name="r_speed">炉体转动速度</param>
        /// <param name="a_cation">A动作</param>
        /// <param name="b_action">B动作</param>
        /// <param name="c_action">C动作</param>
        /// <param name="status">手/自动状态</param>
        /// <param name="feed">加料指示</param>
        /// <param name="exhaust">排气指示</param>
        /// <param name="datetime">数据采集时间</param>
        public void setCameraData(int fac_no, int fur_no, float a_i, float b_i, float c_i, float i_defalut,
                                  float a_v, float b_v, float c_v, float e_speed, float r_speed,
                                  float a_action, float b_action, float c_action,
                                  bool status, bool feed, bool exhaust, DateTime datetime) {
            labelFactoryNO.Text = fac_no.ToString();
            labelFurnaceNO.Text = fur_no.ToString();
            labelA_I.Text = a_i.ToString();
            labelB_I.Text = b_i.ToString();
            labelC_I.Text = c_i.ToString();
            labelI_Default.Text = i_defalut.ToString();
            labelA_V.Text = a_v.ToString();
            labelB_V.Text = b_v.ToString();
            labelC_V.Text = c_v.ToString();
            labelE_Speed.Text = e_speed.ToString();
            labelR_Speed.Text = r_speed.ToString();
            labelA_Action.Text = a_action.ToString();
            labelB_Action.Text = b_action.ToString();
            labelC_Action.Text = c_action.ToString();
            labelStatus.Text = status ? "手动" : "自动";
            labelFeed.Text = feed ? "需要" : "不需";
            labelExhaust.Text = exhaust ? "排" : "不排";
            labelD_Time.Text = datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion

        #region FormMethods
        public MonitorForm() {
            InitializeComponent();
        }

        private void MonitorForm_Load(object sender, EventArgs e) {
            // 初始化数据库连接并打开
            pgsql = new PgsqlDB(ConfigurationManager.AppSettings.Get("dbHost"),
                         ConfigurationManager.AppSettings.Get("dbName"),
                         ConfigurationManager.AppSettings.Get("dbUser"),
                         ConfigurationManager.AppSettings.Get("dbPassword"));
            pgsql.open();
            sqlite = new SqliteDB(ConfigurationManager.AppSettings.Get("dbPath"));
            sqlite.open();
            sqlite.initCameraDatabase();
            _log.Info("Pgsql DB & SQLite connected!");

            // 初始化视频流显示
            videoStream = new MJPEGStream();
            videoStream.NewFrame += new NewFrameEventHandler(videoStream_NewFrame);
            _log.Info("Video Stream inited!");

            // 保存视频
            if (!Directory.Exists("_video_saved")) {
                Directory.CreateDirectory("_video_saved");
            }
            videoWriter = new AVIWriter();
            videoWriter.FrameRate = 2;

            // 初始化摄像头列表
            cameras = sqlite.getCameras();
            cameras.ForEach(camera => lbCameras.Items.Add(camera));

        }

        private void MonitorForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (videoStream.IsRunning) {
                videoStream.Stop();
            }
            sqlite.close();
            pgsql.close();
        }

        private void videoStream_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            Bitmap frameData = new Bitmap(eventArgs.Frame);
            frameData.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbCameraView.Image = frameData;
            videoWriter.AddFrame((Bitmap)frameData.Clone());
        }

        private void btnAddCamera_Click(object sender, EventArgs e) {
            AddCameraForm form = new AddCameraForm(this);
            form.Show(this);
        }

        private void btnDeleteCamera_Click(object sender, EventArgs e) {
            try {
                Camera camera = cameras[lbCameras.SelectedIndex];
                if (camera == curCamera) {
                    MessageBox.Show("当前正在监控此摄像头，无法删除！");
                    return;
                }
                sqlite.deleteCamera(camera);
                lbCameras.Items.RemoveAt(lbCameras.SelectedIndex);
            } catch (System.Data.SQLite.SQLiteException ex) {
                MessageBox.Show("删除失败！出现错误：\n" + ex.Message);
                _log.Error(ex);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e) {
            AllCameraMonitorForm form = new AllCameraMonitorForm(cameras);
            form.Show();
        }

        private void btnStartStopVideo_Click(object sender, EventArgs e) {
            if (lbCameras.SelectedIndex < 0) {
                MessageBox.Show("当前没有选择相机，请先选择一个相机！");
                return;
            }
            if (videoStream.IsRunning) {
                videoStream.Stop();
                videoWriter.Close();    // 保存视频文件
                File.Move("_video_saved\\recording.avi",
                          string.Format("_video_saved\\{0}-{1}.avi",
                                        curCamera.ToString(),
                                        DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss")));
                curCamera = null;
                timerGetData.Stop();   // 关闭同时关闭计时器
                pbCameraView.Image = global::Monitor.Properties.Resources.no_video;
                btnStartStopVideo.Text = "显示视频";
                btnStartStopVideo.BackColor = Color.LightGreen;
                labelVideoInfo.Text = "请先在左侧选择相机，然后点击“显示视频”";
            } else {
                curCamera = cameras[lbCameras.SelectedIndex];
                videoStream.Source = string.Format(videoUrlFormatter, curCamera.ip, curCamera.port);
                videoStream.Start();
                videoWriter.Open("_video_saved\\recording.avi", 352, 288);      // 创建视频文件
                timerGetData.Start();   // 启动同时开始计时器
                btnStartStopVideo.Text = "关闭视频";
                btnStartStopVideo.BackColor = Color.LightCoral;
                labelVideoInfo.Text = curCamera.ToFullString();
            }
        }

        private void timerGetData_Tick(object sender, EventArgs e) {
            try {
                CameraData cd = pgsql.getCameraData(curCamera.factoryNo, curCamera.furnaceNo);
                if (cd != null) {
                    setCameraData(cd);
                }
                labelLastUpdateTime.Text = DateTime.Now.ToString();
            } catch (Npgsql.NpgsqlException ex) {
                _log.Error(ex);
            }
        }

        private void btnHistoryData_Click(object sender, EventArgs e) {
            if (lbCameras.SelectedIndex < 0 || curCamera == null) {
                MessageBox.Show("当前没有选择相机，请先选择一个相机！");
                return;
            }
            HistoryDataFormcs form = new HistoryDataFormcs(this, cameras[lbCameras.SelectedIndex]);
            form.Show(this);
        }
        #endregion
    }
}
