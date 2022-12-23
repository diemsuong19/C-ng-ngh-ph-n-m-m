using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCCUBH
{
    public partial class Frm_main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        
        public Frm_main()
        {
            InitializeComponent();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel Bonus = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            Bonus.LookAndFeel.SkinName = "Coffee";
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void loaihanghoa_Click(object sender, EventArgs e)
        {

            frm_loaihanghoa frm = new frm_loaihanghoa();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void hanghoa_Click(object sender, EventArgs e)
        {
            frm_Hanghoa frm = new frm_Hanghoa();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void nhacungcap_Click(object sender, EventArgs e)
        {
            frm_nhacungcap frm = new frm_nhacungcap();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void phieucungung_Click(object sender, EventArgs e)
        {
            frm_Phieucungung frm = new frm_Phieucungung();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void chitietphieucungung_Click(object sender, EventArgs e)
        {
            frm_Chitietphieucungung frm = new frm_Chitietphieucungung();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void khannang_Click(object sender, EventArgs e)
        {
            frm_Khanang frm = new frm_Khanang();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frm_trangchu main = new frm_trangchu();
                main.ShowDialog();
                this.Close();
                
            }
        }
    }
}
