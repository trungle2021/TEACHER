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

namespace TEACHER.TeacherManagementForm
{
    public partial class TeacherManageForm : Form
    {
        private TeacherServiceImp teacher_service = new TeacherServiceImp();
        private DonViServiceImp donvi_service = new DonViServiceImp();
        private ToServiceImp to_service = new ToServiceImp();
        public TeacherManageForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void TeacherManageForm_Load(object sender, EventArgs e)
        {
            var teacher_list = teacher_service.GetAll();
            var donvi_list = donvi_service.GetAll();

            TeacherList_PrimaryInfo_dataGridView.DataSource = teacher_list;
            TeacherList_RelevantInfo_dataGridView.DataSource = teacher_list;
            TeacherList_Relative_Datagridview.DataSource = teacher_list;



            LoadDataToCBX(TeacherDV_Relevant_CBX, donvi_list,"TenDV","MaDV");
        }

        public void LoadDataToCBX<T>(ComboBox combobox, IEnumerable<T> list, string displayMember, string valueMember)
        {
            combobox.DataSource = list;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;


        }

        public void LoadDataFromDGVToPrimaryInfo(DataGridView dgvPrimaryInfo,
            TextBox Manv,
            TextBox Tennv,
            TextBox CMND,
            DateTimePicker NgayCap,
            TextBox Tinhthanh,
            DateTimePicker Ngaysinh,
            RadioButton Gioitinh,
            TextBox NguyenQuan,
            TextBox DCTamTru,
            TextBox Email,
            TextBox SDTRieng,
            TextBox SDTNha,
            TextBox TinhTrangHonNhan,
            TextBox TinhTrangLamViec)
        {
            int row = dgvPrimaryInfo.CurrentCell.RowIndex;
            string _Manv = dgvPrimaryInfo.Rows[row].Cells[0].Value.ToString();
            string _Tennv = dgvPrimaryInfo.Rows[row].Cells[1].Value.ToString();
            string _CMND = dgvPrimaryInfo.Rows[row].Cells[2].Value.ToString();
            string _NgayCap = dgvPrimaryInfo.Rows[row].Cells[3].Value.ToString();
            string _Tinhthanh = dgvPrimaryInfo.Rows[row].Cells[4].Value.ToString();
            string _Ngaysinh = dgvPrimaryInfo.Rows[row].Cells[5].Value.ToString();
            string _Gioitinh = dgvPrimaryInfo.Rows[row].Cells[6].Value.ToString();
            string _NguyenQuan = dgvPrimaryInfo.Rows[row].Cells[7].Value.ToString();
            string _DCTamTru = dgvPrimaryInfo.Rows[row].Cells[8].Value.ToString();
            string _Email = dgvPrimaryInfo.Rows[row].Cells[9].Value.ToString();
            string _SDTRieng = dgvPrimaryInfo.Rows[row].Cells[10].Value.ToString();
            string _SDTNha = dgvPrimaryInfo.Rows[row].Cells[11].Value.ToString();
            string _TinhTrangHonNhan = dgvPrimaryInfo.Rows[row].Cells[12].Value.ToString();
            string _TinhTrangLamViec = dgvPrimaryInfo.Rows[row].Cells[13].Value.ToString();

            Manv.Text = _Manv;
            Tennv.Text = _Tennv;
            CMND.Text = _CMND;
            NgayCap.Text = _NgayCap;
            Tinhthanh.Text = _Tinhthanh;
            Ngaysinh.Text = _Ngaysinh;
            Gioitinh.Text = _Gioitinh;
            NguyenQuan.Text = _NguyenQuan;
            DCTamTru.Text = _DCTamTru;
            Email.Text = _Email;
            SDTRieng.Text = _SDTRieng;
            SDTNha.Text = _SDTNha;
            TinhTrangHonNhan.Text = _TinhTrangHonNhan;
            TinhTrangLamViec.Text = _TinhTrangLamViec;

        }



        private void TeacherList_PrimaryInfo_dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            LoadDataFromDGVToPrimaryInfo(TeacherList_PrimaryInfo_dataGridView,
               TeacherID_PrimaryInfo_TXT,
               TeacherName_PrimaryInfo_TXT,
               CMND_PrimaryInfo_TXT,
               CMND_PrimaryInfo_DateCreated_TXT,
               CMNDLocation_PrimaryInfo_TXT,
               Teacher_PrimaryInfo_BirthdayPicker,
               rdMale_PrimaryInfo,
               BornLocation_PrimaryInfo_TXT,
               Address_PrimaryInfo_TXT,
               Email_PrimaryInfo_TXT,
               PersonalPhone_PrimaryInfo_TXT,
               HomePhone_PrimaryInfo_TXT,
               Relationship_PrimaryInfo_TXT,
               WorkingState_PrimaryInfo_TXT
              );
        }

