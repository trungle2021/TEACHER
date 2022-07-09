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

namespace TEACHER
{
    public partial class Donvi : Form
    {
        public Donvi()
        {
            InitializeComponent();
        }

        Service.DonViServiceImp service = new Service.DonViServiceImp();
        private void Donvi_Load(object sender, EventArgs e)
        {
            showDV();
        }

        void showDV() {

            var data = service.GetAll();
         
            dataGridView1.DataSource = data;
            dataGridView1.Columns["MaDV"].Visible = false;
            dataGridView1.Columns["GhiChu"].Visible = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMaDV.Text) || string.IsNullOrEmpty(txtTenDV.Text) || string.IsNullOrEmpty(txtGhichu.Text))
                {
                    MessageBox.Show("Các Trường Dữ Liệu Không Được Để Trống", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDV.Focus();
                }
                else
                {
                    tblDSDonvi donvi = new tblDSDonvi();
                    donvi.MaDV = txtMaDV.Text;
                    donvi.TenDV = txtTenDV.Text;
                    donvi.Ghichu = txtGhichu.Text;
                    service.Add(donvi);
                    MessageBox.Show("Thêm Đơn Vị Thành Công!");
                    showDV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMaDV.Text) || string.IsNullOrEmpty(txtTenDV.Text) || string.IsNullOrEmpty(txtGhichu.Text))
                {
                    MessageBox.Show("Các Trường Dữ Liệu Không Được Để Trống", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDV.Focus();
                }
                else
                {
                    tblDSDonvi donvi = new tblDSDonvi();
                    donvi.MaDV = txtMaDV.Text;
                    donvi.TenDV = txtTenDV.Text;
                    donvi.Ghichu = txtGhichu.Text;
                    service.Update(donvi);
                    MessageBox.Show("Cập Nhật Đơn Vị Thành Công!");
                    showDV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMaDV.Text))
                {
                    MessageBox.Show("Mã Đơn Vị Không Được Để Trống", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDV.Focus();
                }
                else
                {
                    service.Remove(txtMaDV.Text.ToString());
                    MessageBox.Show(" Đã Xóa Đơn Vị !");
                    showDV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMaDV.Text))
                {
                    MessageBox.Show("Mã Đơn Vị Không Được Để Trống", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDV.Focus();
                }
                else
                {
                    dataGridView2.DataSource = service.SearchToFromDonvi(txtMaDV.Text.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BidingDonVi(DataGridView dgv,
         TextBox MaDV,
         TextBox TenDV,
           TextBox Ghichu)
        {
            try
            {
                int row = dgv.CurrentCell.RowIndex;
                string _MaDV = dgv.Rows[row].Cells[0].Value.ToString();
                string _TenDV = dgv.Rows[row].Cells[1].Value.ToString();
                string _Ghichu = dgv.Rows[row].Cells[2].Value.ToString();


                MaDV.Text = _MaDV;
                TenDV.Text = _TenDV;
                Ghichu.Text = _Ghichu;

                if (string.IsNullOrEmpty(txtMaDV.Text))
                {
                    MessageBox.Show("Mã Đơn Vị Không Được Để Trống", "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDV.Focus();
                }
                else
                {
                    dataGridView2.DataSource = service.SearchToFromDonvi(txtMaDV.Text.ToString());


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BidingDonVi(dataGridView1, txtMaDV, txtTenDV, txtGhichu);
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


