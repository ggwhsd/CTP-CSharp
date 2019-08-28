using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomTD tD = null;
        private void button1_Click(object sender, EventArgs e)
        {
            tD = new CustomTD();
            tD.broker = "4900";
            tD.userName = "300007761";
            tD.password = "dw123456";
            tD.CreateTDApi();
            tD.SetTDSpi();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tD != null)
                tD.Init("tcp://222.92.185.26:41205");
        }
    }
}
