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
using TEACHER.TeacherManagementForm;

namespace TEACHER
{
    public partial class HopDong : Form
    {
        public HopDong()
        {
            InitializeComponent();
        }

        private HopdongImp service = new HopdongImp();


        private void HopDong_Load(object sender, EventArgs e)
        {
            try
            {
                txtNhanVien.DataSource = service.GetAllNhanVien();
                txtNhanVien.DisplayMember = "TenNV";
                txtNhanVien.ValueMember = "Manv";
                service.GetAll(dataGridView1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void BidingHopdong(DataGridView dgv,
            TextBox MaHopDong,
            ComboBox TenNV,
            DateTimePicker Ngaybatdau,
            DateTimePicker Ngayketthuc,
            NumericUpDown Lanky,
            TextBox Noidung,
            DateTimePicker Ngayky,
            TextBox Tennguoiky,
            TextBox Ghichu
           )
        {
            try
            {
                int row = dgv.CurrentCell.RowIndex;
                string _MaHopDong = dgv.Rows[row].Cells[0].Value.ToString();
                string _MaNV = dgv.Rows[row].Cells[1].Value.ToString();
                string _Ngaybatdau = dgv.Rows[row].Cells[2].Value.ToString();
                string _Ngayketthuc = dgv.Rows[row].Cells[3].Value.ToString();
                string _Lanky = dgv.Rows[row].Cells[4].Value.ToString();
                string _Noidung = dgv.Rows[row].Cells[5].Value.ToString();
                string _Ngayky = dgv.Rows[row].Cells[6].Value.ToString();
                string _Tennguoiky = dgv.Rows[row].Cells[7].Value.ToString();
                string _Ghichu = dgv.Rows[row].Cells[8].Value.ToString();


                MaHopDong.Text = _MaHopDong;
                TenNV.SelectedItem = _MaNV;
                TenNV.Text = service.GetTenNVfromMaNV(int.Parse(_MaNV));
                Ngaybatdau.Text = _Ngaybatdau;
                Ngayketthuc.Text = _Ngayketthuc;
                Lanky.Text = _Lanky;
                Noidung.Text = _Noidung;
                Ngayky.Text = _Ngayky;
                Tennguoiky.Text = _Tennguoiky;
                Ghichu.Text = _Ghichu;
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
                BidingHopdong(dataGridView1, txtMahopdong, txtNhanVien, dtBatDau, dtKetThuc, txtLanKy, txtNoidung, dtNgayKy, txtNguoiKy, txtGhichu);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtMahopdong.Text) || string.IsNullOrEmpty(txtNhanVien.Text) || string.IsNullOrEmpty(dtBatDau.Text) || string.IsNullOrEmpty(dtKetThuc.Text) || string.IsNullOrEmpty(txtLanKy.Text) || string.IsNullOrEmpty(txtNoidung.Text) || string.IsNullOrEmpty(dtNgayKy.Text) || string.IsNullOrEmpty(txtNguoiKy.Text) || string.IsNullOrEmpty(txtGhichu.Text))
                {
                    MessageBox.Show("Các Trường Dữ Liệu Không Được Để Trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tblHopdong newHopdong = new tblHopdong();
                    newHopdong.Mahopdong = txtMahopdong.Text;
                    newHopdong.MaNV = int.Parse(txtNhanVien.SelectedValue.ToString());
                    newHopdong.Lanky = int.Parse(txtLanKy.Value.ToString());
                    newHopdong.Ngaybatdau = DateTime.Parse(dtBatDau.Text);
                    newHopdong.Ngayketthuc = DateTime.Parse(dtKetThuc.Text);
                    newHopdong.Ngayky = DateTime.Parse(dtNgayKy.Text);
                    newHopdong.Noidung = txtNoidung.Text;
                    newHopdong.Tennguoiky = txtNguoiKy.Text;
                    newHopdong.Ghichu = txtGhichu.Text;
                    service.Add(newHopdong);
                    MessageBox.Show("Thêm Hợp Đồng Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    service.GetAll(dataGridView1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "LỖi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var Hopdong = service.GetOne(int.Parse(txtManv.Text)).First();
                if (Hopdong != null)
                {
                    txtMahopdong.Text = Hopdong.Mahopdong;
                    txtNhanVien.SelectedItem = Hopdong.MaNV;
                    txtNhanVien.Text = service.GetTenNVfromMaNV(Hopdong.MaNV);
                    dtBatDau.Text = Hopdong.Ngaybatdau.ToString();
                    dtKetThuc.Text = Hopdong.Ngayketthuc.ToString();
                    txtLanKy.Value = decimal.Parse(Hopdong.Lanky.ToString());
                    txtNoidung.Text = Hopdong.Noidung;
                    dtNgayKy.Text = Hopdong.Ngayky.ToString();
                    txtNguoiKy.Text = Hopdong.Tennguoiky;
                    txtGhichu.Text = Hopdong.Ghichu;
                    dataGridView1.DataSource = service.GetOne(int.Parse(txtManv.Text));
                }
                else
                {
                    MessageBox.Show("không Tìm Thấy Dữ Liệu Phù Hợp!");
                    service.GetAll(dataGridView1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("không Tìm Thấy Dữ Liệu Phù Hợp!");
            }
        }



        private void txtNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Hopdong = service.GetOne(int.Parse(txtNhanVien.SelectedValue.ToString())).First();
                if (Hopdong != null)
                {
                    txtMahopdong.Text = Hopdong.Mahopdong;
                    txtNhanVien.Text = service.GetTenNVfromMaNV(Hopdong.MaNV);
                    dtBatDau.Text = Hopdong.Ngaybatdau.ToString();
                    dtKetThuc.Text = Hopdong.Ngayketthuc.ToString();
                    txtLanKy.Value = decimal.Parse(Hopdong.Lanky.ToString());
                    txtNoidung.Text = Hopdong.Noidung;
                    dtNgayKy.Text = Hopdong.Ngayky.ToString();
                    txtNguoiKy.Text = Hopdong.Tennguoiky;
                    txtGhichu.Text = Hopdong.Ghichu;
                    dataGridView1.DataSource = service.GetOne(int.Parse(txtNhanVien.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("không Tìm Thấy Dữ Liệu Phù Hợp!");
                }
            }
            catch (Exception ex)
            {

      
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMahopdong.Text)  || string.IsNullOrEmpty(dtBatDau.Text) || string.IsNullOrEmpty(dtKetThuc.Text) || string.IsNullOrEmpty(txtLanKy.Text) || string.IsNullOrEmpty(txtNoidung.Text) || string.IsNullOrEmpty(dtNgayKy.Text) || string.IsNullOrEmpty(txtNguoiKy.Text) || string.IsNullOrEmpty(txtGhichu.Text))
                {
                    MessageBox.Show("Các Trường Dữ Liệu Không Được Để Trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tblHopdong newHopdong = new tblHopdong();
                    newHopdong.Mahopdong = txtMahopdong.Text;
                    newHopdong.Lanky = int.Parse(txtLanKy.Value.ToString());
                    newHopdong.Ngaybatdau = DateTime.Parse(dtBatDau.Text);
                    newHopdong.Ngayketthuc = DateTime.Parse(dtKetThuc.Text);
                    newHopdong.Ngayky = DateTime.Parse(dtNgayKy.Text);
                    newHopdong.Noidung = txtNoidung.Text;
                    newHopdong.Tennguoiky = txtNguoiKy.Text;
                    newHopdong.Ghichu = txtGhichu.Text;
                    service.Update(newHopdong);
                    service.GetAll(dataGridView1);
                    MessageBox.Show("Sửa Hợp Đồng Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                service.Remove(txtMahopdong);
                MessageBox.Show("Hợp Đồng:" + txtMahopdong.Text + "Đã Bị Xóa", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeacherManageForm newform =new TeacherManageForm();     
            newform.ShowDialog();
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNhanVien.DataSource = service.GetAllNhanVien();
            txtNhanVien.DisplayMember = "TenNV";
            txtNhanVien.ValueMember = "Manv";
            service.GetAll(dataGridView1);
        }
    }
}
