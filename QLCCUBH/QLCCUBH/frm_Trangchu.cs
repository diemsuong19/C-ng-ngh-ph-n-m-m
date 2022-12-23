using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCCUBH
{
    public partial class frm_trangchu : DevExpress.XtraEditors.XtraForm
    {
        bool IsDone = false;
        public frm_trangchu()
        {
            InitializeComponent();
        }
            
        private void button_login_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == string.Empty)
            {
                TxtUsername.Select();
                return;
            }
            if (TxtPassword.Text == string.Empty)
            {
                TxtPassword.Select();
                return;
            }
            IsDone = TxtUsername.Text != string.Empty && TxtUsername.Text == "Admin" &&
                TxtPassword.Text != string.Empty && TxtPassword.Text == "admin" ? true : false;
            if (!IsDone)
            {
                XtraMessageBox.Show("Error in your information", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Frm_main main = new Frm_main();
            main.ShowDialog();
            this.Close();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}