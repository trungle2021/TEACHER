using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        public TeacherManageForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        public bool checkGenderChecked(RadioButton rdMale, RadioButton rdFemale)
        {
            try
            {
                if (rdMale.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void TeacherManageForm_Load(object sender, EventArgs e)
        {
            try
            {
                var teacher_list = teacher_service.GetAll();
                var donvi_list = donvi_service.GetAll();
                var chucvu_list = Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.GetAllChucvu").ToList();
                var ngoaingu_list = Helper.Query<tblNgoaingu>(Helper.ConnectionString(), "QLGV.dbo.GetAllNgoaingu").ToList();
                var tinhoc_list = Helper.Query<tblTinhoc>(Helper.ConnectionString(), "QLGV.dbo.GetAllTinhoc").ToList();
                var tongiao_list = Helper.Query<tblTongiao>(Helper.ConnectionString(), "QLGV.dbo.GetAllTongiao").ToList();
                var dantoc_list = Helper.Query<tblDantoc>(Helper.ConnectionString(), "QLGV.dbo.GetAllDantoc").ToList();
                var bangcap_list = Helper.Query<tblBangcap>(Helper.ConnectionString(), "QLGV.dbo.GetAllBangcap").ToList();

                TeacherList_PrimaryInfo_dataGridView.DataSource = teacher_list;
                TeacherList_RelevantInfo_dataGridView.DataSource = teacher_list;

                LoadDataToCBX(TeacherDV_Relevant_CBX, donvi_list, "TenDV", "MaDV");
                LoadDataToCBX(TeacherPosition_Relevant_CBX, chucvu_list, "Tenchucvu", "Machucvu");
                LoadDataToCBX(TeacherLanguageCer_Relevant_CBX, ngoaingu_list, "Tenngoaingu", "Mangoaingu");
                LoadDataToCBX(TeacherOfficeSkillCer_Relevant_CBX, tinhoc_list, "Tentinhoc", "Matinhoc");
                LoadDataToCBX(TeacherReligion_Relevant_CBX, tongiao_list, "Tentongiao", "Matongiao");
                LoadDataToCBX(TeacherEthnic_Relevant_CBX, dantoc_list, "Tendantoc", "Madantoc");
                LoadDataToCBX(TeacherCer_Relevant_CBX, bangcap_list, "Tenbangcap", "Mabangcap");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                var pa = new
                {
                    MaDV = TeacherDV_Relevant_CBX.SelectedValue.ToString(),
                };

                var toByDonVi = Helper.Query<Donvi_tolamviec_junction>(Helper.ConnectionString(), "QLGV.dbo.FindAllToByDonVi", pa).ToList();

                LoadDataToCBX(TeacherTO_Relevant_CBX, toByDonVi, "Tento", "Mato");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadDataToCBX<T>(ComboBox combobox, IEnumerable<T> list, string displayMember, string valueMember)
        {
            combobox.DataSource = list;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;
        }
        public void LoadDataFromDGVToPrimaryInfo(DataGridView dgvPrimaryInfo,TextBox Manv,TextBox Tennv,TextBox CMND,DateTimePicker NgayCap,TextBox Tinhthanh,DateTimePicker Ngaysinh,TextBox NguyenQuan,TextBox DCTamTru,TextBox Email,TextBox SDTRieng,TextBox SDTNha,TextBox TinhTrangHonNhan,TextBox TinhTrangLamViec)
        {
            try
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

                if (_Gioitinh == "Nam")
                {
                    rdMale_PrimaryInfo.Checked = true;
                    rdFemale_PrimaryInfo.Checked = false;
                }
                else
                {
                    rdMale_PrimaryInfo.Checked = false;
                    rdFemale_PrimaryInfo.Checked = true;
                }
                NguyenQuan.Text = _NguyenQuan;
                DCTamTru.Text = _DCTamTru;
                Email.Text = _Email;
                SDTRieng.Text = _SDTRieng;
                SDTNha.Text = _SDTNha;
                TinhTrangHonNhan.Text = _TinhTrangHonNhan;
                TinhTrangLamViec.Text = _TinhTrangLamViec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void LoadDataFromDGVToRelevantInfo(DataGridView dgvRelevant,TextBox Manv,TextBox Tennv,ComboBox MaDV,ComboBox MaTo,ComboBox MaChucVu,DateTimePicker NgayVaoLam,TextBox ThamNien,ComboBox MaTinHoc,ComboBox MaNgoaiNgu,ComboBox MaBangCap,ComboBox MaTonGiao,ComboBox MaDanToc)
        {
            try
            {
                int row = dgvRelevant.CurrentCell.RowIndex;
                string _Manv = dgvRelevant.Rows[row].Cells[0].Value.ToString();
                string _Tennv = dgvRelevant.Rows[row].Cells[1].Value.ToString();
                string _Tentongiao = dgvRelevant.Rows[row].Cells[14].Value.ToString();
                string _Tenchucvu = dgvRelevant.Rows[row].Cells[15].Value.ToString();
                string _Tendantoc = dgvRelevant.Rows[row].Cells[16].Value.ToString();
                string _Tenbangcap = dgvRelevant.Rows[row].Cells[17].Value.ToString();
                string _Tendonvi = dgvRelevant.Rows[row].Cells[18].Value.ToString();
                string _Tento = dgvRelevant.Rows[row].Cells[19].Value.ToString();
                string _Tenngoaingu = dgvRelevant.Rows[row].Cells[20].Value.ToString();
                string _Tentinhoc = dgvRelevant.Rows[row].Cells[21].Value.ToString();
                string _Ngayvaolam = dgvRelevant.Rows[row].Cells[22].Value.ToString();
                string _Thamnien = dgvRelevant.Rows[row].Cells[23].Value.ToString();

                Manv.Text = _Manv;
                Tennv.Text = _Tennv;
                MaDV.Text = _Tendonvi;
                MaTo.Text = _Tento;
                MaChucVu.Text = _Tenchucvu;
                NgayVaoLam.Value = DateTime.Parse(_Ngayvaolam);
                ThamNien.Text = _Thamnien;
                MaTinHoc.Text = _Tentinhoc;
                MaNgoaiNgu.Text = _Tenngoaingu;
                MaBangCap.Text = _Tenbangcap;
                MaTonGiao.Text = _Tentongiao;
                MaDanToc.Text = _Tendantoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void TeacherList_PrimaryInfo_dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                LoadDataFromDGVToPrimaryInfo(TeacherList_PrimaryInfo_dataGridView,
               TeacherID_PrimaryInfo_TXT,
               TeacherName_PrimaryInfo_TXT,
               CMND_PrimaryInfo_TXT,
               CMND_PrimaryInfo_DateCreated_TXT,
               CMNDLocation_PrimaryInfo_TXT,
               Teacher_PrimaryInfo_BirthdayPicker,
               BornLocation_PrimaryInfo_TXT,
               Address_PrimaryInfo_TXT,
               Email_PrimaryInfo_TXT,
               PersonalPhone_PrimaryInfo_TXT,
               HomePhone_PrimaryInfo_TXT,
               Relationship_PrimaryInfo_TXT,
               WorkingState_PrimaryInfo_TXT
              );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TeacherList_RelevantInfo_dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                LoadDataFromDGVToRelevantInfo(TeacherList_RelevantInfo_dataGridView,
               TeacherID_Relevant_TXT,
               TeacherName_Relevant_TXT,
               TeacherDV_Relevant_CBX,
               TeacherTO_Relevant_CBX,
               TeacherPosition_Relevant_CBX,
               Teacher_Relevant_DateStartWork_Datetime,
               TeacherWorkAge_Relevant_TXT,
               TeacherOfficeSkillCer_Relevant_CBX,
               TeacherLanguageCer_Relevant_CBX,
               TeacherCer_Relevant_CBX,
               TeacherReligion_Relevant_CBX,
               TeacherEthnic_Relevant_CBX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void Search_PrimaryInfo_TXT_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string text_Search = Search_PrimaryInfo_TXT.Text.ToString();
                if (string.IsNullOrEmpty(text_Search) && string.IsNullOrWhiteSpace(text_Search))
                {
                    IEnumerable<AllField> teacher = teacher_service.GetAll();
                    TeacherList_PrimaryInfo_dataGridView.DataSource = teacher;
                }
                else
                {
                    bool parseTextSearch = int.TryParse(text_Search, out int result);
                    IEnumerable<AllField> teacher = teacher_service.SearchByEmpID(result);
                    if (teacher.Count() < 1 || parseTextSearch == false)
                    {
                        IEnumerable<AllField> _teacher = teacher_service.GetAll();
                        TeacherList_PrimaryInfo_dataGridView.DataSource = _teacher;
                        MessageBox.Show("Không Tìm Thấy Dữ Liệu Phù Hợp");

                    }
                    else
                    {
                        TeacherList_PrimaryInfo_dataGridView.DataSource = teacher;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_PrimaryInfo_Click(object sender, EventArgs e)
        {
            string regex_cmnd_pattern = "^[0-9]{9}$";
            Regex reg = new Regex(regex_cmnd_pattern);
            // Get all matches  
            MatchCollection isMatched = reg.Matches(CMND_PrimaryInfo_TXT.Text.ToString());
            try
            {
                if (!string.IsNullOrEmpty(TeacherID_PrimaryInfo_TXT.Text.ToString()))
                {
                    throw new Exception("Mã Nhân Viên sẽ được đặt tự động! Vui lòng để trống Mã Nhân Viên khi thêm mới!");
                }
                else if (string.IsNullOrEmpty(TeacherName_PrimaryInfo_TXT.Text.ToString()))
                {
                    throw new Exception("Tên Nhân Viên không được để trống!");
                }
                else if (string.IsNullOrEmpty(CMND_PrimaryInfo_TXT.Text.ToString()) || isMatched.Count == 0)
                {
                    throw new Exception("Chứng Minh Nhân Dân không được để trống và có độ dài từ 0-9 số");
                }
                var teacher = new tblNhanvien
                {
                    TenNV = TeacherName_PrimaryInfo_TXT.Text,
                    CMND = CMND_PrimaryInfo_TXT.Text,
                    Ngaycap = CMND_PrimaryInfo_DateCreated_TXT.Value,
                    Tinhthanh = CMNDLocation_PrimaryInfo_TXT.Text,
                    Ngaysinh = Teacher_PrimaryInfo_BirthdayPicker.Value,
                    Gioitinh = rdMale_PrimaryInfo.Checked == true ? rdMale_PrimaryInfo.Text : rdFemale_PrimaryInfo.Text,
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
                int index_last_row = TeacherList_PrimaryInfo_dataGridView.Rows.Count - 1;
                string _Manv = TeacherList_PrimaryInfo_dataGridView.Rows[index_last_row].Cells[0].Value.ToString();
                TeacherID_PrimaryInfo_TXT.Text = _Manv;
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

                if (!string.IsNullOrEmpty(TeacherID_Relevant_TXT.Text.ToString()))
                {
                    throw new Exception("Mã Nhân Viên sẽ được đặt tự động! Vui lòng để trống Mã Nhân Viên khi thêm mới!");
                }
                
                var teacher_current_update = teacher_service.GetOne(int.Parse(TeacherID_PrimaryInfo_TXT.Text.ToString()));
                if(teacher_current_update == null) { 
                    throw new Exception("Không Tìm thấy Nhân Viên có Mã " + TeacherID_PrimaryInfo_TXT.Text.ToString());
                }
                var teacher = new tblNhanvien
                {
                    Manv = int.Parse(TeacherID_PrimaryInfo_TXT.Text.ToString()),
                    TenNV = TeacherName_PrimaryInfo_TXT.Text,
                    CMND = CMND_PrimaryInfo_TXT.Text,
                    Ngaycap = CMND_PrimaryInfo_DateCreated_TXT.Value,
                    Tinhthanh = CMNDLocation_PrimaryInfo_TXT.Text,
                    Ngaysinh = Teacher_PrimaryInfo_BirthdayPicker.Value,
                    Gioitinh = rdMale_PrimaryInfo.Checked == true ? rdMale_PrimaryInfo.Text : rdFemale_PrimaryInfo.Text,
                    Nguyenquan = BornLocation_PrimaryInfo_TXT.Text,
                    Dctamtru = Address_PrimaryInfo_TXT.Text,
                    Email = Email_PrimaryInfo_TXT.Text,
                    SDTrieng = PersonalPhone_PrimaryInfo_TXT.Text,
                    SDTnha = HomePhone_PrimaryInfo_TXT.Text,
                    Tinhtranghonnhan = Relationship_PrimaryInfo_TXT.Text,
                    Tinhtranglamviec = WorkingState_PrimaryInfo_TXT.Text,
                    MaDV_To = teacher_current_update.MaDV_To,
                    Machucvu = teacher_current_update.Machucvu,
                    Ngayvaolam = teacher_current_update.Ngayvaolam,
                    Thamnien = teacher_current_update.Thamnien,
                    Matinhoc = teacher_current_update.Matinhoc,
                    Mangoaingu = teacher_current_update.Mangoaingu,
                    Mabangcap = teacher_current_update.Mabangcap,
                    Matongiao = teacher_current_update.Matongiao,
                    Madantoc = teacher_current_update.Madantoc
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
                if (string.IsNullOrEmpty(TeacherID_PrimaryInfo_TXT.Text.ToString()))
                {
                    throw new Exception("Vui lòng chọn Nhân Viên muốn xóa!");
                }
                int Manv = int.Parse(TeacherID_PrimaryInfo_TXT.Text);
                var teacher_current_update = teacher_service.GetOne(Manv);
                if (teacher_current_update == null)
                {
                    throw new Exception("Không Tìm thấy Nhân Viên có Mã " + TeacherID_PrimaryInfo_TXT.Text.ToString());
                }
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
            this.Close();
        }

        private void btnEdit_Relevant_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TeacherDV_Relevant_CBX.Text.ToString()))
                {
                    throw new Exception("Vui lòng chọn Đơn Vị trước khi chọn Tổ");
                }
                var pa = new
                {
                    Tendonvi = TeacherDV_Relevant_CBX.Text,
                    Tento = TeacherTO_Relevant_CBX.Text,
                };
            var MaDV_TO = Helper.Query<int>(Helper.ConnectionString(), "QLGV.dbo.GetID_Donvi_To_ByName", pa).FirstOrDefault();
            var parseThamNien = int.TryParse(TeacherWorkAge_Relevant_TXT.Text, out int outThamnien);
            var teacher_current_update = teacher_service.GetOne(int.Parse(TeacherID_Relevant_TXT.Text));
                if (teacher_current_update == null)
                {
                    throw new Exception("Không Tìm thấy Nhân Viên có Mã " + TeacherID_Relevant_TXT.Text.ToString());
                }
                var teacher = new tblNhanvien
            {
                    Manv = int.Parse(TeacherID_Relevant_TXT.Text.ToString()),
                    TenNV = TeacherName_Relevant_TXT.Text,
                    CMND = TeacherList_RelevantInfo_dataGridView.Rows[TeacherList_RelevantInfo_dataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                    Ngaycap = teacher_current_update.Ngaycap,
                    Tinhthanh = teacher_current_update.Tinhthanh,
                    Ngaysinh = teacher_current_update.Ngaysinh,
                    Gioitinh = teacher_current_update.Gioitinh,
                    Nguyenquan = teacher_current_update.Nguyenquan,
                    Dctamtru = teacher_current_update.Dctamtru,
                    Email = teacher_current_update.Email,
                    SDTrieng = teacher_current_update.SDTrieng,
                    SDTnha = teacher_current_update.SDTnha,
                    Tinhtranghonnhan = teacher_current_update.Tinhtranghonnhan,
                    Tinhtranglamviec = teacher_current_update.Tinhtranglamviec,
                    MaDV_To = MaDV_TO,
                    Machucvu = TeacherPosition_Relevant_CBX.SelectedValue.ToString(),
                    Ngayvaolam = Teacher_Relevant_DateStartWork_Datetime.Value,
                    Thamnien = outThamnien,
                    Matinhoc = TeacherOfficeSkillCer_Relevant_CBX.SelectedValue.ToString(),
                    Mangoaingu = TeacherLanguageCer_Relevant_CBX.SelectedValue.ToString(),
                    Mabangcap = TeacherCer_Relevant_CBX.SelectedValue.ToString(),
                    Matongiao = TeacherReligion_Relevant_CBX.SelectedValue.ToString(),
                    Madantoc = TeacherEthnic_Relevant_CBX.SelectedValue.ToString()
            };
                teacher_service.Update(teacher);
                MessageBox.Show("Sửa Thông Tin Thành Công");
                var result = teacher_service.GetAll();
                TeacherList_RelevantInfo_dataGridView.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
        }
    }

        private void btnDelete_Relevant_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TeacherID_Relevant_TXT.Text.ToString()))
                {
                    throw new Exception("Vui lòng chọn Mã Nhân Viên để xóa!");
                }
                int Manv = int.Parse(TeacherID_Relevant_TXT.Text);
                var teacher_current_update = teacher_service.GetOne(Manv);
                if (teacher_current_update == null)
                {
                    throw new Exception("Không Tìm thấy Nhân Viên có Mã " + TeacherID_Relevant_TXT.Text.ToString());
                }
                teacher_service.Remove(Manv);
                MessageBox.Show("Xóa Giáo Viên Thành Công");
                var result = teacher_service.GetAll();
                TeacherList_RelevantInfo_dataGridView.DataSource = result;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Relevant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher_list = teacher_service.GetAll();
                TeacherList_PrimaryInfo_dataGridView.DataSource = teacher_list;
                TeacherList_RelevantInfo_dataGridView.DataSource = teacher_list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TeacherDV_Relevant_CBX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var pa = new
                {
                    MaDV = TeacherDV_Relevant_CBX.SelectedValue.ToString(),
                };

                var toByDonVi = Helper.Query<Donvi_tolamviec_junction>(Helper.ConnectionString(), "QLGV.dbo.FindAllToByDonVi", pa).ToList();

                LoadDataToCBX(TeacherTO_Relevant_CBX, toByDonVi, "Tento", "Mato");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Relevant_TXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text_Search = Search_Relevant_TXT.Text.ToString();
                if (string.IsNullOrEmpty(text_Search) || string.IsNullOrWhiteSpace(text_Search))
                {
                    IEnumerable<AllField> teacher = teacher_service.GetAll();
                    TeacherList_RelevantInfo_dataGridView.DataSource = teacher;
                }
                else
                {
                    bool parseTextSearch = int.TryParse(text_Search, out int result);
                    IEnumerable<AllField> teacher = teacher_service.SearchByEmpID(result);
                    if (teacher == null || parseTextSearch == false)
                    {
                        IEnumerable<AllField> _teacher = teacher_service.GetAll();
                        TeacherList_RelevantInfo_dataGridView.DataSource = _teacher;
                        MessageBox.Show("Không Tìm Thấy Dữ Liệu Phù Hợp");

                    }
                    else
                    {
                        TeacherList_RelevantInfo_dataGridView.DataSource = teacher;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TeacherDV_Relevant_CBX_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


