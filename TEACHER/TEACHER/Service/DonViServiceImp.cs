using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;
using TEACHER.Repository;

namespace TEACHER.Service
{
    public class DonViServiceImp : IChucVu
    {
        public void Add(tblChucvu entity)
        {
            var pa = new
            {
                MaDV= entity.MaDV,
                TenDV=entity.TenDV,
                Ghichu=entity.Ghichu,

            };

            Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.AddDonvi", pa);
        }

        public IEnumerable<tblChucvu> GetAll()
        {
          return  Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.FindAllDonvi").ToList();
        }
        
        public tblChucvu GetOne(int MaDV)
        {
            var pa = new
            {
                MaDV = MaDV
            };
          return Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.GetOneDonvi",pa).FirstOrDefault();

        }

        public void Remove(int MaDV)
        {
            var pa = new
            {
                MaDV = MaDV
            };
            Helper.Query<tblChucvu>(Helper.ConnectionString(), "QLGV.dbo.GetOneDonvi", pa);
        }
      

        public IEnumerable<tblChucvu> SearchByEmpID(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblChucvu> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(tblChucvu entity)
        {
            throw new NotImplementedException();
        }
    }
}
