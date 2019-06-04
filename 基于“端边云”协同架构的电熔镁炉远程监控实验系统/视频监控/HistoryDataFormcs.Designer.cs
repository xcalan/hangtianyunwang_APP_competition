namespace Monitor {
    partial class HistoryDataFormcs {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryDataFormcs));
            this.chartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFurnaceNO = new System.Windows.Forms.Label();
            this.labelFactoryNO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDataCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.cbA_I = new System.Windows.Forms.CheckBox();
            this.cbB_I = new System.Windows.Forms.CheckBox();
            this.cbC_I = new System.Windows.Forms.CheckBox();
            this.cbC_V = new System.Windows.Forms.CheckBox();
            this.cbA_V = new System.Windows.Forms.CheckBox();
            this.cbB_V = new System.Windows.Forms.CheckBox();
            this.cbA_Action = new System.Windows.Forms.CheckBox();
            this.cbB_Action = new System.Windows.Forms.CheckBox();
            this.cbC_Action = new System.Windows.Forms.CheckBox();
            this.cbE_Speed = new System.Windows.Forms.CheckBox();
            this.cbR_Speed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataCount)).BeginInit();
            this.SuspendLayout();
            // 
            // chartView
            // 
            chartArea1.Name = "ChartArea1";
            this.chartView.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.chartView.Legends.Add(legend1);
            this.chartView.Location = new System.Drawing.Point(115, 92);
            this.chartView.Name = "chartView";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "A相电流";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "B相电流";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "C相电流";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "A相电压";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "B相电压";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "C相电压";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "A动作";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "B动作";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "C动作";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "电极速度";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "转动速度";
            this.chartView.Series.Add(series1);
            this.chartView.Series.Add(series2);
            this.chartView.Series.Add(series3);
            this.chartView.Series.Add(series4);
            this.chartView.Series.Add(series5);
            this.chartView.Series.Add(series6);
            this.chartView.Series.Add(series7);
            this.chartView.Series.Add(series8);
            this.chartView.Series.Add(series9);
            this.chartView.Series.Add(series10);
            this.chartView.Series.Add(series11);
            this.chartView.Size = new System.Drawing.Size(817, 577);
            this.chartView.TabIndex = 0;
            this.chartView.Text = "历史数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(776, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "电熔镁炉编号：";
            // 
            // labelFurnaceNO
            // 
            this.labelFurnaceNO.AutoSize = true;
            this.labelFurnaceNO.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFurnaceNO.Location = new System.Drawing.Point(885, 59);
            this.labelFurnaceNO.Name = "labelFurnaceNO";
            this.labelFurnaceNO.Size = new System.Drawing.Size(41, 20);
            this.labelFurnaceNO.TabIndex = 33;
            this.labelFurnaceNO.Text = "0001";
            // 
            // labelFactoryNO
            // 
            this.labelFactoryNO.AutoSize = true;
            this.labelFactoryNO.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFactoryNO.Location = new System.Drawing.Point(885, 35);
            this.labelFactoryNO.Name = "labelFactoryNO";
            this.labelFactoryNO.Size = new System.Drawing.Size(41, 20);
            this.labelFactoryNO.TabIndex = 32;
            this.labelFactoryNO.Text = "0001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(804, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "厂房编号：";
            // 
            // numDataCount
            // 
            this.numDataCount.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numDataCount.Location = new System.Drawing.Point(200, 52);
            this.numDataCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numDataCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDataCount.Name = "numDataCount";
            this.numDataCount.Size = new System.Drawing.Size(120, 25);
            this.numDataCount.TabIndex = 34;
            this.numDataCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(116, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "数据数量：";
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetData.Location = new System.Drawing.Point(328, 50);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 28);
            this.btnGetData.TabIndex = 36;
            this.btnGetData.Text = "获取数据";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // cbA_I
            // 
            this.cbA_I.AutoSize = true;
            this.cbA_I.Checked = true;
            this.cbA_I.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbA_I.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbA_I.Location = new System.Drawing.Point(12, 111);
            this.cbA_I.Name = "cbA_I";
            this.cbA_I.Size = new System.Drawing.Size(80, 24);
            this.cbA_I.TabIndex = 37;
            this.cbA_I.Text = "A相电流";
            this.cbA_I.UseVisualStyleBackColor = true;
            this.cbA_I.CheckedChanged += new System.EventHandler(this.cbA_I_CheckedChanged);
            // 
            // cbB_I
            // 
            this.cbB_I.AutoSize = true;
            this.cbB_I.Checked = true;
            this.cbB_I.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbB_I.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbB_I.Location = new System.Drawing.Point(12, 141);
            this.cbB_I.Name = "cbB_I";
            this.cbB_I.Size = new System.Drawing.Size(79, 24);
            this.cbB_I.TabIndex = 38;
            this.cbB_I.Text = "B相电流";
            this.cbB_I.UseVisualStyleBackColor = true;
            this.cbB_I.CheckedChanged += new System.EventHandler(this.cbB_I_CheckedChanged);
            // 
            // cbC_I
            // 
            this.cbC_I.AutoSize = true;
            this.cbC_I.Checked = true;
            this.cbC_I.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbC_I.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbC_I.Location = new System.Drawing.Point(12, 171);
            this.cbC_I.Name = "cbC_I";
            this.cbC_I.Size = new System.Drawing.Size(79, 24);
            this.cbC_I.TabIndex = 39;
            this.cbC_I.Text = "C相电流";
            this.cbC_I.UseVisualStyleBackColor = true;
            this.cbC_I.CheckedChanged += new System.EventHandler(this.cbC_I_CheckedChanged);
            // 
            // cbC_V
            // 
            this.cbC_V.AutoSize = true;
            this.cbC_V.Checked = true;
            this.cbC_V.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbC_V.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbC_V.Location = new System.Drawing.Point(12, 261);
            this.cbC_V.Name = "cbC_V";
            this.cbC_V.Size = new System.Drawing.Size(79, 24);
            this.cbC_V.TabIndex = 40;
            this.cbC_V.Text = "C相电压";
            this.cbC_V.UseVisualStyleBackColor = true;
            this.cbC_V.CheckedChanged += new System.EventHandler(this.cbC_V_CheckedChanged);
            // 
            // cbA_V
            // 
            this.cbA_V.AutoSize = true;
            this.cbA_V.Checked = true;
            this.cbA_V.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbA_V.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbA_V.Location = new System.Drawing.Point(12, 201);
            this.cbA_V.Name = "cbA_V";
            this.cbA_V.Size = new System.Drawing.Size(80, 24);
            this.cbA_V.TabIndex = 41;
            this.cbA_V.Text = "A相电压";
            this.cbA_V.UseVisualStyleBackColor = true;
            this.cbA_V.CheckedChanged += new System.EventHandler(this.cbA_V_CheckedChanged);
            // 
            // cbB_V
            // 
            this.cbB_V.AutoSize = true;
            this.cbB_V.Checked = true;
            this.cbB_V.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbB_V.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbB_V.Location = new System.Drawing.Point(12, 231);
            this.cbB_V.Name = "cbB_V";
            this.cbB_V.Size = new System.Drawing.Size(79, 24);
            this.cbB_V.TabIndex = 42;
            this.cbB_V.Text = "B相电压";
            this.cbB_V.UseVisualStyleBackColor = true;
            this.cbB_V.CheckedChanged += new System.EventHandler(this.cbB_V_CheckedChanged);
            // 
            // cbA_Action
            // 
            this.cbA_Action.AutoSize = true;
            this.cbA_Action.Checked = true;
            this.cbA_Action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbA_Action.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbA_Action.Location = new System.Drawing.Point(12, 291);
            this.cbA_Action.Name = "cbA_Action";
            this.cbA_Action.Size = new System.Drawing.Size(66, 24);
            this.cbA_Action.TabIndex = 43;
            this.cbA_Action.Text = "A动作";
            this.cbA_Action.UseVisualStyleBackColor = true;
            this.cbA_Action.CheckedChanged += new System.EventHandler(this.cbA_Action_CheckedChanged);
            // 
            // cbB_Action
            // 
            this.cbB_Action.AutoSize = true;
            this.cbB_Action.Checked = true;
            this.cbB_Action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbB_Action.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbB_Action.Location = new System.Drawing.Point(12, 321);
            this.cbB_Action.Name = "cbB_Action";
            this.cbB_Action.Size = new System.Drawing.Size(65, 24);
            this.cbB_Action.TabIndex = 44;
            this.cbB_Action.Text = "B动作";
            this.cbB_Action.UseVisualStyleBackColor = true;
            this.cbB_Action.CheckedChanged += new System.EventHandler(this.cbB_Action_CheckedChanged);
            // 
            // cbC_Action
            // 
            this.cbC_Action.AutoSize = true;
            this.cbC_Action.Checked = true;
            this.cbC_Action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbC_Action.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbC_Action.Location = new System.Drawing.Point(12, 351);
            this.cbC_Action.Name = "cbC_Action";
            this.cbC_Action.Size = new System.Drawing.Size(65, 24);
            this.cbC_Action.TabIndex = 45;
            this.cbC_Action.Text = "C动作";
            this.cbC_Action.UseVisualStyleBackColor = true;
            this.cbC_Action.CheckedChanged += new System.EventHandler(this.cbC_action_CheckedChanged);
            // 
            // cbE_Speed
            // 
            this.cbE_Speed.AutoSize = true;
            this.cbE_Speed.Checked = true;
            this.cbE_Speed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbE_Speed.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbE_Speed.Location = new System.Drawing.Point(12, 381);
            this.cbE_Speed.Name = "cbE_Speed";
            this.cbE_Speed.Size = new System.Drawing.Size(84, 24);
            this.cbE_Speed.TabIndex = 46;
            this.cbE_Speed.Text = "电极速度";
            this.cbE_Speed.UseVisualStyleBackColor = true;
            this.cbE_Speed.CheckedChanged += new System.EventHandler(this.cbE_Speed_CheckedChanged);
            // 
            // cbR_Speed
            // 
            this.cbR_Speed.AutoSize = true;
            this.cbR_Speed.Checked = true;
            this.cbR_Speed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbR_Speed.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbR_Speed.Location = new System.Drawing.Point(12, 411);
            this.cbR_Speed.Name = "cbR_Speed";
            this.cbR_Speed.Size = new System.Drawing.Size(84, 24);
            this.cbR_Speed.TabIndex = 47;
            this.cbR_Speed.Text = "转动速度";
            this.cbR_Speed.UseVisualStyleBackColor = true;
            this.cbR_Speed.CheckedChanged += new System.EventHandler(this.cbR_Speed_CheckedChanged);
            // 
            // HistoryDataFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.cbR_Speed);
            this.Controls.Add(this.cbE_Speed);
            this.Controls.Add(this.cbC_Action);
            this.Controls.Add(this.cbB_Action);
            this.Controls.Add(this.cbA_Action);
            this.Controls.Add(this.cbB_V);
            this.Controls.Add(this.cbA_V);
            this.Controls.Add(this.cbC_V);
            this.Controls.Add(this.cbC_I);
            this.Controls.Add(this.cbB_I);
            this.Controls.Add(this.cbA_I);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDataCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFurnaceNO);
            this.Controls.Add(this.labelFactoryNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryDataFormcs";
            this.Text = "HistoryDataFormcs";
            this.Load += new System.EventHandler(this.HistoryDataFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFurnaceNO;
        private System.Windows.Forms.Label labelFactoryNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDataCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.CheckBox cbA_I;
        private System.Windows.Forms.CheckBox cbB_I;
        private System.Windows.Forms.CheckBox cbC_I;
        private System.Windows.Forms.CheckBox cbC_V;
        private System.Windows.Forms.CheckBox cbA_V;
        private System.Windows.Forms.CheckBox cbB_V;
        private System.Windows.Forms.CheckBox cbA_Action;
        private System.Windows.Forms.CheckBox cbB_Action;
        private System.Windows.Forms.CheckBox cbC_Action;
        private System.Windows.Forms.CheckBox cbE_Speed;
        private System.Windows.Forms.CheckBox cbR_Speed;

    }
}