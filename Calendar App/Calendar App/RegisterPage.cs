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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\dbPlanner.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO mainTable (firstName) Values ('" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO mainTable (lastName) Values ('" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO mainTable (userName) Values ('" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO mainTable (passWord) Values ('" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";

            MessageBox.Show("Profile Created Succesfully !!!");
            LoginPage openForm = new LoginPage();
            openForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            opbl.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All files (*.*)|*.*";

            DialogResult res = opbl.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbpic.Image = Image.FromFile(opbl.FileName);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boarder1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbpic_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boarder1_Load_1(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
=======
=======
>>>>>>> 24b494648210f402ddb02e39d42d9025304286d9
>>>>>>> 4a71b1b125c60003b8da026838c53e92f475a475
    }
}
