using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEACHER.Model;
using TEACHER.Repository;

namespace TEACHER.Service
{
   public class HopdongImp : Repository.IHopdong
    {

        
        public void Add(tblHopdong entity)
        {
            var dp = new DynamicParameters();

            dp.Add("@Mahopdong", entity.Mahopdong);
            dp.Add("@MaNV", entity.MaNV);
            dp.Add("@Ngaybatdau", entity.Ngaybatdau);
            dp.Add("@Ngayketthuc", entity.Ngayketthuc);
            dp.Add("@Lanky", entity.Lanky);
            dp.Add("@Noidung", entity.Noidung);
            dp.Add("@Ngayky", entity.Ngayky);
            dp.Add("@Tennguoiky", entity.Tennguoiky);
            dp.Add("@Ghichu", entity.Ghichu);
            Helper.Query<tblHopdong>(Helper.ConnectionString(), "QLGV.dbo.AddHopdong", dp);

        }

      
        public void GetAll(DataGridView dgv)
        {
            dgv.DataSource= Helper.Query<tblHopdong>(Helper.ConnectionString(), "QLGV.dbo.FindAllHopDong");
        }

        public List<tblHopdong> GetOne(int MaNV)
        {
            var dp = new DynamicParameters();
            dp.Add("@MaNV", MaNV);

            return Helper.Query<tblHopdong>(Helper.ConnectionString(), "QLGV.dbo.SearchHopDong",dp).ToList();
        }

        public void Remove(TextBox MaHopDong)
        {
            var dp = new DynamicParameters();

            dp.Add("@Mahopdong", MaHopDong.Text);

            Helper.Query<tblHopdong>(Helper.ConnectionString(),"QLGV.dbo.DeleteHopDong", dp);
        }

        public void Update(tblHopdong Hopdong)
        {
            var dp = new DynamicParameters();
            dp.Add("@Mahopdong", Hopdong.Mahopdong);
            dp.Add("@Ngaybatdau", Hopdong.Ngaybatdau);
            dp.Add("@Ngayketthuc", Hopdong.Ngayketthuc);
            dp.Add("@Lanky", Hopdong.Lanky);
            dp.Add("@Noidung", Hopdong.Noidung);
            dp.Add("@Ngayky", Hopdong.Ngayky);
            dp.Add("@Tennguoiky", Hopdong.Tennguoiky);
            dp.Add("@Ghichu", Hopdong.Ghichu);
            Helper.Query<tblHopdong>(Helper.ConnectionString(), "QLGV.dbo.UpdateHopDong", dp);
        }

    

        public List<tblNhanvien> GetAllNhanVien()
        {
            return Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.GetAllTeacher").ToList();
            //cbb.DisplayMember = "TenNV";
            //cbb.ValueMember = "Manv";

        }

     public string GetTenNVfromMaNV(int Manv) {
            var list=GetAllNhanVien();
            string result="Không Tồn Tại";
            foreach (var item in list)
            {
                if (item.Manv == Manv)
                {
                    result = item.TenNV;
                    break;
                }
               
            }
            return result;
        }

     
    }
}
