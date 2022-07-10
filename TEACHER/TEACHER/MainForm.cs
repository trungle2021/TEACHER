using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEACHER.Service;
using TEACHER.TeacherManagementForm;

namespace TEACHER
{
    public partial class MainForm : Form
    {
        private bool SystemIsCollapsed;
        private bool InfoIsCollapsed;
        private bool SearchIsCollapsed;
        public string name;
        private LoginImp service = new LoginImp();
        public MainForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
         


        }
        public MainForm(string user)
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            lblUserName.Text = user;
        }
        private void SystemBtnLeftPanel_Click(object sender, EventArgs e)
        {
            if (SystemDropDownPanel.Size == SystemDropDownPanel.MinimumSize)
            {

            }
            timerSystemDropDown.Start();
      
                SystemBtnLeftPanel.BackColor = Color.Orange;

           

        }

        private void timerSystemDropDown_Tick(object sender, EventArgs e)
        {
            if (SystemIsCollapsed)
            {
                SystemBtnLeftPanel.BackColor = Color.Orange;
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
                    SystemBtnLeftPanel.BackColor = Color.Transparent;

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
                InfoBtnLeftPanel.BackColor = Color.Orange;

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
                    InfoBtnLeftPanel.BackColor = Color.Transparent;

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
                SearchBtnLeftPanel.BackColor = Color.Orange;

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
                    SearchBtnLeftPanel.BackColor = Color.Transparent;

                }
            }
        }



        //getname phan quyen
        internal void getName()
        {
            lblUserName.Text = "Xin chào " + name;
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
                        tsDonVi.Enabled = true;
                        thôngTinToolStripMenuItem.Enabled = true;
                        tìmKiếmToolStripMenuItem.Enabled = true;
                    }
                    else {
                        tsNhanVien.Enabled = false;
                        tsChucVu.Enabled = false;
                        tsHopDong.Enabled = false;
                        tsThongtin1.Enabled = false;
                        tsThongtin2.Enabled = false;
                        tsThongtin3.Enabled = false;
                        tsThongtin4.Enabled = false;
                        tsSearch.Enabled = true;
                        tsDonVi.Enabled = false;
                        tìmKiếmToolStripMenuItem.Enabled = true;
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

        
        private void tsSearch_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SearchForm searchform = new SearchForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(searchform);
            searchform.Show();
        }

        private void tsNhanVien_Click(object sender, EventArgs e)
        {
            TeacherManageForm teacher_manage_form = new TeacherManageForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(teacher_manage_form);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            teacher_manage_form.Show();
        }

        private void tsChucVu_Click(object sender, EventArgs e)
        {
            ChucVuForm chucVuForm = new ChucVuForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(chucVuForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            chucVuForm.Show();
        }

        

        private void tsDonVi_Click(object sender, EventArgs e)
        {
            Donvi donviForm = new Donvi() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(donviForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            donviForm.Show();
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
            ChucVuForm chucVuForm = new ChucVuForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(chucVuForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            chucVuForm.Show();
        }

        private void tsThongtin3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Donvi donviForm = new Donvi() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(donviForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            donviForm.Show();
        }

        private void tsThongtin4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            TeacherManageForm teacher_manage_form = new TeacherManageForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(teacher_manage_form);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            teacher_manage_form.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(searchform);
            searchform.Show();
        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HopDong hopdong = new HopDong() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(hopdong);
            hopdong.Show();
        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVuForm chucVuForm = new ChucVuForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(chucVuForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            chucVuForm.Show();
        }

        private void quảnLýĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donvi donviForm = new Donvi() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(donviForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            donviForm.Show();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherManageForm teacher_manage_form = new TeacherManageForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(teacher_manage_form);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            teacher_manage_form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login(this) { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(login);
            login.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsThongtin1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            HopDong hopdong = new HopDong() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(hopdong);
            hopdong.Show();
        }

        private void tsThongtin2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            ChucVuForm chucVuForm = new ChucVuForm() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(chucVuForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            chucVuForm.Show();
        }

        private void tsThongtin3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            Donvi donviForm = new Donvi() { TopLevel = false, TopMost = true };
            this.pContainer.Panel2.Controls.Clear();
            this.pContainer.Panel2.Controls.Add(donviForm);
            this.pContainer.Panel2.Size = new Size(0, 0);
            this.pContainer.Panel2.AutoSize = true;
            donviForm.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUserName.Text = "";
           
           
                try
                {
                    tsLogin.Enabled = Enabled;
                    Login login = new Login(this) { TopLevel = false, TopMost = true };
                    this.pContainer.Panel2.Controls.Clear();
                    this.pContainer.Panel2.Controls.Add(login);
                    login.Show();

                if (string.IsNullOrEmpty(lblUserName.Text))
                    {
                      
                        tsNhanVien.Enabled = false;
                        tsChucVu.Enabled = false;
                        tsHopDong.Enabled = false;
                        tsThongtin1.Enabled = false;
                        tsThongtin2.Enabled = false;
                        tsThongtin3.Enabled = false;
                        tsThongtin4.Enabled = false;
                        tsSearch.Enabled = true;
                        tsDonVi.Enabled = false;
                        tìmKiếmToolStripMenuItem.Enabled = true;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("xảy ra lỗi khi Liên Kết dữ Liệu!");
                }

            
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173),1);
            Rectangle area = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251),LinearGradientMode.Vertical);
            graphics.FillRectangle(lgb, area);
            graphics.DrawRectangle(pen, area);
        }
    }


}
