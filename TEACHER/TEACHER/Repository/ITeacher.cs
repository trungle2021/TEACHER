using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;


namespace TEACHER.Repository
{
    public interface ITeacher 
    {
        tblNhanvien GetOne(int MaNV);
        IEnumerable<AllField> GetAll();
        void Add(tblNhanvien entity);
        void Remove(int MaNV);
        void Update(tblNhanvien entity); 
        IEnumerable<tblNhanvien> SearchByCMND(string cmnd);
        IEnumerable<tblNhanvien> SearchByName(string name);
        IEnumerable<tblNhanvien> SearchByEmpID(int ID);
    }
}
