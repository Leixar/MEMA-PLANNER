using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calendar_App
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /*SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\dbPlanner.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUsername
        {
            con.Open();
            String syntax = "SELECT Value from mainTable where userName = rey";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show("" + dr[0].ToString());
        }*/

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage openForm = new RegisterPage();
            openForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getData();
            String userName = "rey", passWord = "1296", uName, pWord;
            uName = textBox1.Text;
            pWord = textBox2.Text;

            if ((uName.Equals(userName)) && (pWord.Equals(passWord)))
            {
                Tutorial openForm = new Tutorial();
                openForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            
        }
    }
}
