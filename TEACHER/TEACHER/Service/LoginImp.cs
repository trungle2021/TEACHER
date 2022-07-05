using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEACHER.Model;

namespace TEACHER.Service
{
    public class LoginImp : Repository.ILogin
    {
        public void ChangePass(tblNguoidung user)
        {
            var dp = new DynamicParameters();

            dp.Add("@Username", user.Username);
            dp.Add("@Pass", user.Pass);
            Helper.Query<tblNguoidung>(Helper.ConnectionString(), "QLGV.dbo.ChangePass", dp);

        }

        public bool CheckLogin(tblNguoidung user)
        {
            {
                var dp = new DynamicParameters();

                dp.Add("@Username", user.Username);

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
                catch (Exception)
                {

                    throw;
                }




            }
        }

        public void GetAllAccount(DataGridView dgv)
        {
            dgv.DataSource = Helper.Query<tblNguoidung>(Helper.ConnectionString(), "QLGV.dbo.GetAllUsername");
        }

        public void GetAllUserName(ComboBox cbb)
        {
            cbb.DataSource = Helper.Query<tblNguoidung>(Helper.ConnectionString(), "QLGV.dbo.GetAllUsername");
            cbb.DisplayMember = "Username";

        }

        public void newaccount(tblNguoidung user)
        {
            var dp = new DynamicParameters();

            dp.Add("@Username", user.Username);
            dp.Add("@Pass", user.Pass);
            Helper.Query<tblNguoidung>(Helper.ConnectionString(), "QLGV.dbo.AddAccount", dp);
        }


    }




}
