using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;
using TEACHER.Repository;

namespace TEACHER.Service
{
    public class DonViServiceImp : IDonVi
    {
        public void Add(tblDSDonvi entity)
        {
            var pa = new
            {
                MaDV= entity.MaDV,
                TenDV=entity.TenDV,
                Ghichu=entity.Ghichu,

            };

            Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.AddDonvi", pa);
        }

        public IEnumerable<tblDSDonvi> GetAll()
        {
          return  Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.FindAllDonvi");
        }
        
        public tblDSDonvi GetOne(string MaDV)
        {
            var pa = new
            {
                MaDV = MaDV
            };
          return Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.SearchDonvi",pa).FirstOrDefault();

        }

        public void Remove(string MaDV)
        {
            var pa = new
            {
                MaDV = MaDV
            };
            Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.DeleteDonvi", pa);
        }

        public List<tblTolamviec> SearchToFromDonvi(string MaDV)
        {
            var pa = new
            {
                MaDV = MaDV
            };

         return  Helper.Query<tblTolamviec>(Helper.ConnectionString(), "QLGV.dbo.SearchToFromDonvi", pa).ToList();
        }
        
        public void Update(tblDSDonvi entity)
        {
            var pa = new
            {
                MaDV = entity.MaDV,
                TenDV = entity.TenDV,
                Ghichu = entity.Ghichu

            };

            Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.UpdateDonvi", pa);
        }
    }
}
