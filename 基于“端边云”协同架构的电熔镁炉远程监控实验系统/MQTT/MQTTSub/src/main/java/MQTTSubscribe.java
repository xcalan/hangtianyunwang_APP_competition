import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;

import org.eclipse.paho.client.mqttv3.IMqttDeliveryToken;
import org.eclipse.paho.client.mqttv3.MqttCallback;
import org.eclipse.paho.client.mqttv3.MqttClient;
import org.eclipse.paho.client.mqttv3.MqttConnectOptions;
import org.eclipse.paho.client.mqttv3.MqttException;
import org.eclipse.paho.client.mqttv3.MqttMessage;
import org.eclipse.paho.client.mqttv3.persist.MemoryPersistence;

import java.io.FileNotFoundException;
import java.io.InputStream;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.io.IOException;
import java.io.FileInputStream;

/**
 * Created by DELL on 2019/3/29.
 */
public class MQTTSubscribe {
    public static void main(String[] args) throws MqttException {
        String HOST = "tcp://2350300-0l3o.instance.paas.casicloud.com:34553";
        String TOPIC = "/10000056540202/FMFMonitoring";
        int qos = 1;
        String clientid = "8b61499b7b054c93a042bf9ddab51176";//8b61499b7b054c93a042bf9ddab51177
        String userName = "neusapi";
        String passWord = "Sapi123456789";
        try {
            // host为主机名，test为clientid即连接MQTT的客户端ID，一般以客户端唯一标识符表示，MemoryPersistence设置clientid的保存形式，默认为以内存保存
            MqttClient client = new MqttClient(HOST, clientid, new MemoryPersistence());
            // MQTT的连接设置
            MqttConnectOptions options = new MqttConnectOptions();
            // 设置是否清空session,这里如果设置为false表示服务器会保留客户端的连接记录，这里设置为true表示每次连接到服务器都以新的身份连接
            options.setCleanSession(true);
            // 设置连接的用户名
            options.setUserName(userName);
            // 设置连接的密码
            options.setPassword(passWord.toCharArray());
            // 设置超时时间 单位为秒
            options.setConnectionTimeout(10);
            // 设置会话心跳时间 单位为秒 服务器会每隔1.5*20秒的时间向客户端发送个消息判断客户端是否在线，但这个方法并没有重连的机制
            options.setKeepAliveInterval(20);
            // 设置回调函数
            client.setCallback(new MqttCallback() {

                public void connectionLost(Throwable cause) {
                    System.out.println("connectionLost");
                }

                public void messageArrived(String topic, MqttMessage message) throws Exception {
        	        
                    System.out.println("topic:"+topic);
                    System.out.println("Qos:"+message.getQos());
                    System.out.println("message content:"+new String(message.getPayload()));
                    System.out.println("sub  sucess!!!");
                    
                    
                    //先连接后插入数据库
                    String insertSql = "insert into data_test(Id,CurrentA,CurrentB,CurrentC,ActionA,ActionB,ActionC,ECPT,current_focast_set,current_pi_feedforward,current_selfOptimize,current_self_control,current_optimize_set) values (?,?,?,?,?,?,?,?,?,?,?,?,?)";
        	        Object[] param = source_split(new String(message.getPayload()));//???????new String(message.getPayload())输出是字符串吗？
        	        for(int i=0;i<param.length;i++){
        		    	System.out.println(param[i]);
        		    }
        	        String driveName = "com.mysql.cj.jdbc.Driver";
        	        String url = "jdbc:mysql://106.74.18.237:34686/qvilj5zsw2?serverTimezone=GMT";
        	        String user = "sa";
        	        String pass = "Neusapi123456789";
        	        Connection conn = getConnection(driveName,url, user, pass);
        	        executUpdate(conn,insertSql,param);
                    
                }

                public void deliveryComplete(IMqttDeliveryToken token) {
                    System.out.println("deliveryComplete---------"+ token.isComplete());
                }

            });
            client.connect(options);
            //订阅消息
            client.subscribe(TOPIC, qos);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    
	public static Object[] source_split(String getted_string) {
		Object[] source={};
		source = getted_string.split(" ",13);
		return source;
	}
    public static Connection getConnection(String driver,String url,String username,String password) {
        Connection conn = null;
        try {
            Class.forName(driver);
            conn = DriverManager.getConnection(url, username, password);
            System.out.println("Connection  sucess!!!");
        } catch (Exception e) {
            e.printStackTrace();
        }
        return conn;
    }
    public static int executUpdate(Connection conn,String sql, Object[] param) {
        int result = 0;
        PreparedStatement pstmt = null;
        try {
            pstmt = conn.prepareStatement(sql);
            if (param != null) {
                for (int i = 0; i < param.length; i++) {
                    pstmt.setObject(i + 1, param[i]);
                }
            }
            result = pstmt.executeUpdate();
            System.out.println("Insert  sucess!!!");
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            //closeAll(conn, pstmt, null);
        }
        return result;
    }
}
