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

        void Add(tblDSDonvi entity);

       IEnumerable<tblDSDonvi> GetAll();


       tblDSDonvi GetOne(string MaDV);


         void Remove(string MaDV);

        void Update(tblDSDonvi entity);

        List<tblTolamviec> SearchToFromDonvi(string MaDV);

    }
}
