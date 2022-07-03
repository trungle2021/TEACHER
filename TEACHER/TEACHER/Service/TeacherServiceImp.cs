using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Data;
using TEACHER.Model;
using TEACHER.Repository;

namespace TEACHER.Service
{
    public class TeacherServiceImp : ITeacher
    {
      
        public tblNhanvien GetOne(int MaNV)
        {
            using(var db = new QLGVEntities())
            {
                return db.tblNhanviens.FirstOrDefault(t => t.Manv.Equals(MaNV));
            }
        }

        public IEnumerable<tblNhanvien> GetAll()
        {
            using (QLGVEntities db = new QLGVEntities())
            {

                return db.tblNhanviens.Include("tblDSDonvi").Include("tblTolamviec").ToList();
            }
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

        public tblNhanvien SearchByCMND(string cmnd)
        {
            throw new NotImplementedException();
        }

        public tblNhanvien SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public tblNhanvien SearchByEmpID(int ID)
        {
            throw new NotImplementedException();
        }

        //public TeacherServiceImp()
        //{
        //    _connection = connect.setConnect();
        //}

        //public tblNhanvien SearchByCMND(string cmnd)
        //{
        //    throw new NotImplementedException();
        //}

        //public tblNhanvien SearchByEmpID(int ID)
        //{
        //    throw new NotImplementedException();
        //}

        //public tblNhanvien SearchByName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(tblNhanvien teacher)
        //{
        //    var _teacher = _db.tblNhanviens.FirstOrDefault(t => t.Manv.Equals(teacher.Manv));
        //    if(_teacher != null)
        //    {
        //        _db.Entry(teacher).State = EntityState.Modified;
        //        _db.SaveChangesAsync();
        //    }
        //}

        //public tblNhanvien GetFirstOrDefault(Expression<Func<tblNhanvien, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<tblNhanvien> GetAll()
        //{
        //    return _db.tblNhanviens.ToList();
        //}

        //public void Add(tblNhanvien entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(tblNhanvien entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRange(IEnumerable<tblNhanvien> entities)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
