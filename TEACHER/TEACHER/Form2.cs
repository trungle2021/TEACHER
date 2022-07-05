using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEACHER
{
    public partial class Form2 : Form
    {
        private bool SystemIsCollapsed;
        private bool InfoIsCollapsed;
        private bool SearchIsCollapsed;
        public Form2()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void SystemBtnLeftPanel_Click(object sender, EventArgs e)
        {
            timerSystemDropDown.Start();
        }

        private void timerSystemDropDown_Tick(object sender, EventArgs e)
        {
            if (SystemIsCollapsed)
            {
                SystemDropDownPanel.Height += 10;
                if (SystemDropDownPanel.Size == SystemDropDownPanel.MaximumSize)
                {
                    timerSystemDropDown.Stop();
                    SystemIsCollapsed = false;
                }
            }
            else
            {
                SystemDropDownPanel.Height -= 10;
                if (SystemDropDownPanel.Size == SystemDropDownPanel.MinimumSize)
                {
                    timerSystemDropDown.Stop();
                    SystemIsCollapsed = true;
                }
            }
        }

        private void InfoBtnLeftPanel_Click(object sender, EventArgs e)
        {
            timerInfoDropDown.Start();
        }

        private void timerInfoDropDown_Tick(object sender, EventArgs e)
        {
            if (InfoIsCollapsed)
            {
                InfoDropDownPanel.Height += 10;
                if (InfoDropDownPanel.Size == InfoDropDownPanel.MaximumSize)
                {
                    timerInfoDropDown.Stop();
                    InfoIsCollapsed = false;
                }
            }
            else
            {
                InfoDropDownPanel.Height -= 10;
                if (InfoDropDownPanel.Size == InfoDropDownPanel.MinimumSize)
                {
                    timerInfoDropDown.Stop();
                    InfoIsCollapsed = true;
                }
            }
        }

        private void SearchBtnLeftPanel_Click(object sender, EventArgs e)
        {
            timerSearchDropDown.Start();
        }

        private void timerSearchDropDown_Tick(object sender, EventArgs e)
        {
            if (SearchIsCollapsed)
            {
                SearchDropDownPanel.Height += 10;
                if (SearchDropDownPanel.Size == SearchDropDownPanel.MaximumSize)
                {
                    timerSearchDropDown.Stop();
                    SearchIsCollapsed = false;
                }
            }
            else
            {
                SearchDropDownPanel.Height -= 10;
                if (SearchDropDownPanel.Size == SearchDropDownPanel.MinimumSize)
                {
                    timerSearchDropDown.Stop();
                    SearchIsCollapsed = true;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }


        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void tsChangpass_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass() {  TopLevel = false, TopMost = true }; ;
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(changePass);
            changePass.Show();

        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            NewAccount newaccount = new NewAccount() {  TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(newaccount);
            newaccount.Show();
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login() {TopLevel=false,TopMost=true};
            this.pContainer.Panel2.Controls.Clear() ;
            this.pContainer.Panel2.Controls.Add(login);
            login.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HopDong hopdong = new HopDong() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(hopdong);
            hopdong.Show();
        }
    }
}
