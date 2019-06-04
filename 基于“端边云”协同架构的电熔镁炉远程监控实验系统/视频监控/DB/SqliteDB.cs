using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Data.SQLite;

using Monitor.Models;

namespace Monitor.DB {
    public class SqliteDB {
        SQLiteConnection conn = null;

        #region Database Methods
        public SqliteDB() {
            //
        }
        public SqliteDB(string dbPath) {
            conn = new SQLiteConnection("Data Source=" + dbPath);
        }

        public void open() {
            if (conn.State == ConnectionState.Closed) {
                conn.Open();
            }
        }

        public void connect(string dbPath) {
            if (conn.State == ConnectionState.Closed) {
                conn = new SQLiteConnection("Data Source=" + dbPath);
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
        public void initCameraDatabase() {
            using (SQLiteCommand cmd = new SQLiteCommand(Camera.sql, conn)) {
                cmd.ExecuteNonQuery();
            }
        }

        public void addCamera(Camera camera) {
            addCamera(camera.ip, camera.port, camera.title, camera.factoryNo, camera.furnaceNo);
        }

        public void addCamera(IPAddress ip, int port, string title, int factory, int furnace) {
            string sql = "insert into Camera(ip, port, title, factory_no, furnace_no) values (@ip, @port, @title, @factory, @furnace)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@ip", ip);
                cmd.Parameters.AddWithValue("@port", port);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@factory", factory);
                cmd.Parameters.AddWithValue("@furnace", furnace);

                cmd.ExecuteNonQuery();
            }
        }


        public void deleteCamera(Camera camera) {
            deleteCamera(camera.ip, camera.port);
        }

        public void deleteCamera(IPAddress ip, int port) {
            string sql = "delete from camera where ip=@ip and port=@port;";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@ip", ip);
                cmd.Parameters.AddWithValue("@port", port);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Camera> getCameras() {
            string sql = "select ip,port,title,factory_no,furnace_no from camera";
            List<Camera> cameras = new List<Camera>();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn)) {
                SQLiteDataReader reader = cmd.ExecuteReader();
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
        #endregion
    }
}
