using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up_yay
{
    public partial class Form1 : Form
    {
        List<string> userData = new List<string>();
        string gender = "";
        string game = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                gender = "male";
                checkBox2.Checked = false;
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                gender = "female";
                checkBox1.Checked = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                game = "Tennis";
                checkBox3.Checked = false;
            }


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox3.Checked)
            {
                game = "Basketball";
                checkBox4.Checked = false;
            }

        }
    }
}
