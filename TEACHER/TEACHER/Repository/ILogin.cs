﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEACHER.Model;

namespace TEACHER.Repository
{
  public  interface ILogin
    {

        bool CheckLogin(tblNguoidung user);
        
    
    }

}