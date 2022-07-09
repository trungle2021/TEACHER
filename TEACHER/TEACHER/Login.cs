using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEACHER.Model;
using TEACHER.Service;

namespace TEACHER
{
    public partial class Login : Form
    {

        //pass du lieu qua main form
        MainForm originalForm2;
        public Login(MainForm incomingForm2)
        {
            originalForm2 = incomingForm2;
            InitializeComponent();
        }
        private LoginImp service = new LoginImp();
   
        private void button1_Click(object sender, EventArgs e)
     
        {
            try
            {
                //Validate
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Tên Đăng Nhập Và Mật Khẩu Không Để Trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //

                else
                {
                    tblNguoidung user = new tblNguoidung();
                    user.Username = txtUsername.Text;
                    user.Pass = txtPassword.Text;
                    if (service.CheckLogin(user))
                    {
                        this.Hide();
                        //phân Quyền
                 
                        originalForm2.name = user.Username;
                        originalForm2.getName();
                    }
                    else
                    {
                        MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();
        }
    }
}
