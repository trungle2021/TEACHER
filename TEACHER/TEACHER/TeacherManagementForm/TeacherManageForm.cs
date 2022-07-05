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

namespace TEACHER.TeacherManagementForm
{
    public partial class TeacherManageForm : Form
    {
        private TeacherServiceImp service = new TeacherServiceImp();
        public TeacherManageForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void TeacherManageForm_Load(object sender, EventArgs e)
        {
           var result = service.GetAll();
            TeacherList_RelevantInfo_dataGridView.DataSource = result;
            TeacherList_PrimaryInfo_dataGridView.DataSource = result;
            TeacherList_Relative_Datagridview.DataSource = result;
            
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
            NgayCap.Text = _NgayCap ;
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

        private void Search_PrimaryInfo_TXT_KeyUp(object sender, KeyEventArgs e)
        {
            string text_Search = Search_PrimaryInfo_TXT.Text.ToString();
            bool parseTextSearch = int.TryParse(text_Search,out int result);

            var teacher = service.GetOne(result);
            TeacherList_PrimaryInfo_dataGridView.DataSource = teacher;

        }
    }
}


