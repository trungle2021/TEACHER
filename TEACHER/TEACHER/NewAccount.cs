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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        private LoginImp service = new LoginImp();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Tên Đăng Nhập Và Mật Khẩu Không Để Trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {

                    if (txtPass.Text != txtConfirmpass.Text) { MessageBox.Show("Mật Khẩu Xác Nhận Không Trùng Khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        tblNguoidung account = new tblNguoidung();
                        account.Username = txtUsername.Text;
                        account.Pass = txtPass.Text;
                        
                        service.newaccount(account);
                        MessageBox.Show("Thêm Tài Khoản Thành Công!", "Thành Công", MessageBoxButtons.OK);
                        service.GetAllAccount(dataGridView1);
                    }
                }
            }
            catch (Exception )
            {

                MessageBox.Show("Thêm Tài Khoản Không Thành Công!Hãy Đổi Tên Đăng nhập!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            service.GetAllAccount(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                 service.GetAllAccount(dataGridView1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
