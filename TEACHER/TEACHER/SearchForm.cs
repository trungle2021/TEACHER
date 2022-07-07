using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEACHER
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        Service.TeacherServiceImp service = new Service.TeacherServiceImp();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                service.Search(radioMaNV, radioTenNV, radioCMND, dataGridView1, txtSearch, lblNotice);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
