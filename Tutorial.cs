using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_App
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            dashbord1.Visible = false;
            Monsec.Visible = false;
            dashbord1.Enabled = false;
            Monsec.Enabled = false;
            January.Enabled = false;
            Tutorial1.Visible = false;
            Tutorial2.Visible = false;
            Tutorial3.Visible = false;
            Tutorial4.Visible = false;
            Tutorial5.Visible = false;
            TutorialEnd.Visible = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TutorialStart.Visible = false;
            Tutorial1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendar2018 openForm = new Calendar2018();
            openForm.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tutorial1.Visible = false;
            Tutorial2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tutorial1.Visible = true;
            Tutorial2.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tutorial2.Visible = false;
            Tutorial3.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tutorial2.Visible = true;
            Tutorial3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tutorial3.Visible = false;
            Tutorial4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tutorial3.Visible = true;
            Tutorial4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Monsec.Visible = true;
            Tutorial4.Visible = false;
            Tutorial5.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Monsec.Visible = false;
            Tutorial4.Visible = true;
            Tutorial5.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Monsec.Visible = false;
            Tutorial5.Visible = false;
            TutorialEnd.Visible = true;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Calendar2018 openForm = new Calendar2018();
            openForm.Show();
            Close();
        }
    }
}
