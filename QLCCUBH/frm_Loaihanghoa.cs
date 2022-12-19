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
    public partial class frm_loaihanghoa : DevExpress.XtraEditors.XtraForm
    {
        QuanLyCuaHangEntities data;
        bool action = false;
        public frm_loaihanghoa()
        {
            InitializeComponent();
        }

        private void frm_loaihanghoa_Load(object sender, EventArgs e)
        {
            getData();

        }
        void getData()
        {
            data = new QuanLyCuaHangEntities();
            List<LOAIHANGHOA> lst = data.LOAIHANGHOAs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        MaLoaiHangHoa = t.MaLoaiHangHoa,
                        TenHangHoa = t.TenHangHoa,
                        GhiChu = t.GhiChu
                    };
            frmloaihanghoa.DataSource = v.ToList();

        }

        

        private void barButtonsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (action == false)
            {

                var k = new LOAIHANGHOA
                {
                    MaLoaiHangHoa = textmaloaihanghoa.Text.Trim(),
                    TenHangHoa = texttenloaihanghoa.Text.Trim(),
                    GhiChu = textghichu.Text.Trim(),
                };
                data.LOAIHANGHOAs.Add(k);
                data.SaveChanges();
                getData();
            }
            else
            {
                data = new QuanLyCuaHangEntities();
                var s = (from t in data.LOAIHANGHOAs
                         where t.MaLoaiHangHoa == textmaloaihanghoa.Text
                         select t).SingleOrDefault();
                var loaihanghoa = data.LOAIHANGHOAs.FirstOrDefault(x => x.MaLoaiHangHoa.Contains(textmaloaihanghoa.Text));
                loaihanghoa.TenHangHoa = texttenloaihanghoa.Text.Trim();
                loaihanghoa.GhiChu = textghichu.Text.Trim();

                data.SaveChanges();
                getData();
            }

        }

        private void barButtondelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QuanLyCuaHangEntities();
            if (MessageBox.Show("Are you sure ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.LOAIHANGHOAs
                         where t.MaLoaiHangHoa == textmaloaihanghoa.Text
                         select t
                    ).SingleOrDefault();
                data.LOAIHANGHOAs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void barButtoncancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = false;
            textmaloaihanghoa.ReadOnly = false;
            barButtondelete.Enabled = false;
            textmaloaihanghoa.Clear();
            texttenloaihanghoa.Clear();
            textghichu.Clear();
        }

        private void frmloaihanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = frmloaihanghoa.Rows[e.RowIndex];
                textmaloaihanghoa.Text = row.Cells[1].Value.ToString();
                texttenloaihanghoa.Text = row.Cells[2].Value.ToString();
                textghichu.Text = row.Cells[3].Value.ToString();
                barButtondelete.Enabled = true;
                action = true;

            }
        }


        private void barButtonExist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}