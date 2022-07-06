using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;

namespace TEACHER.Repository
{
    public interface IDonVi
    {
        tblDSDonvi GetOne(int MaNV);
        IEnumerable<tblDSDonvi> GetAll();
        void Add(tblDSDonvi entity);
        void Remove(int MaDV);
        void Update(tblDSDonvi entity);
     
        IEnumerable<tblDSDonvi> SearchByName(string name);
        IEnumerable<tblDSDonvi> SearchByEmpID(int ID);
    }
}
