基于“端边云”协同架构的电熔镁炉远程监控实验系统使用方法及操作步骤

一、MQTT及远程客户端部署使用方法及操作步骤

1. Jar包部署
1) 在启动Jar包前，需要安装JDK(1.7及以上)并配置环境变量
2) 打开命令窗口，跟踪到Jar包对应的文件夹路径，输入 java -jar 名称.jar回车之后，Jar包即可运行。

2. 监控客户端部署
1) 建立监控计算机和服务器的VPN通道（见下 3. VPN建立）
2) 选择安装包中的.exe文件双击打开
3) 添加相机，选择车间号和炉次号，选择相机IP和端口号
4) 添加相机后，选择要监控的相机即可。

3. VPN建立

在服务器上：
1)
#安装pptp
sudo apt-get install pptpd 
2) 
vi /etc/pptpd.conf 
#取消下面两行的注释：
localip 192.168.0.1
remoteip 192.168.0.100-110,192.168.0.245 
3)
sudo vi /etc/ppp/pptpd-options
#取消下面两行的注释
ms-dns 8.8.8.8
ms-dns 8.8.4.4 
4)
#注册账号：
vi  /etc/ppp/chap-secrets：
user pptpd userpasswd *
5)
vi /etc/sysctl.conf
#去掉这一行 #net.ipv4.ip_forward=1 的#号
#然后运行命令：
sudo sysctl -p
#运行后会显示 net.ipv4.ip_forward = 1，就表示修改生效了。
6)
sudo apt-get install iptables
iptables -t nat -A POSTROUTING -s 192.168.0.0/24 -o eth1 -j MASQUERADE
#对于阿里云ecs外网网卡一般是eth1。
#为防止重启服务器后iptables丢失，先运行：
iptables-save > /etc/iptables-rules
vi  /etc/network/interfaces：
#在eth0/eth1.. 下面加入
pre-up iptables-restore < /etc/iptables-rules 
7)
#重启pptpd：
sudo /etc/init.d/pptpd restart

在客户端上：
1) 点击电脑左下角开始按钮，找到控制面板
2) 找到网络和Internet
3) 找到网络和共享中心
4) 找到设置新的连接或网络
5) 点击连接到工作区，点击下一步
6) 点击使用我的Internet连接（VPN）（i)
7) 输入Internet地址，点击下一步
8) 输入用户名，密码点击连接
9) 这时点击电脑右下角的网络连接里就多了一个VPN连接，连接即可。


二、电熔镁炉远程监控软件使用方法及操作步骤
1. 安装MyEclipse软件并配置Tomcat(8.0及以上版本)服务器，打开MyEclipse后点击File菜单下的Import选择MyEclipse的工作空间，点击next，之后点击Browse选择要导入的war包，点击Finish完成导入。
2. 在servers窗口右键要运行的Tomcat服务器，点击Add Deployments，进入到Add and Remove窗口，选中要部署的war包，点击Add，再点击Finish完成部署。
3. 在servers窗口右键要运行的服务器，点击Start，即可启动运行该服务器。
4. 运行完成后即可通过浏览器访问远程监控系统主页面。默认网址为：http://localhost:8080/fur_project_yunwang， 通过远程终端访问时需将localhost改为运行tomcat服务器的PC端的IP地址。
5. 主页面的登录界面分别为科研人员和操作人员设置不同的账号密码。科研人员登录用户名为researcher，默认密码为123456。操作人员登录用户名为operator,默认密码为123456。







