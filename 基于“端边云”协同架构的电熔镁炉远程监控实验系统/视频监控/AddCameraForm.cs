using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using Monitor.Models;

namespace Monitor {
    public partial class AddCameraForm: Form {
        Regex ipPattern = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
        MonitorForm parent;

        public AddCameraForm(MonitorForm parent) {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Match m = ipPattern.Match(tbIPAddr.Text);
            if (!m.Success) {
                MessageBox.Show("IP 地址格式错误！");
                return;
            }
            try{
                Camera camera = new Camera(IPAddress.Parse(tbIPAddr.Text), (int)numPort.Value, tbTitle.Text,
                                           (int)numFactoryNo.Value, (int)numFurnaceNo.Value);
                parent.sqlite.addCamera(camera);
                parent.addCamera(camera);
                MessageBox.Show("添加成功！");
            } catch (SQLiteException) {
                MessageBox.Show("添加失败！请检查此相机是否已经添加。");
            }
        }
    }
}
