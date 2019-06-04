using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Models {
    public class CameraData {
        /* -- auto-generated definition
          CREATE TABLE camera_data (
            id         SERIAL  NOT NULL
            CONSTRAINT camera_key
            PRIMARY KEY,
            factory_no INTEGER NOT NULL,
            furnace_no INTEGER NOT NULL,
            a_i        REAL,
            b_i        REAL,
            c_i        REAL,
            i_default  REAL,
            a_v        REAL,
            b_v        REAL,
            c_v        REAL,
            e_speed    REAL,
            r_speed    REAL,
            a_action   REAL,
            b_action   REAL,
            c_action   REAL,
            status     BOOLEAN,
            feed       BOOLEAN,
            exhaust    BOOLEAN,
            d_time     TIMESTAMP
        );
        CREATE UNIQUE INDEX camera_id_uindex ON camera_data (id);

        COMMENT ON COLUMN camera_data.factory_no IS '厂房编号';
        COMMENT ON COLUMN camera_data.furnace_no IS '电熔镁炉编号';
        COMMENT ON COLUMN camera_data.a_i IS 'A相电流';
        COMMENT ON COLUMN camera_data.b_i IS 'B相电流';
        COMMENT ON COLUMN camera_data.c_i IS 'C相电流';
        COMMENT ON COLUMN camera_data.i_default IS '电流设定值';
        COMMENT ON COLUMN camera_data.a_v IS 'A相电压';
        COMMENT ON COLUMN camera_data.b_v IS 'B相电压';
        COMMENT ON COLUMN camera_data.c_v IS 'C相电压';
        COMMENT ON COLUMN camera_data.e_speed IS '手动电极速度';
        COMMENT ON COLUMN camera_data.r_speed IS '炉体转动速度';
        COMMENT ON COLUMN camera_data.a_action IS 'A动作';
        COMMENT ON COLUMN camera_data.b_action IS 'B动作';
        COMMENT ON COLUMN camera_data.c_action IS 'C动作';
        COMMENT ON COLUMN camera_data.status IS '手/自动状态';
        COMMENT ON COLUMN camera_data.feed IS '加料指示';
        COMMENT ON COLUMN camera_data.exhaust IS '排气指示';
        COMMENT ON COLUMN camera_data.d_time IS '数据采集时间';
         */
        public int factory_no;   // '厂房编号';
        public int furnace_no;   // '电熔镁炉编号';
        public float a_i;   // 'A相电流';
        public float b_i;   // 'B相电流';
        public float c_i;   // 'C相电流';
        public float i_default;   // '电流设定值';
        public float a_v;   // 'A相电压';
        public float b_v;   // 'B相电压';
        public float c_v;   // 'C相电压';
        public float e_speed;   // '手动电极速度';
        public float r_speed;   // '炉体转动速度';
        public float a_action;   // 'A动作';
        public float b_action;   // 'B动作';
        public float c_action;   // 'C动作';
        public bool status;     // '手/自动状态';
        public bool feed;       // '加料指示';
        public bool exhaust;   // '排气指示';
        public DateTime d_time;   // '数据采集时间';

        public override string ToString() {
            return string.Format("{0}-{1} ({3})", factory_no, furnace_no, d_time);
        }
    }
}
