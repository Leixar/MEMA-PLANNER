using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_App
{
    public partial class Dashbord : UserControl
    {
        public Dashbord()
        {
            InitializeComponent();
            button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage openForm = new LoginPage();
            openForm.Show();
            Hide();
            ParentForm.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opbl.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All files (*.*)|*.*";

            DialogResult res = opbl.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbpic.Image = Image.FromFile(opbl.FileName);

            }
            button5.Visible = false;
        }

        private void pbpic_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
