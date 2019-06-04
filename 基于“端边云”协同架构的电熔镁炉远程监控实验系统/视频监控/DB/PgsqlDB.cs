using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using Monitor.Models;
using log4net;


namespace Monitor.DB {
    public class PgsqlDB {

        public static DateTime timestampToDateTime(double timestamp) {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(timestamp).ToLocalTime();
            return dt;
        }

        public static DateTime timestampToDateTime(NpgsqlDateTime timestamp) {
            return timestamp.ToDateTime();
        }

        NpgsqlConnection conn = null;

        #region Database Methods
        public PgsqlDB() {
            //
        }
        public PgsqlDB(string host, string name, string user, string password) {
            conn = new NpgsqlConnection(string.Format("Host={0};Database={1};Username={2};Password={3}",
                                                      host, name, user, password));
        }

        public void open() {
            if (conn.State == ConnectionState.Closed) {
                conn.Open();
            }
        }

        public void connect(string host, string name, string user, string password) {
            if (conn.State == ConnectionState.Closed) {
                conn = new NpgsqlConnection(string.Format("Host={0};Database={1};Username={2};Password={3}",
                                                      host, name, user, password));
                conn.Open();
            } else {
                throw new Exception("database has beed opened!");
            }
        }

        public void close() {
            if (conn.State != ConnectionState.Closed) {
                conn.Close();
            }
        }
        #endregion


        #region Data Operator
        public void addCamera(Camera camera) {
            addCamera(camera.ip, camera.port, camera.title, camera.factoryNo, camera.furnaceNo);
        }

        public void addCamera(IPAddress ip, int port, string title, int factory, int furnace) {
            string sql = "insert into Camera(ip, port, title, factory_no, furnace_no) values (@ip, @port, @title, @factory, @furnace)";
            
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@ip", NpgsqlDbType.Inet, ip);
                cmd.Parameters.AddWithValue("@port", NpgsqlDbType.Integer, port);
                cmd.Parameters.AddWithValue("@title", NpgsqlDbType.Varchar, title);
                cmd.Parameters.AddWithValue("@factory", NpgsqlDbType.Integer, factory);
                cmd.Parameters.AddWithValue("@furnace", NpgsqlDbType.Integer, furnace);

                cmd.ExecuteNonQuery();
            }
        }


        public void deleteCamera(Camera camera) {
            deleteCamera(camera.ip, camera.port);
        }

        public void deleteCamera(IPAddress ip, int port) {
            string sql = "delete from camera where ip=@ip and port=@port;";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@ip", NpgsqlDbType.Inet, ip);
                cmd.Parameters.AddWithValue("@port", NpgsqlDbType.Integer, port);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Camera> getCameras() {
            string sql = "select ip,port,title,factory_no,furnace_no from camera";
            List<Camera> cameras = new List<Camera>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)) {
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        IPAddress ip = IPAddress.Parse(reader.GetString(0));
                        int port = reader.GetInt32(1);
                        string title = reader.GetString(2);
                        int factoryNo = reader.GetInt32(3);
                        int furnaceNo = reader.GetInt32(4);
                        cameras.Add(new Camera(ip, port, title, factoryNo, furnaceNo));
                    }
                }
                reader.Close();
            }
            return cameras;
        }

        /// <summary>
        /// 获取当前相机对应数据
        /// </summary>
        /// <param name="factory_no">厂房编号</param>
        /// <param name="furnace_no">电熔镁炉编号</param>
        /// <returns>最新的一条数据</returns>
        public CameraData getCameraData(int factory_no, int furnace_no) {
            List<CameraData> data = getCameraData(factory_no, furnace_no, 1);
            if (data.Count > 0) {
                return data[0];
            }
            return null;
        }

        public List<CameraData> getCameraData(int factory_no, int furnace_no, int limit=20) {
            string sql = "select a_i,b_i,c_i,i_default," +
                "a_v,b_v,c_v,e_speed,r_speed,a_action,b_action,c_action,status,feed,exhaust,d_time from camera_data " +
                "where factory_no=@fac_no and furnace_no=@fur_no order by d_time desc limit @limit_num";
            List<CameraData> data = new List<CameraData>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@fac_no", NpgsqlDbType.Integer, factory_no);
                cmd.Parameters.AddWithValue("@fur_no", NpgsqlDbType.Integer, furnace_no);
                cmd.Parameters.AddWithValue("@limit_num", NpgsqlDbType.Integer, limit);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        CameraData cd = new CameraData();
                        cd.a_i = reader.GetFloat(0);
                        cd.b_i = reader.GetFloat(1);
                        cd.c_i = reader.GetFloat(2);
                        cd.i_default = reader.GetFloat(3);
                        cd.a_v = reader.GetFloat(4);
                        cd.b_v = reader.GetFloat(5);
                        cd.c_v = reader.GetFloat(6);
                        cd.e_speed = reader.GetFloat(7);
                        cd.r_speed = reader.GetFloat(8);
                        cd.a_action = reader.GetFloat(9);
                        cd.b_action = reader.GetFloat(10);
                        cd.c_action = reader.GetFloat(11);
                        cd.status = reader.GetBoolean(12);
                        cd.feed = reader.GetBoolean(13);
                        cd.exhaust = reader.GetBoolean(14);
                        cd.d_time = timestampToDateTime(reader.GetTimeStamp(15));
                        cd.factory_no = factory_no;
                        cd.furnace_no = furnace_no;
                        data.Add(cd);
                    }
                }
                reader.Close();
            }
            return data;        
        }
        #endregion
    }
}
