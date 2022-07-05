using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEACHER.Model;

namespace TEACHER.Repository
{
   public interface IHopdong
    {
        void GetAll(DataGridView dgv);
        void Add(tblHopdong entity);
        void Remove(TextBox MaHopDong);
        List<tblHopdong> GetOne(int MaNV);

        void Update(tblHopdong Hopdong);

         List<tblNhanvien> GetAllNhanVien();
        string GetTenNVfromMaNV(int Manv);

    }
}
