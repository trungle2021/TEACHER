﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;

namespace TEACHER.Repository
{
    public interface IDonvi
    {
        tblChucvu GetOne(int MaNV);
        IEnumerable<tblChucvu> GetAll();
        void Add(tblChucvu entity);
        void Remove(int MaDV);
        void Update(tblChucvu entity);
     
        IEnumerable<tblChucvu> SearchByName(string name);
        IEnumerable<tblChucvu> SearchByEmpID(int ID);
    }
}
