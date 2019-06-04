import java.io.IOException;

import jxl.read.biff.BiffException;

import org.eclipse.paho.client.mqttv3.MqttClient;
import org.eclipse.paho.client.mqttv3.MqttConnectOptions;
import org.eclipse.paho.client.mqttv3.MqttException;
import org.eclipse.paho.client.mqttv3.MqttMessage;
import org.eclipse.paho.client.mqttv3.persist.MemoryPersistence;

//import java.io.IOException;
//import jxl.read.biff.BiffException;
//import java.lang.InterruptedException;

/**
 * Created by DELL on 2019/3/29.
 */
public class MQTTPublish {
    public static void main(String[] args) throws MqttException, BiffException, IOException, InterruptedException {
        while(true){
        	Thread.sleep(1000);
	        String topic = "/10000056540202/FMFMonitoring";
	        String content = data_source();//"Test FMFMonitoring"
	        //String content ="Test FMFMonitoring";
	        System.out.println(content);
	        //String content ="Test FMFMonitoring";
	        int qos = 1;
	        String broker = "tcp://2350300-0l3o.instance.paas.casicloud.com:34553";
	        String userName = "neusapi";
	        String password = "Sapi123456789";
	        String clientId = "8b61499b7b054c93a042bf9ddab51177";//8b61499b7b054c93a042bf9ddab51177
	        // 内存存储
	        MemoryPersistence persistence = new MemoryPersistence();
	
	        //MQTTMySQL mqttMySQL = new  MQTTMySQL();
	        //mqttMySQL.Test();
	        //mqttMySQL.Test();
	
	        try {
	            // 创建客户端
	            MqttClient sampleClient = new MqttClient(broker, clientId, persistence);
	            System.out.println("1!!!!");
	            // 创建链接参数
	            MqttConnectOptions connOpts = new MqttConnectOptions();
	            System.out.println("2!!!!");
	            // 在重新启动和重新连接时记住状态
	            connOpts.setCleanSession(false);
	            System.out.println("3!!!!");
	            // 设置连接的用户名
	            connOpts.setUserName(userName);
	            connOpts.setPassword(password.toCharArray());
	            System.out.println("4!!!!");
	            // 建立连接
	            sampleClient.connect(connOpts);
	            System.out.println("5!!!!");
	            // 创建消息
	            MqttMessage message = new MqttMessage(content.getBytes());
	            System.out.println("6!!!!");
	            // 设置消息的服务质量
	            message.setQos(qos);
	            System.out.println("7!!!!");
	            // 发布消息
	            sampleClient.publish(topic, message);
	            System.out.println("pub  success!!!!");
	            // 断开连接
	            sampleClient.disconnect();
	            // 关闭客户端
	            sampleClient.close();
	        } catch (MqttException me) {
	            System.out.println("reason " + me.getReasonCode());
	            System.out.println("msg " + me.getMessage());
	            System.out.println("loc " + me.getLocalizedMessage());
	            System.out.println("cause " + me.getCause());
	            System.out.println("excep " + me);
	            me.printStackTrace();
	        }
        }
	}
    
    public static String data_source() {
		Object[] source = {"1","2","3","4","5","6","7","8","9","10","11","12","13"};
		int id = (int)(1+Math.random()*(10-1+1));
		float CurrentA = (float)(11500+Math.random()*(1000-1+1));
		float CurrentB = (float)(11500+Math.random()*(1000-1+1));
		float CurrentC = (float)(11500+Math.random()*(1000-1+1));
		float ActionA = (float)(-10+Math.random()*(20-1+1));
		float ActionB = (float)(-10+Math.random()*(20-1+1));
		float ActionC = (float)(-10+Math.random()*(20-1+1));
		double ECPT = (double)(2850+Math.random()*(80-1+1));
		
		double current_focast_set = 12157.6;//(int)(1+Math.random()*(10-1+1));
		int current_pi_feedforward = (int)(1+Math.random()*(100-1+1));
		if (current_pi_feedforward < 98){
			current_pi_feedforward = 0;
		}else{
			current_pi_feedforward = current_pi_feedforward - 200;
		}
		
		float current_selfOptimize = (float)(1+Math.random()*(500-1+1));
		if (current_selfOptimize < 497){
			current_selfOptimize = 0;
		}
		
		int current_self_control = (int)(1+Math.random()*(200-1+1));
		if (current_self_control < 198){
			current_pi_feedforward = 0;
		}
		
		double current_optimize_set = (float)(11500+Math.random()*(1000-1+1));;	
		source[0] = String.valueOf(id);
		source[1] = String.valueOf(CurrentA);
		source[2] = String.valueOf(CurrentB);
		source[3] = String.valueOf(CurrentC);
		source[4] = String.valueOf(ActionA);
		source[5] = String.valueOf(ActionB);
		source[6] = String.valueOf(ActionC);
		source[7] = String.valueOf(ECPT);
		source[8] = String.valueOf(current_focast_set);
		source[9] = String.valueOf(current_pi_feedforward);
		source[10] =String.valueOf(current_selfOptimize);
		source[11] = String.valueOf(current_self_control);
		source[12] = String.valueOf(current_optimize_set);
		
		String source_string = source[0]+" "+source[1]+" "+source[2]+" "+source[3]+" "+source[4]+" "+source[5]+" "+source[6]+" "+source[7]+" "+source[8]+" "+source[9]+" "+source[10]+" "+source[11]+" "+source[12];
		
		return source_string; 	
	}
}
