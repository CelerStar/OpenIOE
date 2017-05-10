using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace channel
{
   

    public partial class Form1 : Form
    {
        public Socket newclient;//创建一个TCP连接对象
        public Thread myThread;//创建一个线程 供TCP接收使用
        public delegate void MyInvoke(string str);//委托 在线程中操作界面元素使用


        
        public Form1()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//禁止程序线程安全监听 否则线程中无法操作页面对象
            InitializeComponent();
        }


        /// <summary>
        /// 建立连接方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnectOpenIOE_Click(object sender, EventArgs e)
        {
            newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个TCP连接
            string ipadd = textBoxServerIP.Text.Trim();//获取TCP地址
            int port = Convert.ToInt32(textBoxServerPort.Text.Trim());//获取端口
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipadd), port);//指定IP 与 端口
            try//尝试创建连接
            {
                newclient.Connect(ie);

                buttonConnectOpenIOE.Enabled = false;//使连接按钮处于不可用状态
                buttonExiOpenIOE.Enabled = true;//使断开连接按钮处于可用状态

                ThreadStart myThreaddelegate = new ThreadStart(ReceiveMsg);//监听线程
                myThread = new Thread(myThreaddelegate);//创建TCP监听线程
                myThread.Start();//启动线程
            }
            catch (SocketException ee)
            {
                MessageBox.Show("连接服务器失败  " + ee.Message);//连接失败提示
                return;
            }


        }


        /// <summary>
        /// 关闭连接方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExiOpenIOE_Click(object sender, EventArgs e)
        {
            buttonConnectOpenIOE.Enabled = true;
            buttonExiOpenIOE.Enabled = false;
            myThread.Abort();
        }


        /// <summary>
        /// 接收事件
        /// </summary>
        public void ReceiveMsg()
        {
            while (true)
            {
                byte[] data = new byte[1024];//创建接收缓冲区
                int recv = newclient.Receive(data);//接收数据
                if (recv == 0)//判断是否有数据
                {
                    buttonConnectOpenIOE.Enabled = true; //使连接按钮处于可用状态
                    myThread.Abort();//销毁线程
                }
                else
                {
                    string stringdata = Encoding.UTF8.GetString(data, 0, recv);//解析接收的数据
                    showMsg(stringdata);
                }

              
            }
        }


        /// <summary>
        /// 接收打印
        /// </summary>
        /// <param name="msg"></param>
        public void showMsg(string msg)
        {
            {
                if (textBoxReceiveMsg.InvokeRequired)
                {
                    MyInvoke _myinvoke = new MyInvoke(showMsg);
                    textBoxReceiveMsg.Invoke(_myinvoke, new object[] { msg });
                }
                else
                {
                    textBoxReceiveMsg.AppendText(msg);//向接收窗体添加接收的数据
                }
            }
        }

        /// <summary>
        /// 集束通道登陆按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginString = "{\"LINK\":\"y2c\",\"ISTR\":\"log\",\"YID\":\"" + textBoxChannelIotPID.Text +"\",\"PWD\":\"" + textBoxChannelIotPWD.Text+ "\"}";//创建登陆字符串
            int m_length = loginString.Length;
            byte[] data = new byte[m_length];
            data = Encoding.UTF8.GetBytes(loginString);
            int i = newclient.Send(data);
        }

        /// <summary>
        /// 集束通道退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExi_Click(object sender, EventArgs e)
        {
            string exiString = "{\"LINK\":\"y2c\",\"ISTR\":\"exi\"}";//创建退出字符串
            int m_length = exiString.Length;
            byte[] data = new byte[m_length];
            data = Encoding.UTF8.GetBytes(exiString);
            int i = newclient.Send(data);
        }

        /// <summary>
        /// 发送数据按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonY2M_Click(object sender, EventArgs e)
        {
            string loginString = "{\"LINK\":\"y2m\",\"ISTR\":\"tm\",\"MID\":\"" + textBoxMid.Text + "\",\"MSG\":\"" + textBoxMsg.Text + "\"}";
            int m_length = loginString.Length;
            byte[] data = new byte[m_length];
            data = Encoding.UTF8.GetBytes(loginString);
            int i = newclient.Send(data);
        }


        /// <summary>
        /// 清空接收区按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClsRec_Click(object sender, EventArgs e)
        {
            textBoxReceiveMsg.Text = "";
        }



        /// <summary>
        /// LOGO 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.openioe.net/");
        }


        //LOGO点击事件
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.celerstar.com/");
        }
    }
}
