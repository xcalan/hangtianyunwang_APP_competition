import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.InputStream;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.io.IOException;

import jxl.read.biff.BiffException;

import java.lang.InterruptedException;
import java.util.Timer;
import java.util.TimerTask;

import jxl.Cell;
import jxl.Sheet;
import jxl.Workbook;
import jxl.Cell;
import jxl.Sheet;
import jxl.Workbook;
import jxl.read.biff.BiffException;
/**
 * Created by DELL on 2019/3/29.
 */
public class MQTTMySQL {
    //test
    public void Test() throws BiffException, IOException, InterruptedException{
    	//int num = 0;
        while(true){
	        String driveName = "com.mysql.cj.jdbc.Driver";
			//String url = "jdbc:mysql://127.0.0.1:3306/test?serverTimezone=GMT";
	        //String user = "root";
	        //String pass = "123456";
	
	        //106.74.18.237:34686:3306
	        String url = "jdbc:mysql://106.74.18.237:34686/qvilj5zsw2?serverTimezone=GMT";
	        String user = "sa";
	        String pass = "Neusapi123456789";
	
	        /*徐老师原版
	        Connection conn = getConnection(driveName,url, user, pass);
	        String querySql = "select * from users";
	        ResultSet result = executQuery(conn,querySql,null);
	        try{
	            while(result.next()) {
	                System.out.println("学号：" + result.getInt("Id"));
	                System.out.println("姓名：" + result.getString("Name"));
	                System.out.println("密码：" + result.getInt("Password"));
	                System.out.println();
	            }
	
	        }catch (SQLException e) {
	            e.printStackTrace();
	        }
	
	        //insert
	        String insertSql = "insert into users(Id,Name,Password) values (?,?,?)";
	        Object[] param = {"7","liyang","123456"};
	        executUpdate(conn,insertSql,param);
	
	        */
	        
	        Connection conn = getConnection(driveName,url, user, pass);
	        /*
	        String querySql = "select * from data_test";
	        ResultSet result = executQuery(conn,querySql,null);
	        try{
	            while(result.next()) {
	                System.out.println("Id：" + result.getInt("Id"));
	                System.out.println("CurrentA：" + result.getString("CurrentA"));
	                System.out.println("CurrentB：" + result.getInt("CurrentB"));
	                System.out.println("CurrentC：" + result.getInt("CurrentC"));
	                System.out.println("ActionA：" + result.getInt("ActionA"));
	                System.out.println("ActionB：" + result.getInt("ActionB"));
	                System.out.println("ActionC：" + result.getInt("ActionC"));
	                System.out.println("ECPT：" + result.getInt("ECPT"));
	                System.out.println("current_focast_set：" + result.getInt("current_focast_set"));
	                System.out.println("current_pi_feedforward：" + result.getInt("current_pi_feedforward"));
	                System.out.println("current_selfOptimize：" + result.getInt("current_selfOptimize"));
	                System.out.println("current_self_control：" + result.getInt("current_self_control"));
	                System.out.println("current_optimize_set：" + result.getInt("current_optimize_set"));
	                System.out.println();
	            }
	
	        }catch (SQLException e) {
	            e.printStackTrace();
	        }
	        */
	        //insert
	        String insertSql = "insert into data_test(Id,CurrentA,CurrentB,CurrentC,ActionA,ActionB,ActionC,ECPT,current_focast_set,current_pi_feedforward,current_selfOptimize,current_self_control,current_optimize_set) values (?,?,?,?,?,?,?,?,?,?,?,?,?)";
	        Object[] param = {"1","2","3","4","5","6","7","8","9","10","11","12","13"};
	        param = data_source();
	        executUpdate(conn,insertSql,param);
	        Thread.sleep(5000);
	     //*************************************************************************从excel表读数
			//InputStream input = new FileInputStream("E:\\研二下临时\\MQTT（徐老师）\\fur_data_simulate.xls");
			//Workbook readxls = Workbook.getWorkbook(input);
			//Sheet readsheet = readxls.getSheet(0); 
			//int rsRows = readsheet.getRows();
			//int rsClomns = readsheet.getColumns();
			//for (int i = num; i < rsRows; i++)
			//	{
			//	Thread.sleep(5000);
			//	try {
					   
			//		    for (int j = 0; j < rsClomns; j++)
			//		    {   
			//		        Cell cell = readsheet.getCell(j, i);
			//		        String str = cell.getContents();
			//		        param[j] = Float.parseFloat(str);
			//		        System.out.println(param[j]);  
			//		   }
			//		    executUpdate(conn,insertSql,param);
			//	} catch (Exception e) {
			//		e.printStackTrace();
			//	}
			//	}
        //num++;
        //**************************************************************************
        //closeAll(conn,null,result);
        //Thread.sleep(50000);
        }
    }


    /**
     * 连接数据
     *
     * @return conn
     */
    public static Connection getConnection(String driver,String url,String username,String password) {
        Connection conn = null;
        try {
            Class.forName(driver);
            conn = DriverManager.getConnection(url, username, password);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return conn;
    }

    /**
     * 关闭连接对象
     *
     * @param conn
     *            连接对象
     * @param pstmt
     *            预编译对象
     * @param rs
     *            结果集
     */
    public static void closeAll(Connection conn, PreparedStatement pstmt, ResultSet rs) {
        try {
            if (rs != null) {
                rs.close();
            }
            if (pstmt != null) {
                pstmt.close();
            }
            if (conn != null) {
                conn.close();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /**
     * 增删改操作
     *
     * @param sql
     *            SQL命令
     * @param param
     *            参数
     * @return
     */
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
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            //closeAll(conn, pstmt, null);
        }
        return result;
    }
    /**
     * 查询
     *
     * @return int
     */
    public static ResultSet executQuery(Connection conn,String sql, String[] param) {
        PreparedStatement pstmt = null;
        ResultSet result = null;
        try {
            pstmt = conn.prepareStatement(sql);
            if (param != null) {
                for (int i = 0; i < param.length; i++) {
                    pstmt.setString(i + 1, param[i]);
                }
            }
            result = pstmt.executeQuery();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return result;
    }
    
    
    public static Object[] data_source() {//产生随机数据源
		Object[] source = {"1.0","2","3","4","5","6","7","8","9","10","11","12","13"};
		int id = 3;//(int)(1+Math.random()*(10-1+1));
		double CurrentA = (float)(11500+Math.random()*(1000-1+1));
		//System.out.println(CurrentA);
		double CurrentB = (float)(11500+Math.random()*(1000-1+1));
		double CurrentC = (float)(11500+Math.random()*(1000-1+1));
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
		source[0] = id;
		source[1] = CurrentA;
		source[2] = CurrentB;
		source[3] = CurrentC;
		source[4] = ActionA;
		source[5] = ActionB;
		source[6] = ActionC;
		source[7] = ECPT;
		source[8] = current_focast_set;
		source[9] = current_pi_feedforward;
		source[10] = current_selfOptimize;
		source[11] = current_self_control;
		source[12] = current_optimize_set;
		for(int i=0;i<source.length;i++){
	    	System.out.println(source[i]);
	    }
		
		return source; 	
	}
}
