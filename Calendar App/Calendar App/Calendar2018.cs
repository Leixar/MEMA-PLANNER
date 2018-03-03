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
    public partial class Calendar2018 : Form
    {
        public Calendar2018()
        {
            InitializeComponent();
        }

        private void Calendar2018_Load(object sender, EventArgs e)
        {
            EventPanel.Visible = false;
        }

        Point lastPoint;

        private void topborder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void topborder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashbord_Click(object sender, EventArgs e)
        {
            dashbordgrow.Enabled = true;
            January.Enabled = false;
            February.Enabled = false;
            March.Enabled = false;
            April.Enabled = false;
            May.Enabled = false;
            June.Enabled = false;
            July.Enabled = false;
            August.Enabled = false;
            September.Enabled = false;
            October.Enabled = false;
            November.Enabled = false;
            December.Enabled = false;
            heading1.Enabled = false;
            heading2.Enabled = false;
            heading3.Enabled = false;
            heading4.Enabled = false;
            heading5.Enabled = false;
            heading6.Enabled = false;
            heading7.Enabled = false;
            heading8.Enabled = false;
            heading9.Enabled = false;
            heading10.Enabled = false;
            heading11.Enabled = false;
            heading12.Enabled = false;
        }

        private void Calendar2018_Click(object sender, EventArgs e)
        {
            dashbordshrink.Enabled = true;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            JanuaryShrink.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            JanuaryGrow.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FebruaryShrink.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FebruaryGrow.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MarchShrink.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MarchGrow.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AprilShrink.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AprilGrow.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MayShrink.Enabled = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MayGrow.Enabled = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            JuneShrink.Enabled = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            JuneGrow.Enabled = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            JulyShrink.Enabled = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            JulyGrow.Enabled = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            AugustShrink.Enabled = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            AugustGrow.Enabled = true;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            SeptemberShrink.Enabled = true;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            SeptemberGrow.Enabled = true;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            OctoberShrink.Enabled = true;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            OctoberGrow.Enabled = true;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            NovemberShrink.Enabled = true;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            NovemberGrow.Enabled = true;
        }

        private void mon1_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 486;
            February.Width = 486;
            March.Width = 486;
            April.Width = 486;
            May.Width = 486;
            June.Width = 486;
            July.Width = 486;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon2_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 486;
            March.Width = 486;
            April.Width = 486;
            May.Width = 486;
            June.Width = 486;
            July.Width = 486;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon3_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 486;
            April.Width = 486;
            May.Width = 486;
            June.Width = 486;
            July.Width = 486;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon4_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 486;
            May.Width = 486;
            June.Width = 486;
            July.Width = 486;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon5_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 486;
            June.Width = 486;
            July.Width = 486;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon6_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 0;
            June.Width = 486;
            July.Width = 486;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon7_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 0;
            June.Width = 0;
            July.Width = 486;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon8_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 0;
            June.Width = 0;
            July.Width = 0;
            August.Width = 486;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon9_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 0;
            June.Width = 0;
            July.Width = 0;
            August.Width = 0;
            September.Width = 486;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon10_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 0;
            June.Width = 0;
            July.Width = 0;
            August.Width = 0;
            September.Width = 0;
            October.Width = 486;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon11_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 0;
            June.Width = 0;
            July.Width = 0;
            August.Width = 0;
            September.Width = 0;
            October.Width = 0;
            November.Width = 486;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void mon12_Click(object sender, EventArgs e)
        {
            Monsecshrink.Enabled = true;
            January.Width = 0;
            February.Width = 0;
            March.Width = 0;
            April.Width = 0;
            May.Width = 0;
            June.Width = 0;
            July.Width = 0;
            August.Width = 0;
            September.Width = 0;
            October.Width = 0;
            November.Width = 0;
            December.Width = 486;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
            Dashbord.Enabled = true;
        }

        private void ShowMonSec_Click(object sender, EventArgs e)
        {
            Monsecgrow.Enabled = true;
            Dashbord.Enabled = false;
            January.Enabled = false;
            February.Enabled = false;
            March.Enabled = false;
            April.Enabled = false;
            May.Enabled = false;
            June.Enabled = false;
            July.Enabled = false;
            August.Enabled = false;
            September.Enabled = false;
            October.Enabled = false;
            November.Enabled = false;
            December.Enabled = false;
            heading1.Enabled = false;
            heading2.Enabled = false;
            heading3.Enabled = false;
            heading4.Enabled = false;
            heading5.Enabled = false;
            heading6.Enabled = false;
            heading7.Enabled = false;
            heading8.Enabled = false;
            heading9.Enabled = false;
            heading10.Enabled = false;
            heading11.Enabled = false;
            heading12.Enabled = false;
        }

        private void EventPage_Click(object sender, EventArgs e)
        {
            EventPanel.Visible = true;
            Dashbord.Enabled = false;
            January.Enabled = false;
            February.Enabled = false;
            March.Enabled = false;
            April.Enabled = false;
            May.Enabled = false;
            June.Enabled = false;
            July.Enabled = false;
            August.Enabled = false;
            September.Enabled = false;
            October.Enabled = false;
            November.Enabled = false;
            December.Enabled = false;
            heading1.Enabled = false;
            heading2.Enabled = false;
            heading3.Enabled = false;
            heading4.Enabled = false;
            heading5.Enabled = false;
            heading6.Enabled = false;
            heading7.Enabled = false;
            heading8.Enabled = false;
            heading9.Enabled = false;
            heading10.Enabled = false;
            heading11.Enabled = false;
            heading12.Enabled = false;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            EventPanel.Visible = false;
            Dashbord.Enabled = true;
            January.Enabled = true;
            February.Enabled = true;
            March.Enabled = true;
            April.Enabled = true;
            May.Enabled = true;
            June.Enabled = true;
            July.Enabled = true;
            August.Enabled = true;
            September.Enabled = true;
            October.Enabled = true;
            November.Enabled = true;
            December.Enabled = true;
            heading1.Enabled = true;
            heading2.Enabled = true;
            heading3.Enabled = true;
            heading4.Enabled = true;
            heading5.Enabled = true;
            heading6.Enabled = true;
            heading7.Enabled = true;
            heading8.Enabled = true;
            heading9.Enabled = true;
            heading10.Enabled = true;
            heading11.Enabled = true;
            heading12.Enabled = true;
        }

        private void dashbordgrow_Tick(object sender, EventArgs e)
        {
            if (dashbord1.Width >= 207)
            {
                dashbordgrow.Enabled = false;
            }
            else
            {
                dashbord1.Width += 23;
            }
        }

        private void dashbordshrink_Tick(object sender, EventArgs e)
        {
            if (dashbord1.Width <= 0)
            {
                dashbordshrink.Enabled = false;
            }
            else
            {
                dashbord1.Width -= 23;
            }
        }

        private void Monsecgrow_Tick(object sender, EventArgs e)
        {
            if (Monsec.Height >= 308)
            {
                Monsecgrow.Enabled = false;
            }
            else
            {
                Monsec.Height += 28;
            }
        }

        private void Monsecshrink_Tick(object sender, EventArgs e)
        {
            if (Monsec.Height <= 0)
            {
                Monsecshrink.Enabled = false;
            }
            else
            {
                Monsec.Height -= 28;
            }
        }

        private void JanuaryGrow_Tick(object sender, EventArgs e)
        {
            if (January.Width >= 486)
            {
                JanuaryGrow.Enabled = false;
            }
            else
            {
                January.Width += 27;
            }
        }

        private void JanuaryShrink_Tick(object sender, EventArgs e)
        {
            if (January.Width <= 0)
            {
                JanuaryShrink.Enabled = false;
            }
            else
            {
                January.Width -= 27;
            }
        }

        private void FebruaryGrow_Tick(object sender, EventArgs e)
        {
            if (February.Width >= 486)
            {
                FebruaryGrow.Enabled = false;
            }
            else
            {
                February.Width += 27;
            }
        }

        private void FebruaryShrink_Tick(object sender, EventArgs e)
        {
            if (February.Width <= 0)
            {
                FebruaryShrink.Enabled = false;
            }
            else
            {
                February.Width -= 27;
            }
        }

        private void MarchGrow_Tick(object sender, EventArgs e)
        {
            if (March.Width >= 486)
            {
                MarchGrow.Enabled = false;
            }
            else
            {
                March.Width += 27;
            }
        }

        private void MarchShrink_Tick(object sender, EventArgs e)
        {
            if (March.Width <= 0)
            {
                MarchShrink.Enabled = false;
            }
            else
            {
                March.Width -= 27;
            }
        }

        private void AprilGrow_Tick(object sender, EventArgs e)
        {
            if (April.Width >= 486)
            {
                AprilGrow.Enabled = false;
            }
            else
            {
                April.Width += 27;
            }
        }

        private void AprilShrink_Tick(object sender, EventArgs e)
        {
            if (April.Width <= 0)
            {
                AprilShrink.Enabled = false;
            }
            else
            {
                April.Width -= 27;
            }
        }

        private void MayGrow_Tick(object sender, EventArgs e)
        {
            if (May.Width >= 486)
            {
                MayGrow.Enabled = false;
            }
            else
            {
                May.Width += 27;
            }
        }

        private void MayShrink_Tick(object sender, EventArgs e)
        {
            if (May.Width <= 0)
            {
               MayShrink.Enabled = false;
            }
            else
            {
                May.Width -= 27;
            }
        }

        private void JuneGrow_Tick(object sender, EventArgs e)
        {
            if (June.Width >= 486)
            {
                JuneGrow.Enabled = false;
            }
            else
            {
                June.Width += 27;
            }
        }

        private void JuneShrink_Tick(object sender, EventArgs e)
        {
            if (June.Width <= 0)
            {
                JuneShrink.Enabled = false;
            }
            else
            {
                June.Width -= 27;
            }
        }

        private void JulyGrow_Tick(object sender, EventArgs e)
        {
            if (July.Width >= 486)
            {
                JulyGrow.Enabled = false;
            }
            else
            {
                July.Width += 27;
            }
        }

        private void JulyShrink_Tick(object sender, EventArgs e)
        {
            if (July.Width <= 0)
            {
                JulyShrink.Enabled = false;
            }
            else
            {
                July.Width -= 27;
            }
        }

        private void AugustGrow_Tick(object sender, EventArgs e)
        {
            if (August.Width >= 486)
            {
                AugustGrow.Enabled = false;
            }
            else
            {
                August.Width += 27;
            }
        }

        private void AugustShrink_Tick(object sender, EventArgs e)
        {
            if (August.Width <= 0)
            {
                AugustShrink.Enabled = false;
            }
            else
            {
                August.Width -= 27;
            }
        }

        private void SeptemberGrow_Tick(object sender, EventArgs e)
        {
            if (September.Width >= 486)
            {
                SeptemberGrow.Enabled = false;
            }
            else
            {
                September.Width += 27;
            }
        }

        private void SeptemberShrink_Tick(object sender, EventArgs e)
        {
            if (September.Width <= 0)
            {
                SeptemberShrink.Enabled = false;
            }
            else
            {
                September.Width -= 27;
            }
        }

        private void OctoberGrow_Tick(object sender, EventArgs e)
        {
            if (October.Width >= 486)
            {
                OctoberGrow.Enabled = false;
            }
            else
            {
                October.Width += 27;
            }
        }

        private void OctoberShrink_Tick(object sender, EventArgs e)
        {
            if (October.Width <= 0)
            {
                OctoberShrink.Enabled = false;
            }
            else
            {
                October.Width -= 27;
            }
        }

        private void NovemberGrow_Tick(object sender, EventArgs e)
        {
            if (November.Width >= 486)
            {
                NovemberGrow.Enabled = false;
            }
            else
            {
                November.Width += 27;
            }
        }

        private void NovemberShrink_Tick(object sender, EventArgs e)
        {
            if (November.Width <= 0)
            {
                NovemberShrink.Enabled = false;
            }
            else
            {
                November.Width -= 27;
            }
        }
    }
}
