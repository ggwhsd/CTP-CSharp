using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPlusPlusClass pp = new CPlusPlusClass();
            richTextBox1.Text = DateTime.Now.ToLongTimeString()+" "+ (pp.Add(1, 2,null).ToString()) + "\n"; ;

        }
        class Child:CPlusPlusClass
        {
            public string showChild()
            {
                return ("child");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            richTextBox1.Text += DateTime.Now.ToLongTimeString() + " "+child.showChild() + "\n";
            richTextBox1.Text += DateTime.Now.ToLongTimeString() + " "+child.Add(1,3,null) + "\n";
        }

        class ChildMethod : Addmethod
        {
            public override int add(int i,int j)
            {
                return (i+j)*100;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Addmethod method = new ChildMethod();
            Child child = new Child();
            
            richTextBox1.Text += DateTime.Now.ToLongTimeString() + " " + child.Add(3, 3, method)+ "\n";
        }
    }
}
