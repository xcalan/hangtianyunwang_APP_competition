using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monitor.Models;
using AForge.Video;


namespace Monitor {
    public partial class AllCameraMonitorForm: Form {
        List<Camera> cameras;
        List<AForge.Controls.PictureBox> boxes;
        List<MJPEGStream> videos;
        string videoUrlFormatter = "http://{0}:{1}/?action=stream";

        public AllCameraMonitorForm(List<Camera> cameras) {
            InitializeComponent();

            this.cameras = cameras;
            boxes = new List<AForge.Controls.PictureBox>(cameras.Count);
            videos = new List<MJPEGStream>(cameras.Count);
        }

        private void AllCameraMonitorForm_Load(object sender, EventArgs e) {
            cameras.ForEach(camera => {
                AForge.Controls.PictureBox pb = new AForge.Controls.PictureBox();
                pb.Size = new Size(352, 288);
                pb.BackgroundImage = global::Monitor.Properties.Resources.no_video;
                pb.Location = new Point(12, 27);
                boxes.Add(pb);

                MJPEGStream videoStream = new MJPEGStream();
                videoStream.NewFrame += new NewFrameEventHandler(videoStream_NewFrame);
                videoStream.Source = string.Format(videoUrlFormatter, camera.ip, camera.port);
                videoStream.Start();
                videos.Add(videoStream);

                GroupBox groupBox = new GroupBox();
                groupBox.Text = camera.ToString();
                groupBox.Font = new Font("微软雅黑", 10F);
                groupBox.Size = new Size(375, 330);
                groupBox.Controls.Add(pb);
                flowLayoutPanel1.Controls.Add(groupBox);
            });
        }

        private void videoStream_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            MJPEGStream videoStream = (MJPEGStream)sender;
            Bitmap FrameData = new Bitmap(eventArgs.Frame);
            for (int i=0; i<cameras.Count; i++) {
                if (videoStream.Source == string.Format(videoUrlFormatter, cameras[i].ip, cameras[i].port)) {
                    boxes[i].Image = FrameData;
                }
            }
        }

        private void AllCameraMonitorForm_FormClosing(object sender, FormClosingEventArgs e) {
            videos.ForEach(video => {
                video.Stop();
            });
        }
    }
}
