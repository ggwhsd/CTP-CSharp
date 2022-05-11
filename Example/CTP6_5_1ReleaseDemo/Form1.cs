using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTP6_5_1ReleaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
		CustomMD CTPMD = null;

		private void ShowMsg(string msg)
		{
			//将后台线程的数据显示到前台界面
			this.Invoke(new Action(()=> { textBox1.Text += $"{DateTime.Now.ToString("yyyy-MM-hh HH:mm:ss.fff")} {msg}\r\n"; }));
		}

        private async void 连接行情ToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
			if (CTPMD == null)
			{
				CTPMD = new CustomMD();
				CTPMD.logMessageCallBack += ShowMsg;
			}
			
			CTPMD.broker ="4900";
			CTPMD.userName = "use";
			CTPMD.password = "password";

		


			CTPMD.CreateMDApi();

			if (CTPMD != null && CTPMD.IsLogin == false)
			{
				CTPMD.Init("tcp://xxxxx:xxxxx");
			}
			else
			{

			}
			
			while (CTPMD.IsLogin == false) {
				await Task.Delay(1000);
				textBox1.Text += "行情登录中...\r\n";
			}
			textBox1.Text += "行情登录成功...\r\n";
		}

        private void 订阅行情ToolStripMenuItem_Click(object sender, EventArgs e)
        {

			CTPMD?.Subscribe("au2206");

			List<string> instrIDs = new List<string>() { "ag2207","ag2208","CF207"};
			CTPMD?.Subscribe(instrIDs);

		}
    }
}
