���ڡ��˱��ơ�Эͬ�ܹ��ĵ���þ¯Զ�̼��ʵ��ϵͳʹ�÷�������������

һ��MQTT��Զ�̿ͻ��˲���ʹ�÷�������������

1. Jar������
1) ������Jar��ǰ����Ҫ��װJDK(1.7������)�����û�������
2) ������ڣ����ٵ�Jar����Ӧ���ļ���·�������� java -jar ����.jar�س�֮��Jar���������С�

2. ��ؿͻ��˲���
1) ������ؼ�����ͷ�������VPNͨ�������� 3. VPN������
2) ѡ��װ���е�.exe�ļ�˫����
3) ��������ѡ�񳵼�ź�¯�κţ�ѡ�����IP�Ͷ˿ں�
4) ��������ѡ��Ҫ��ص�������ɡ�

3. VPN����

�ڷ������ϣ�
1)
#��װpptp
sudo apt-get install pptpd 
2) 
vi /etc/pptpd.conf 
#ȡ���������е�ע�ͣ�
localip 192.168.0.1
remoteip 192.168.0.100-110,192.168.0.245 
3)
sudo vi /etc/ppp/pptpd-options
#ȡ���������е�ע��
ms-dns 8.8.8.8
ms-dns 8.8.4.4 
4)
#ע���˺ţ�
vi  /etc/ppp/chap-secrets��
user pptpd userpasswd *
5)
vi /etc/sysctl.conf
#ȥ����һ�� #net.ipv4.ip_forward=1 ��#��
#Ȼ���������
sudo sysctl -p
#���к����ʾ net.ipv4.ip_forward = 1���ͱ�ʾ�޸���Ч�ˡ�
6)
sudo apt-get install iptables
iptables -t nat -A POSTROUTING -s 192.168.0.0/24 -o eth1 -j MASQUERADE
#���ڰ�����ecs��������һ����eth1��
#Ϊ��ֹ������������iptables��ʧ�������У�
iptables-save > /etc/iptables-rules
vi  /etc/network/interfaces��
#��eth0/eth1.. �������
pre-up iptables-restore < /etc/iptables-rules 
7)
#����pptpd��
sudo /etc/init.d/pptpd restart

�ڿͻ����ϣ�
1) ����������½ǿ�ʼ��ť���ҵ��������
2) �ҵ������Internet
3) �ҵ�����͹�������
4) �ҵ������µ����ӻ�����
5) ������ӵ��������������һ��
6) ���ʹ���ҵ�Internet���ӣ�VPN����i)
7) ����Internet��ַ�������һ��
8) �����û���������������
9) ��ʱ����������½ǵ�����������Ͷ���һ��VPN���ӣ����Ӽ��ɡ�


��������þ¯Զ�̼�����ʹ�÷�������������
1. ��װMyEclipse���������Tomcat(8.0�����ϰ汾)����������MyEclipse����File�˵��µ�Importѡ��MyEclipse�Ĺ����ռ䣬���next��֮����Browseѡ��Ҫ�����war�������Finish��ɵ��롣
2. ��servers�����Ҽ�Ҫ���е�Tomcat�����������Add Deployments�����뵽Add and Remove���ڣ�ѡ��Ҫ�����war�������Add���ٵ��Finish��ɲ���
3. ��servers�����Ҽ�Ҫ���еķ����������Start�������������и÷�������
4. ������ɺ󼴿�ͨ�����������Զ�̼��ϵͳ��ҳ�档Ĭ����ַΪ��http://localhost:8080/fur_project_yunwang�� ͨ��Զ���ն˷���ʱ�轫localhost��Ϊ����tomcat��������PC�˵�IP��ַ��
5. ��ҳ��ĵ�¼����ֱ�Ϊ������Ա�Ͳ�����Ա���ò�ͬ���˺����롣������Ա��¼�û���Ϊresearcher��Ĭ������Ϊ123456��������Ա��¼�û���Ϊoperator,Ĭ������Ϊ123456��







