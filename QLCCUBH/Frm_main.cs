using DevExpress.XtraBars;
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
    public partial class Frm_main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        bool isThoat = true;

        public Frm_main()
        {
            InitializeComponent();
        }


        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }
        private void frm_loaihanghoa_Click(object sender, EventArgs e)
        {
            frm_loaihanghoa frm = new frm_loaihanghoa();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frm_hanghoa_Click(object sender, EventArgs e)
        {
            frm_hanghoa frm = new frm_hanghoa();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frm_nhacungcap_Click(object sender, EventArgs e)
        {
            frm_nhacungcap frm = new frm_nhacungcap();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frm_phieucungung_Click(object sender, EventArgs e)
        {
            frm_Phieucungung frm = new frm_Phieucungung();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frm_khanang_Click(object sender, EventArgs e)
        {
            frm_Khanang frm = new frm_Khanang();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frm_chitietphieucungung_Click(object sender, EventArgs e)
        {
            frm_Chitietphieucungung frm = new frm_Chitietphieucungung();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                TrangChu trangChu = new TrangChu();
                trangChu.ShowDialog();
            }

        }


    }
}
