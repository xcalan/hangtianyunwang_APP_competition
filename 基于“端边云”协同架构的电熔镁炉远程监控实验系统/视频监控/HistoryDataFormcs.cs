using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Monitor.Models;
using Npgsql;

namespace Monitor {
    public partial class HistoryDataFormcs: Form {
        private MonitorForm parentForm;

        private List<CameraData> data;
        private Camera camera;

        private void fillCameraData() {
            foreach (var serie in chartView.Series) {
                serie.Points.Clear();
            }
            if (data.Count > 0) {
                data.ForEach(d => {
                    chartView.Series[0].Points.AddY(d.a_i);
                    chartView.Series[1].Points.AddY(d.b_i);
                    chartView.Series[2].Points.AddY(d.c_i);
                    chartView.Series[3].Points.AddY(d.a_v);
                    chartView.Series[4].Points.AddY(d.b_v);
                    chartView.Series[5].Points.AddY(d.c_v);
                    chartView.Series[6].Points.AddY(d.a_action);
                    chartView.Series[7].Points.AddY(d.a_action);
                    chartView.Series[8].Points.AddY(d.a_action);
                    chartView.Series[9].Points.AddY(d.e_speed);
                    chartView.Series[10].Points.AddY(d.r_speed);
                });
                chartView.Update();
            } else {
                MessageBox.Show("没有当前相机的数据！");
            }
        }

        public HistoryDataFormcs(MonitorForm parent, Camera camera) {
            InitializeComponent();
            this.parentForm = parent;
            this.camera = camera;
        }

        private void HistoryDataFormcs_Load(object sender, EventArgs e) {
            labelFactoryNO.Text = camera.factoryNo.ToString();
            labelFurnaceNO.Text = camera.furnaceNo.ToString();
            try {
                data = parentForm.pgsql.getCameraData(camera.factoryNo, camera.furnaceNo, 20);
            } catch (NpgsqlException ex) {
                MessageBox.Show("获取数据失败！\n" + ex.Message);
            }
            fillCameraData();
        }

        private void btnGetData_Click(object sender, EventArgs e) {
            data = parentForm.pgsql.getCameraData(camera.factoryNo, camera.furnaceNo, (int)numDataCount.Value);
            fillCameraData();
        }

        private void cbA_I_CheckedChanged(object sender, EventArgs e) {
            if (cbA_I.Checked) {
                chartView.Series[0].Enabled = true;
            } else {
                chartView.Series[0].Enabled = false;
            }
        }

        private void cbB_I_CheckedChanged(object sender, EventArgs e) {
            if (cbB_I.Checked) {
                chartView.Series[1].Enabled = true;
            } else {
                chartView.Series[1].Enabled = false;
            }
        }

        private void cbC_I_CheckedChanged(object sender, EventArgs e) {
            if (cbC_I.Checked) {
                chartView.Series[2].Enabled = true;
            } else {
                chartView.Series[2].Enabled = false;
            }
        }

        private void cbA_V_CheckedChanged(object sender, EventArgs e) {
            if (cbA_V.Checked) {
                chartView.Series[3].Enabled = true;
            } else {
                chartView.Series[3].Enabled = false;
            }
        }

        private void cbB_V_CheckedChanged(object sender, EventArgs e) {
            if (cbB_V.Checked) {
                chartView.Series[4].Enabled = true;
            } else {
                chartView.Series[4].Enabled = false;
            }
        }

        private void cbC_V_CheckedChanged(object sender, EventArgs e) {
            if (cbC_V.Checked) {
                chartView.Series[5].Enabled = true;
            } else {
                chartView.Series[5].Enabled = false;
            }
        }

        private void cbA_Action_CheckedChanged(object sender, EventArgs e) {
            if (cbA_Action.Checked) {
                chartView.Series[6].Enabled = true;
            } else {
                chartView.Series[6].Enabled = false;
            }
        }

        private void cbB_Action_CheckedChanged(object sender, EventArgs e) {
            if (cbB_Action.Checked) {
                chartView.Series[7].Enabled = true;
            } else {
                chartView.Series[7].Enabled = false;
            }
        }

        private void cbC_action_CheckedChanged(object sender, EventArgs e) {
            if (cbC_Action.Checked) {
                chartView.Series[8].Enabled = true;
            } else {
                chartView.Series[8].Enabled = false;
            }
        }

        private void cbE_Speed_CheckedChanged(object sender, EventArgs e) {
            if (cbE_Speed.Checked) {
                chartView.Series[9].Enabled = true;
            } else {
                chartView.Series[9].Enabled = false;
            }
        }

        private void cbR_Speed_CheckedChanged(object sender, EventArgs e) {
            if (cbR_Speed.Checked) {
                chartView.Series[10].Enabled = true;
            } else {
                chartView.Series[10].Enabled = false;
            }
        }

       
    }
}
