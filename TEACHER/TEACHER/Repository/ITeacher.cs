using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;
using System.Windows.Forms;


namespace TEACHER.Repository
{
    public interface ITeacher 
    {
        tblNhanvien GetOne(int MaNV);
        IEnumerable<AllField> GetAll();
        void Add(tblNhanvien entity);
        void Remove(int MaNV);
        void Update(tblNhanvien entity);
      
        IEnumerable<AllField> SearchByEmpID(int ID);

        void Search(RadioButton raMaNV, RadioButton raTenNV, RadioButton raCMND, DataGridView dgv, TextBox search, Label notice);
    }
}
