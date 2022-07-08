using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using TEACHER.Model;
using TEACHER.Repository;
using System.Windows.Forms;

namespace TEACHER.Service
{
    public class TeacherServiceImp : ITeacher
    {
      
        public tblNhanvien GetOne(int MaNV)
        {
            var pa = new
            {
                MaNV = MaNV
            };
            return Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.GetOneTeacher", pa).FirstOrDefault();
        }

        public IEnumerable<AllField> GetAll()
        {

            return Helper.Query<AllField>(Helper.ConnectionString(), "QLGV.dbo.GetAllTeacher").ToList();
            
            
        }

        public void Add(tblNhanvien entity)
        {
            var pa = new {
                TenNV = entity.TenNV,
                CMND = entity.CMND,
                Ngaycap = entity.Ngaycap,
                Tinhthanh = entity.Tinhthanh,
                Ngaysinh = entity.Ngaysinh,
                Gioitinh = entity.Gioitinh,
                Nguyenquan = entity.Nguyenquan,
                Dctamtru = entity.Dctamtru,
                Email = entity.Email,
                SDTrieng = entity.SDTrieng,
                SDTnha = entity.SDTnha,
                Tinhtranghonnhan = entity.Tinhtranghonnhan,
                Tinhtranglamviec = entity.Tinhtranglamviec,
                MaDV_To = entity.MaDV_To,
                Machucvu = entity.Machucvu,
                Ngayvaolam = entity.Ngayvaolam,
                Thamnien = entity.Thamnien,
                Matinhoc= entity.Matinhoc, 
                Mangoaingu = entity.Mangoaingu,
                Mabangcap = entity.Mabangcap,
                Matongiao = entity.Matongiao,
                Madantoc= entity.Madantoc

            };

            Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.AddTeacher", pa);
        }

        public void Remove(int Manv)
        {
            var pa = new
            {
                Manv = Manv
            };

            Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.DeleteTeacher", pa);
        }


        public void Update(tblNhanvien entity)
        {
            var pa = new
            {
                Manv = entity.Manv,
                TenNV = entity.TenNV,
                CMND = entity.CMND,
                Ngaycap = entity.Ngaycap,
                Tinhthanh = entity.Tinhthanh,
                Ngaysinh = entity.Ngaysinh,
                Gioitinh = entity.Gioitinh,
                Nguyenquan = entity.Nguyenquan,
                Dctamtru = entity.Dctamtru,
                Email = entity.Email,
                SDTrieng = entity.SDTrieng,
                SDTnha = entity.SDTnha,
                Tinhtranghonnhan = entity.Tinhtranghonnhan,
                Tinhtranglamviec = entity.Tinhtranglamviec,
                MaDV_To = entity.MaDV_To,
                Machucvu = entity.Machucvu,
                Ngayvaolam = entity.Ngayvaolam,
                Thamnien = entity.Thamnien,
                Matinhoc = entity.Matinhoc,
                Mangoaingu = entity.Mangoaingu,
                Mabangcap = entity.Mabangcap,
                Matongiao = entity.Matongiao,
                Madantoc = entity.Madantoc

            };

            Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.UpdateTeacher", pa);
        }


        public IEnumerable<tblNhanvien> SearchByEmpID(int MaNV)
        {
            var pa = new
            {
                MaNV = MaNV
            };
            return Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.SearchEmpByID", pa).ToList();
        }

     
        public void Search(RadioButton raMaNV, RadioButton raTenNV, RadioButton raCMND, DataGridView dgv, TextBox search, Label notice)
        {
            if (string.IsNullOrEmpty(search.Text))
            {
                MessageBox.Show("Mời Nhập Từ Khóa Cần tìm!");
            }
            else
            {
                if (raMaNV.Checked)
                {
                    var pa = new
                    {
                        MaNV = search.Text
                    };
                    var data = Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.SearchEmpByID", pa);

                    notice.Text = "Kết Quả Tìm Thấy " + search.Text + " là :" + data.Count().ToString();
                    dgv.DataSource = data;
                }
                else if (raTenNV.Checked)
                {
                    var pa = new
                    {
                        Name = search.Text
                    };
                    var data = Helper.Query<tblNhanvien>(Helper.ConnectionString(), "SearchEmpByName", pa);
                    notice.Text = "Kết Quả Tìm Thấy " + search.Text + " là :" + data.Count().ToString();
                    dgv.DataSource = data;
                }
                else
                {
                    var pa = new
                    {
                        CMND = search.Text
                    };
                    var data = Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.SearchEmpByCMND", pa);
                    notice.Text = "Kết Quả Tìm Thấy " + search.Text + " là :" + data.Count().ToString();
                    dgv.DataSource = data;
                }
            }

        }

       
    }
}
