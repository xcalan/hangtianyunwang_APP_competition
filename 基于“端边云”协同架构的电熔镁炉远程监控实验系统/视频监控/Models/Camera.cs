using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Data;
using System.Threading.Tasks;

namespace Monitor.Models {
    public class Camera {
        public static string sql = @"create table if not exists camera (
           id integer primary key autoincrement,
           ip varchar(15) not null,
           port integer not null,
           title varchar(64),
           factory_no integer not null,
           furnace_no integer not null,
           unique(ip, port),
           unique(factory_no, furnace_no)
         );";

        public IPAddress ip {
            get;
            set;
        }
        public int port {
            get;
            set;
        }
        public string title {
            get;
            set;
        }
        public int factoryNo {
            get;
            set;
        }
        public int furnaceNo {
            get;
            set;
        }

        public Camera(IPAddress ip, int port, string title, int factoryNo, int furnaceNo) {
            this.ip = ip;
            this.port = port;
            this.title = title;
            this.factoryNo = factoryNo;
            this.furnaceNo = furnaceNo;
        }

        public override string ToString() {
            return string.Format("{0}({1}-{2})", title, factoryNo, furnaceNo);
        }

        public string ToFullString() {
            return string.Format("{0}({1}-{2})@{3}:{4}", title, factoryNo, furnaceNo, ip, port);
        }
    }
}
