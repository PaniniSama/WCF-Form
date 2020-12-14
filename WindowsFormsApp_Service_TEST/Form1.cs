using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Service_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btplus_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int returnInt;
            returnInt = client.WebAdd(Convert.ToInt32(Txtx.Text), Convert.ToInt32(Txty.Text));
            Txtz.Text = Convert.ToString(returnInt);
        }

        private void Btmult_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int returnInt;
            returnInt = client.WebMultiply(Convert.ToInt32(Txtx.Text), Convert.ToInt32(Txty.Text));
            Txtz.Text = Convert.ToString(returnInt);
        }

        private void Btsous_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int returnInt;
            returnInt = client.WebSoustraction(Convert.ToInt32(Txtx.Text), Convert.ToInt32(Txty.Text));
            Txtz.Text = Convert.ToString(returnInt);
        }

        private void Btdiv_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int returnInt;
            returnInt = client.WebDivision(Convert.ToInt32(Txtx.Text), Convert.ToInt32(Txty.Text));
            Txtz.Text = Convert.ToString(returnInt);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
