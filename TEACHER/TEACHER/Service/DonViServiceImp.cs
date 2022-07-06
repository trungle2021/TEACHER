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
          return  Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.FindAllDonvi").ToList();
        }
        
        public tblDSDonvi GetOne(int MaDV)
        {
            var pa = new
            {
                MaDV = MaDV
            };
          return Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.GetOneDonvi",pa).FirstOrDefault();

        }

        public void Remove(int MaDV)
        {
            var pa = new
            {
                MaDV = MaDV
            };
            Helper.Query<tblDSDonvi>(Helper.ConnectionString(), "QLGV.dbo.GetOneDonvi", pa);
        }
      

        public IEnumerable<tblDSDonvi> SearchByEmpID(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblDSDonvi> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(tblDSDonvi entity)
        {
            throw new NotImplementedException();
        }
    }
}
