using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;

namespace TEACHER.Repository
{
    public interface IChucVu
    {
        tblChucvu GetOne(string Machucvu);
        IEnumerable<tblChucvu> GetAll();
        void Add(tblChucvu entity);
        void Remove(string Machucvu);
        void Update(tblChucvu entity);
    }
}
