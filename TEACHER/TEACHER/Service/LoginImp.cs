using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEACHER.Model;

namespace TEACHER.Service
{
   public class LoginImp : Repository.ILogin
    {

       

        public bool CheckLogin(tblNguoidung user)
        {
            {
                var dp = new DynamicParameters();

                dp.Add("@Username",user.Username);

                try
                {
                    var confirmAccount = Helper.Query<tblNguoidung>(Helper.ConnectionString(), "QLGV.dbo.getAccount", dp);

                    if (confirmAccount.Count() == 0) { return false; }
                    else if (confirmAccount.FirstOrDefault().Pass != user.Pass) { return false; }
                    else
                    {
                        return true;

                    }
                }
                catch (Exception ex)
                {

                    throw;
                }

               

                
            }
        }
    }




}
