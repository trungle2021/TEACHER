using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;
using TEACHER.Repository;

namespace TEACHER.Service
{
    public class ChucVuServiceImp : IChucVu
    {
        public void Add(tblChucvu entity)
        {
            var pa = new
            {
                Machucvu= entity.Machucvu,
                Tenchucvu=entity.Tenchucvu,
                Hesochucvu=entity.Hesochucvu,
                Ghichu =entity.Ghichu
            };

            Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.AddChucVu", pa);
        }

        public IEnumerable<tblChucvu> GetAll()
        {
          return  Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.GetAllChucVu").ToList();
        }
        
        public tblChucvu GetOne(string Machucvu)
        {
            var pa = new
            {
                Machucvu = Machucvu
            };
          return Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.GetOneChucVu", pa).FirstOrDefault();

        }

        public void Remove(string Machucvu)
        {
            var pa = new
            {
                Machucvu = Machucvu
            };
            Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.GetOneDonvi", pa);
        }

        public void Update(tblChucvu entity)
        {
            var pa = new
            {
                Machucvu = entity.Machucvu,
                Tenchucvu = entity.Tenchucvu,
                Hesochucvu = entity.Hesochucvu,
                Ghichu = entity.Ghichu
            };

            Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.UpdateChucVu", pa);
        }
    }
}
