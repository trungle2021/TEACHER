using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;

namespace TEACHER.Repository
{
    public interface IDonVi_To
    {
        Donvi_tolamviec_junction GetAllToByMaDonVi(int MaNV);
        IEnumerable<Donvi_tolamviec_junction> GetAll();
        void Add(Donvi_tolamviec_junction entity);
        void Remove(int MaDV_To);
        void Update(Donvi_tolamviec_junction entity);
    }
}
