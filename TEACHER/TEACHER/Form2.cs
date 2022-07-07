using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEACHER.Service;

namespace TEACHER
{
    public partial class Form2 : Form
    {
        private bool SystemIsCollapsed;
        private bool InfoIsCollapsed;
        private bool SearchIsCollapsed;
        public string name;
        private LoginImp service = new LoginImp();
        public Form2()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();

        }
        public Form2(string user)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            lblUserName.Text = user;
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



        //getname phan quyen
        internal void getName()
        {
            lblUserName.Text = name;
            if (string.IsNullOrEmpty(lblUserName.Text))
            {
                MessageBox.Show("Xảy Ra Lỗi Khi Truyền Dữ Liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    var user = service.GetUser(name);
                    tsLogin.Enabled = false;
                    if (user.Chophepthaotac.Equals("Admin"))
                    {
                        tsNhanVien.Enabled = true;
                        tsChucVu.Enabled = true;
                        tsHopDong.Enabled = true;
                        tsThongtin1.Enabled = true;
                        tsThongtin2.Enabled = true;
                        tsThongtin3.Enabled = true;
                        tsThongtin4.Enabled = true;
                        tsSearch.Enabled = true;
                    }
                    else {
                        tsNhanVien.Enabled = true;
                        tsChucVu.Enabled = false;
                        tsHopDong.Enabled = false;
                        tsThongtin1.Enabled = false;
                        tsThongtin2.Enabled = false;
                        tsThongtin3.Enabled = false;
                        tsThongtin4.Enabled = false;
                        tsSearch.Enabled = true;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("xảy ra lỗi khi Liên Kết dữ Liệu!");
                }

            }

        }


        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsChangpass_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass() { TopLevel = false, TopMost = true }; ;
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(changePass);
            changePass.Show();

        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            NewAccount newaccount = new NewAccount() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(newaccount);
            newaccount.Show();
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this) { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
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

        private void pContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void tsSearch_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SearchForm searchform = new SearchForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(searchform);
            searchform.Show();
        }

        private void tsThongtin1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            HopDong hopdong = new HopDong() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(hopdong);
            hopdong.Show();
        }

        private void tsThongtin2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Donvi hopdong = new Donvi() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(hopdong);
            hopdong.Show();
        }

        private void tsThongtin3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            TeacherManagementForm.TeacherManageForm hopdong = new TeacherManagementForm.TeacherManageForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(hopdong);
            hopdong.Show();
        }
    }
}
