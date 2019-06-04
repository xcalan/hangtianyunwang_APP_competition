namespace Monitor {
    partial class AddCameraForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCameraForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIPAddr = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numFactoryNo = new System.Windows.Forms.NumericUpDown();
            this.numFurnaceNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactoryNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFurnaceNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(277, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(291, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "说明信息：";
            // 
            // tbIPAddr
            // 
            this.tbIPAddr.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIPAddr.Location = new System.Drawing.Point(349, 35);
            this.tbIPAddr.Name = "tbIPAddr";
            this.tbIPAddr.Size = new System.Drawing.Size(151, 25);
            this.tbIPAddr.TabIndex = 3;
            this.tbIPAddr.Text = "47.93.7.123";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTitle.Location = new System.Drawing.Point(97, 115);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(151, 25);
            this.tbTitle.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(281, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numPort
            // 
            this.numPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numPort.Location = new System.Drawing.Point(349, 77);
            this.numPort.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(151, 23);
            this.numPort.TabIndex = 7;
            this.numPort.Value = new decimal(new int[] {
            30001,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "厂房编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "熔炉编号：";
            // 
            // numFactoryNo
            // 
            this.numFactoryNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numFactoryNo.Location = new System.Drawing.Point(98, 37);
            this.numFactoryNo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numFactoryNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFactoryNo.Name = "numFactoryNo";
            this.numFactoryNo.Size = new System.Drawing.Size(151, 23);
            this.numFactoryNo.TabIndex = 10;
            this.numFactoryNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numFurnaceNo
            // 
            this.numFurnaceNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numFurnaceNo.Location = new System.Drawing.Point(98, 77);
            this.numFurnaceNo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numFurnaceNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFurnaceNo.Name = "numFurnaceNo";
            this.numFurnaceNo.Size = new System.Drawing.Size(151, 23);
            this.numFurnaceNo.TabIndex = 11;
            this.numFurnaceNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddCameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 170);
            this.Controls.Add(this.numFurnaceNo);
            this.Controls.Add(this.numFactoryNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbIPAddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCameraForm";
            this.Text = "AddCamera";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactoryNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFurnaceNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIPAddr;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFactoryNo;
        private System.Windows.Forms.NumericUpDown numFurnaceNo;
    }
}