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
    public partial class ChucVuForm : Form
    {
        ChucVuServiceImp chucVuService = new ChucVuServiceImp();
        public ChucVuForm()
        {
            InitializeComponent();
        }

        private void ChucVuForm_Load(object sender, EventArgs e)
        {
            try
            {
                var chucvu_list = chucVuService.GetAll();
                ChucvuList_datagridview.DataSource = chucvu_list;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ChucvuList_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = ChucvuList_datagridview.CurrentCell.RowIndex;

            string _Machucvu = ChucvuList_datagridview.Rows[row].Cells[0].Value.ToString();
            string _Tenchucvu = ChucvuList_datagridview.Rows[row].Cells[1].Value.ToString();
            string _Hesochucvu = ChucvuList_datagridview.Rows[row].Cells[2].Value.ToString();
            string _Ghichu = ChucvuList_datagridview.Rows[row].Cells[3].Value.ToString();

            txtMachucvu.Text = _Machucvu;
            txtTenchucvu.Text = _Tenchucvu;
            txtHesochucvu.Text = _Hesochucvu;
            txtGhichu.Text = _Ghichu;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string _Machucvu = txtMachucvu.Text;
                string _Tenchucvu = txtTenchucvu.Text;
                string _Hesochucvu = txtHesochucvu.Text;
                string _Ghichu = txtGhichu.Text;

                var pa = new
                {
                    Machucvu = _Machucvu,
                    Tenchucvu = _Tenchucvu,
                    Hesochucvu = _Hesochucvu,
                    Ghichu = _Ghichu
                };
                var chucvu =  chucVuService.GetOne(_Machucvu);
                //var tenchucvu_exist = chucVuService.GetTenChucVu(_Tenchucvu);
                if (chucvu != null)
                {
                    throw new Exception("Mã Chức Vụ đã tồn tại! Vui lòng nhập mã khác!");
                }
                //else if (tenchucvu_exist != null)
                //{
                //    throw new Exception("Tên Chức Vụ đã tồn tại! Vui lòng nhập tên khác!");
                //}

                Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.AddChucVu", pa);
                MessageBox.Show("Thêm chức vụ thành công!");
                var chucvu_list = chucVuService.GetAll();
                ChucvuList_datagridview.DataSource = chucvu_list;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string _Machucvu = txtMachucvu.Text;
                string _Tenchucvu = txtTenchucvu.Text;
                string _Hesochucvu = txtHesochucvu.Text;
                string _Ghichu = txtGhichu.Text;

                var pa = new
                {
                    Machucvu = _Machucvu,
                    Tenchucvu = _Tenchucvu,
                    Hesochucvu = _Hesochucvu,
                    Ghichu = _Ghichu
                };
                var chucvu = chucVuService.GetOne(_Machucvu);
                //var tenchucvu_exist = chucVuService.GetTenChucVu(_Tenchucvu);
                if (chucvu == null)
                {
                    throw new Exception("Không tìm thấy dữ liệu phù hợp");
                }
                
                Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.UpdateChucVu", pa);
                MessageBox.Show("Sửa chức vụ thành công!");
                var chucvu_list = chucVuService.GetAll();
                ChucvuList_datagridview.DataSource = chucvu_list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string _Machucvu = txtMachucvu.Text;
                

                var pa = new
                {
                    Machucvu = _Machucvu,
                   
                };
                var chucvu = chucVuService.GetOne(_Machucvu);
                
                if (chucvu == null)
                {
                    throw new Exception("Không tìm thấy dữ liệu phù hợp");
                }
                Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.DeleteChucVu", pa);
                MessageBox.Show("Xóa chức vụ thành công!");
                var chucvu_list = chucVuService.GetAll();
                ChucvuList_datagridview.DataSource = chucvu_list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
