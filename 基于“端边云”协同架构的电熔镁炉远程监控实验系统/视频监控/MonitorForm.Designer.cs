namespace Monitor {
    partial class MonitorForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorForm));
            this.lbCameras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddCamera = new System.Windows.Forms.Button();
            this.btnDeleteCamera = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.labelFactoryNO = new System.Windows.Forms.Label();
            this.labelA_I = new System.Windows.Forms.Label();
            this.labelB_I = new System.Windows.Forms.Label();
            this.labelC_I = new System.Windows.Forms.Label();
            this.labelI_Default = new System.Windows.Forms.Label();
            this.labelFurnaceNO = new System.Windows.Forms.Label();
            this.labelA_V = new System.Windows.Forms.Label();
            this.labelB_V = new System.Windows.Forms.Label();
            this.labelC_V = new System.Windows.Forms.Label();
            this.labelR_Speed = new System.Windows.Forms.Label();
            this.labelA_Action = new System.Windows.Forms.Label();
            this.labelB_Action = new System.Windows.Forms.Label();
            this.labelC_Action = new System.Windows.Forms.Label();
            this.labelE_Speed = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelExhaust = new System.Windows.Forms.Label();
            this.labelFeed = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelD_Time = new System.Windows.Forms.Label();
            this.btnStartStopVideo = new System.Windows.Forms.Button();
            this.labelVideoInfo = new System.Windows.Forms.Label();
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.labelLastUpdateTime = new System.Windows.Forms.Label();
            this.pbCameraView = new AForge.Controls.PictureBox();
            this.btnHistoryData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCameras
            // 
            this.lbCameras.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCameras.FormattingEnabled = true;
            this.lbCameras.ItemHeight = 19;
            this.lbCameras.Location = new System.Drawing.Point(12, 74);
            this.lbCameras.Name = "lbCameras";
            this.lbCameras.Size = new System.Drawing.Size(210, 422);
            this.lbCameras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "厂房编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "电熔镁炉编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(280, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "A相电流：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(281, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "B相电流：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(281, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "C相电流：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(454, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "A相电压：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(455, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "B相电压：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(456, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "C相电压：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(451, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "排气指示：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(256, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "手/自动状态：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(612, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "加料指示：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(629, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "A动作：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(629, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "B动作：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(629, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "C动作：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(262, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "电流设定值：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(582, 181);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 19);
            this.label18.TabIndex = 19;
            this.label18.Text = "手动电极速度：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(423, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 19);
            this.label17.TabIndex = 20;
            this.label17.Text = "炉体转动速度：";
            // 
            // btnAddCamera
            // 
            this.btnAddCamera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddCamera.Location = new System.Drawing.Point(147, 509);
            this.btnAddCamera.Name = "btnAddCamera";
            this.btnAddCamera.Size = new System.Drawing.Size(75, 31);
            this.btnAddCamera.TabIndex = 21;
            this.btnAddCamera.Text = "添加相机";
            this.btnAddCamera.UseVisualStyleBackColor = true;
            this.btnAddCamera.Click += new System.EventHandler(this.btnAddCamera_Click);
            // 
            // btnDeleteCamera
            // 
            this.btnDeleteCamera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteCamera.Location = new System.Drawing.Point(12, 509);
            this.btnDeleteCamera.Name = "btnDeleteCamera";
            this.btnDeleteCamera.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteCamera.TabIndex = 22;
            this.btnDeleteCamera.Text = "删除相机";
            this.btnDeleteCamera.UseVisualStyleBackColor = true;
            this.btnDeleteCamera.Click += new System.EventHandler(this.btnDeleteCamera_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnViewAll.Location = new System.Drawing.Point(697, 285);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 30);
            this.btnViewAll.TabIndex = 23;
            this.btnViewAll.Text = "显示所有";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // labelFactoryNO
            // 
            this.labelFactoryNO.AutoSize = true;
            this.labelFactoryNO.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFactoryNO.Location = new System.Drawing.Point(180, 18);
            this.labelFactoryNO.Name = "labelFactoryNO";
            this.labelFactoryNO.Size = new System.Drawing.Size(41, 20);
            this.labelFactoryNO.TabIndex = 24;
            this.labelFactoryNO.Text = "0001";
            // 
            // labelA_I
            // 
            this.labelA_I.AutoSize = true;
            this.labelA_I.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA_I.Location = new System.Drawing.Point(355, 59);
            this.labelA_I.Name = "labelA_I";
            this.labelA_I.Size = new System.Drawing.Size(28, 20);
            this.labelA_I.TabIndex = 25;
            this.labelA_I.Text = "0.0";
            // 
            // labelB_I
            // 
            this.labelB_I.AutoSize = true;
            this.labelB_I.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB_I.Location = new System.Drawing.Point(355, 89);
            this.labelB_I.Name = "labelB_I";
            this.labelB_I.Size = new System.Drawing.Size(28, 20);
            this.labelB_I.TabIndex = 26;
            this.labelB_I.Text = "0.0";
            // 
            // labelC_I
            // 
            this.labelC_I.AutoSize = true;
            this.labelC_I.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelC_I.Location = new System.Drawing.Point(355, 119);
            this.labelC_I.Name = "labelC_I";
            this.labelC_I.Size = new System.Drawing.Size(28, 20);
            this.labelC_I.TabIndex = 27;
            this.labelC_I.Text = "0.0";
            // 
            // labelI_Default
            // 
            this.labelI_Default.AutoSize = true;
            this.labelI_Default.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelI_Default.Location = new System.Drawing.Point(355, 182);
            this.labelI_Default.Name = "labelI_Default";
            this.labelI_Default.Size = new System.Drawing.Size(28, 20);
            this.labelI_Default.TabIndex = 28;
            this.labelI_Default.Text = "0.0";
            // 
            // labelFurnaceNO
            // 
            this.labelFurnaceNO.AutoSize = true;
            this.labelFurnaceNO.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFurnaceNO.Location = new System.Drawing.Point(180, 42);
            this.labelFurnaceNO.Name = "labelFurnaceNO";
            this.labelFurnaceNO.Size = new System.Drawing.Size(41, 20);
            this.labelFurnaceNO.TabIndex = 29;
            this.labelFurnaceNO.Text = "0001";
            // 
            // labelA_V
            // 
            this.labelA_V.AutoSize = true;
            this.labelA_V.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA_V.Location = new System.Drawing.Point(529, 58);
            this.labelA_V.Name = "labelA_V";
            this.labelA_V.Size = new System.Drawing.Size(28, 20);
            this.labelA_V.TabIndex = 30;
            this.labelA_V.Text = "0.0";
            // 
            // labelB_V
            // 
            this.labelB_V.AutoSize = true;
            this.labelB_V.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB_V.Location = new System.Drawing.Point(529, 88);
            this.labelB_V.Name = "labelB_V";
            this.labelB_V.Size = new System.Drawing.Size(41, 20);
            this.labelB_V.TabIndex = 31;
            this.labelB_V.Text = "0001";
            // 
            // labelC_V
            // 
            this.labelC_V.AutoSize = true;
            this.labelC_V.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelC_V.Location = new System.Drawing.Point(529, 119);
            this.labelC_V.Name = "labelC_V";
            this.labelC_V.Size = new System.Drawing.Size(41, 20);
            this.labelC_V.TabIndex = 32;
            this.labelC_V.Text = "0001";
            // 
            // labelR_Speed
            // 
            this.labelR_Speed.AutoSize = true;
            this.labelR_Speed.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelR_Speed.Location = new System.Drawing.Point(529, 181);
            this.labelR_Speed.Name = "labelR_Speed";
            this.labelR_Speed.Size = new System.Drawing.Size(28, 20);
            this.labelR_Speed.TabIndex = 33;
            this.labelR_Speed.Text = "0.0";
            // 
            // labelA_Action
            // 
            this.labelA_Action.AutoSize = true;
            this.labelA_Action.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA_Action.Location = new System.Drawing.Point(688, 58);
            this.labelA_Action.Name = "labelA_Action";
            this.labelA_Action.Size = new System.Drawing.Size(28, 20);
            this.labelA_Action.TabIndex = 34;
            this.labelA_Action.Text = "0.0";
            // 
            // labelB_Action
            // 
            this.labelB_Action.AutoSize = true;
            this.labelB_Action.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB_Action.Location = new System.Drawing.Point(688, 88);
            this.labelB_Action.Name = "labelB_Action";
            this.labelB_Action.Size = new System.Drawing.Size(28, 20);
            this.labelB_Action.TabIndex = 35;
            this.labelB_Action.Text = "0.0";
            // 
            // labelC_Action
            // 
            this.labelC_Action.AutoSize = true;
            this.labelC_Action.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelC_Action.Location = new System.Drawing.Point(688, 120);
            this.labelC_Action.Name = "labelC_Action";
            this.labelC_Action.Size = new System.Drawing.Size(28, 20);
            this.labelC_Action.TabIndex = 36;
            this.labelC_Action.Text = "0.0";
            // 
            // labelE_Speed
            // 
            this.labelE_Speed.AutoSize = true;
            this.labelE_Speed.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelE_Speed.Location = new System.Drawing.Point(688, 181);
            this.labelE_Speed.Name = "labelE_Speed";
            this.labelE_Speed.Size = new System.Drawing.Size(28, 20);
            this.labelE_Speed.TabIndex = 37;
            this.labelE_Speed.Text = "0.0";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStatus.Location = new System.Drawing.Point(355, 151);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 20);
            this.labelStatus.TabIndex = 38;
            this.labelStatus.Text = "手动";
            // 
            // labelExhaust
            // 
            this.labelExhaust.AutoSize = true;
            this.labelExhaust.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExhaust.Location = new System.Drawing.Point(529, 151);
            this.labelExhaust.Name = "labelExhaust";
            this.labelExhaust.Size = new System.Drawing.Size(37, 20);
            this.labelExhaust.TabIndex = 39;
            this.labelExhaust.Text = "需要";
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFeed.Location = new System.Drawing.Point(688, 152);
            this.labelFeed.Name = "labelFeed";
            this.labelFeed.Size = new System.Drawing.Size(37, 20);
            this.labelFeed.TabIndex = 40;
            this.labelFeed.Text = "需要";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(263, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "数据时间戳：";
            // 
            // labelD_Time
            // 
            this.labelD_Time.AutoSize = true;
            this.labelD_Time.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelD_Time.Location = new System.Drawing.Point(355, 209);
            this.labelD_Time.Name = "labelD_Time";
            this.labelD_Time.Size = new System.Drawing.Size(143, 20);
            this.labelD_Time.TabIndex = 42;
            this.labelD_Time.Text = "2017-11-11 11:11:11";
            // 
            // btnStartStopVideo
            // 
            this.btnStartStopVideo.BackColor = System.Drawing.Color.LightGreen;
            this.btnStartStopVideo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartStopVideo.Location = new System.Drawing.Point(697, 249);
            this.btnStartStopVideo.Name = "btnStartStopVideo";
            this.btnStartStopVideo.Size = new System.Drawing.Size(75, 30);
            this.btnStartStopVideo.TabIndex = 43;
            this.btnStartStopVideo.Text = "显示视频";
            this.btnStartStopVideo.UseVisualStyleBackColor = false;
            this.btnStartStopVideo.Click += new System.EventHandler(this.btnStartStopVideo_Click);
            // 
            // labelVideoInfo
            // 
            this.labelVideoInfo.AutoSize = true;
            this.labelVideoInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVideoInfo.Location = new System.Drawing.Point(329, 540);
            this.labelVideoInfo.Name = "labelVideoInfo";
            this.labelVideoInfo.Size = new System.Drawing.Size(248, 17);
            this.labelVideoInfo.TabIndex = 44;
            this.labelVideoInfo.Text = "请先在左侧选择相机，然后点击“显示视频”";
            this.labelVideoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerGetData
            // 
            this.timerGetData.Interval = 500;
            this.timerGetData.Tick += new System.EventHandler(this.timerGetData_Tick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(558, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 17);
            this.label19.TabIndex = 45;
            this.label19.Text = "最后更新时间：";
            // 
            // labelLastUpdateTime
            // 
            this.labelLastUpdateTime.AutoSize = true;
            this.labelLastUpdateTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLastUpdateTime.Location = new System.Drawing.Point(653, 9);
            this.labelLastUpdateTime.Name = "labelLastUpdateTime";
            this.labelLastUpdateTime.Size = new System.Drawing.Size(126, 17);
            this.labelLastUpdateTime.TabIndex = 46;
            this.labelLastUpdateTime.Text = "2017-11-11 11:11:11";
            // 
            // pbCameraView
            // 
            this.pbCameraView.BackgroundImage = global::Monitor.Properties.Resources.no_video;
            this.pbCameraView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCameraView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCameraView.Image = null;
            this.pbCameraView.Location = new System.Drawing.Point(329, 249);
            this.pbCameraView.Name = "pbCameraView";
            this.pbCameraView.Size = new System.Drawing.Size(352, 288);
            this.pbCameraView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCameraView.TabIndex = 0;
            this.pbCameraView.TabStop = false;
            // 
            // btnHistoryData
            // 
            this.btnHistoryData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHistoryData.Location = new System.Drawing.Point(697, 498);
            this.btnHistoryData.Name = "btnHistoryData";
            this.btnHistoryData.Size = new System.Drawing.Size(75, 30);
            this.btnHistoryData.TabIndex = 47;
            this.btnHistoryData.Text = "历史数据";
            this.btnHistoryData.UseVisualStyleBackColor = true;
            this.btnHistoryData.Click += new System.EventHandler(this.btnHistoryData_Click);
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHistoryData);
            this.Controls.Add(this.labelLastUpdateTime);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.labelVideoInfo);
            this.Controls.Add(this.btnStartStopVideo);
            this.Controls.Add(this.labelD_Time);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFeed);
            this.Controls.Add(this.labelExhaust);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelE_Speed);
            this.Controls.Add(this.labelC_Action);
            this.Controls.Add(this.labelB_Action);
            this.Controls.Add(this.labelA_Action);
            this.Controls.Add(this.labelR_Speed);
            this.Controls.Add(this.labelC_V);
            this.Controls.Add(this.labelB_V);
            this.Controls.Add(this.labelA_V);
            this.Controls.Add(this.labelFurnaceNO);
            this.Controls.Add(this.labelI_Default);
            this.Controls.Add(this.labelC_I);
            this.Controls.Add(this.labelB_I);
            this.Controls.Add(this.labelA_I);
            this.Controls.Add(this.labelFactoryNO);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnDeleteCamera);
            this.Controls.Add(this.btnAddCamera);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCameras);
            this.Controls.Add(this.pbCameraView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonitorForm";
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonitorForm_FormClosing);
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.PictureBox pbCameraView;
        private System.Windows.Forms.ListBox lbCameras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAddCamera;
        private System.Windows.Forms.Button btnDeleteCamera;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label labelFactoryNO;
        private System.Windows.Forms.Label labelA_I;
        private System.Windows.Forms.Label labelB_I;
        private System.Windows.Forms.Label labelC_I;
        private System.Windows.Forms.Label labelI_Default;
        private System.Windows.Forms.Label labelFurnaceNO;
        private System.Windows.Forms.Label labelA_V;
        private System.Windows.Forms.Label labelB_V;
        private System.Windows.Forms.Label labelC_V;
        private System.Windows.Forms.Label labelR_Speed;
        private System.Windows.Forms.Label labelA_Action;
        private System.Windows.Forms.Label labelB_Action;
        private System.Windows.Forms.Label labelC_Action;
        private System.Windows.Forms.Label labelE_Speed;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelExhaust;
        private System.Windows.Forms.Label labelFeed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelD_Time;
        private System.Windows.Forms.Button btnStartStopVideo;
        private System.Windows.Forms.Label labelVideoInfo;
        private System.Windows.Forms.Timer timerGetData;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelLastUpdateTime;
        private System.Windows.Forms.Button btnHistoryData;

    }
}

