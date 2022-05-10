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
        private async void 连接行情ToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
			if (CTPMD == null)
			{
				CTPMD = new CustomMD();
			}
			
			CTPMD.broker ="8080";
			CTPMD.userName = "use";
			CTPMD.password = "password";
			CTPMD.CreateMDApi();

			if (CTPMD != null && CTPMD.IsLogin == false)
			{
				CTPMD.Init("ctp行情前置代码");
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

			CTPMD?.Subscribe("ag2206");

			List<string> instrIDs = new List<string>() { "ag2207","ag2208","CF207"};
			CTPMD?.Subscribe(instrIDs);

		}
    }
}
