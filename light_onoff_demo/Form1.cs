using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace light_onoff_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int lighton = 0;
        private void lightBtn_Click(object sender, EventArgs e)
        {
            
            if (lighton == 0) 
            {
                lighton = 1;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                onBtn.Visible = true;
                offBtn.Visible = false;
             }
            else
            {
                lighton = 0;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                offBtn.Visible = true;
                onBtn.Visible = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}