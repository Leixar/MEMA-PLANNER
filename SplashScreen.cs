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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void LogoAppear_Tick(object sender, EventArgs e)
        {
            Logo.Width += 3;

            if (Logo.Width >= 300)
            {
                LogoAppear.Enabled = false;
                StartPage openForm = new StartPage();
                openForm.Show();
                Hide();
            }
        }
    }
}