        private void Search_PrimaryInfo_TXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<tblNhanvien> teacher;
                string text_Search = Search_PrimaryInfo_TXT.Text.ToString();
                if (string.IsNullOrEmpty(text_Search) && string.IsNullOrWhiteSpace(text_Search))
                {
                    teacher = teacher_service.GetAll();
                }
                else
                {
                    bool parseTextSearch = int.TryParse(text_Search, out int result);
                    teacher = teacher_service.SearchByEmpID(result);
                    if (teacher.Count() < 1)
                    {
                        teacher = teacher_service.GetAll();
                        MessageBox.Show("Không Tìm Thấy Dữ Liệu Phù Hợp");

                    }
                }

                TeacherList_PrimaryInfo_dataGridView.DataSource = teacher;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_PrimaryInfo_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new tblNhanvien
                {
                    TenNV = TeacherName_PrimaryInfo_TXT.Text,
                    CMND = CMND_PrimaryInfo_TXT.Text,
                    Ngaycap = CMND_PrimaryInfo_DateCreated_TXT.Value,
                    Tinhthanh = CMNDLocation_PrimaryInfo_TXT.Text,
                    Ngaysinh = Teacher_PrimaryInfo_BirthdayPicker.Value,
                    Gioitinh = rdMale_PrimaryInfo.Text,
                    Nguyenquan = BornLocation_PrimaryInfo_TXT.Text,
                    Dctamtru = Address_PrimaryInfo_TXT.Text,
                    Email = Email_PrimaryInfo_TXT.Text,
                    SDTrieng = PersonalPhone_PrimaryInfo_TXT.Text,
                    SDTnha = HomePhone_PrimaryInfo_TXT.Text,
                    Tinhtranghonnhan = Relationship_PrimaryInfo_TXT.Text,
                    Tinhtranglamviec = WorkingState_PrimaryInfo_TXT.Text,
                    MaDV_To = null,
                    Machucvu = null,
                    Ngayvaolam = null,
                    Thamnien = null,
                    Heso = null,
                    Matinhoc = null,
                    Mangoaingu = null,
                    Mabangcap = null,
                    Matongiao = null,
                    Madantoc = null
                };
                teacher_service.Add(teacher);
                MessageBox.Show("Thêm mới thành công");
                var result = teacher_service.GetAll();
                TeacherList_PrimaryInfo_dataGridView.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnEdit_PrimaryInfo_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new tblNhanvien
                {
                    Manv = int.Parse(TeacherID_PrimaryInfo_TXT.Text),
                    MaDV_To = null,
                    Machucvu = null,
                    Ngayvaolam = null,
                    Thamnien = null,
                    Heso = null,
                    Matinhoc = null,
                    Mangoaingu = null,
                    Mabangcap = null,
                    Matongiao = null,
                    Madantoc = null
                };
                teacher_service.Update(teacher);
                MessageBox.Show("Sửa Thông Tin Thành Công");
                var result = teacher_service.GetAll();
                TeacherList_PrimaryInfo_dataGridView.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_PrimaryInfo_Click(object sender, EventArgs e)
        {
            try
            {

                int Manv = int.Parse(TeacherID_PrimaryInfo_TXT.Text);
                
                teacher_service.Remove(Manv);
                MessageBox.Show("Xóa Giáo Viên Thành Công");
                var result = teacher_service.GetAll();
                TeacherList_PrimaryInfo_dataGridView.DataSource = result;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_PrimaryInfo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Relevant_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Relevant_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Relevant_Click(object sender, EventArgs e)
        {

        }

        private void TeacherDV_Relevant_CBX_SelectedValueChanged(object sender, EventArgs e)
        {
            var pa = new
            {
                MaDV = TeacherDV_Relevant_CBX.SelectedValue.ToString(),
            };

            var toByDonVi = Helper.Query<Donvi_tolamviec_junction>(Helper.ConnectionString(), "QLGV.dbo.FindAllToByDonVi", pa).ToList();

            LoadDataToCBX(TeacherTO_Relevant_CBX, toByDonVi, "Tento", "Mato");

        }

        private void TeacherDV_Relevant_CBX_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }
}


