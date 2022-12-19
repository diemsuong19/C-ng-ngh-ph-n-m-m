using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCCUBH
{
    public partial class QuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            labelKetQua.Text = "";
        }

        Modify modify = new Modify();

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string email = txtEmailDangKy.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "' ";
                if (modify.TaiKhoan(query).Count != 0)
                {
                    labelKetQua.ForeColor = Color.Green;
                    labelKetQua.Text = "Mật khẩu: " + modify.TaiKhoan(query)[0].MatKhau;
                }
                else
                {
                    labelKetQua.ForeColor = Color.Red;
                    labelKetQua.Text = "Email này chưa được đăng ký!";

                }
            }
        }
    }
}