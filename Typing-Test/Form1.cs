using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Test
{
    public partial class Form1 : Form
    {
        int tm, cnt;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Enabled = false;
        }

        //for stopping test
        private void btnStop_Click(object sender, EventArgs e)
        {
            txtInput.Enabled = false;
            timerCheck.Enabled = false;
        }

        //when input text will change
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            cnt = cnt + 1;
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time: " + tm + " sec remain";
            tm = tm - 1;
            if(tm<0)
            {
                txtInput.Enabled = false;
                timerCheck.Enabled = false;
                lblSpeed.Text = "Speed: " + cnt + " CPM"; //checking char/min
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerCheck.Enabled = true;
            txtInput.Enabled = true;
            txtInput.Focus();
            tm = 60;
            cnt = 0;
            txtInput.Text = "";
            lblSpeed.Text = "Speed";
            lblTime.Text = "Time";
        }
    }
}
