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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private LoginImp service = new LoginImp();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewpass.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show(" Mật Khẩu Không Để Trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //

                else
                {
                    tblNguoidung user = new tblNguoidung();
                    user.Username = txtUsername.Text;
                    user.Pass = txtPass.Text;
                    //kiem tra xem id,pass dung ko
                    if (service.CheckLogin(user))
                    {
                        //thay doi mk
                        user.Pass = txtNewpass.Text;
                        service.ChangePass(user);
                        MessageBox.Show("Thay Mật Khẩu Thành Công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ChangePass_Load(object sender, EventArgs e)
        {
            try
            {

                service.GetAllUserName(txtUsername);
                 service.GetAllAccount(dataGridView1);
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
