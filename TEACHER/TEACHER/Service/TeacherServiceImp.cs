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

        public IEnumerable<tblNhanvien> GetAll()
        {

            return Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.GetAllTeacher").ToList();
            
            
        }

        public void Add(tblNhanvien entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(tblNhanvien entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<tblNhanvien> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(tblNhanvien teacher)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblNhanvien> SearchByCMND(string cmnd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblNhanvien> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblNhanvien> SearchByEmpID(int MaNV)
        {
            var pa = new
            {
                MaNV = MaNV
            };
            return Helper.Query<tblNhanvien>(Helper.ConnectionString(), "QLGV.dbo.SearchEmpByID", pa).ToList();
        }

        
    }
}
