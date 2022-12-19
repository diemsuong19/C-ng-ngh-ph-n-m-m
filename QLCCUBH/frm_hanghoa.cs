using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frm_hanghoa : DevExpress.XtraEditors.XtraForm
    {
        QuanLyCuaHangEntities data;
        bool action = false;
        public frm_hanghoa()
        {
            InitializeComponent();
        }

        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            
            init();
            getData();
            getLoaiHangHoa();
        }
        void getData()
        {
            data = new QuanLyCuaHangEntities();
            int i = 0;
            List<HANGHOA> lstHangHoa = data.HANGHOAs.ToList();
            var columns = from t in lstHangHoa
                          select new
                          {
                              stt = ++i,
                              MAHANGHOA = t.MaHangHoa,
                              TENHANGHOA = t.TenHangHoa,
                              QUYCACH = t.QuyCach,
                              DONVITINH = t.DonViTinh,
                              DONGIA = t.DonGia,
                              LOAIHANGHOA = t.LOAIHANGHOA.TenHangHoa
                          };
            frm_dshanghoa.DataSource = columns.ToList();
        }
        void getLoaiHangHoa()
        {
            data = new QuanLyCuaHangEntities();
            combomaloaihanghoa.DataSource = data.LOAIHANGHOAs.ToList();
        }
        void init()
        {
            combomaloaihanghoa.DisplayMember = "TenHangHoa";
            combomaloaihanghoa.ValueMember = "MaLoaiHangHoa";
        }
        private void Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (action == false)
            {
                data = new QuanLyCuaHangEntities();
                var k = new HANGHOA
                {
                    MaHangHoa = txtmahanghoa.Text.Trim(),
                    TenHangHoa = txttenhanghoa.Text.Trim(),
                    QuyCach = txtquycach.Text.Trim(),
                    DonViTinh = txtdonvitinh.Text.Trim(),
                    DonGia = int.Parse(txtdongia.Text.Trim()),
                    MaLoaiHangHoa = combomaloaihanghoa.SelectedValue.ToString(),
                };
                data.HANGHOAs.Add(k);
                data.SaveChanges();
                getData();
            }
            else
            {
                data = new QuanLyCuaHangEntities();
                var s = (from t in data.HANGHOAs
                         where t.MaHangHoa == txtmahanghoa.Text
                         select t).SingleOrDefault();
                var hanghoa = data.HANGHOAs.FirstOrDefault(x => x.MaHangHoa.Contains(txtmahanghoa.Text));
                hanghoa.TenHangHoa = txttenhanghoa.Text.Trim();
                hanghoa.QuyCach = txtquycach.Text.Trim();
                hanghoa.DonViTinh = txtdonvitinh.Text.Trim();
                hanghoa.DonGia = int.Parse(txtdongia.Text.Trim());
                hanghoa.MaLoaiHangHoa = combomaloaihanghoa.SelectedValue.ToString();
                data.SaveChanges();
                getData();
            }
        }

        private void Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QuanLyCuaHangEntities();
            if (MessageBox.Show("Are you sure ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.HANGHOAs
                         where t.MaHangHoa == txtmahanghoa.Text
                         select t
                    ).SingleOrDefault();
                data.HANGHOAs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = false;
            txtmahanghoa.ReadOnly = false;
            Delete.Enabled = false;
            txtmahanghoa.Clear();
            txttenhanghoa.Clear();
            txtquycach.Clear();
            txtdonvitinh.Clear();
            txtdongia.Clear();
        }

        private void Exist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frm_dshanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = frm_dshanghoa.Rows[e.RowIndex];
                txtmahanghoa.Text = row.Cells[1].Value.ToString();
                txttenhanghoa.Text = row.Cells[2].Value.ToString();
                txtquycach.Text = row.Cells[3].Value.ToString();
                txtdonvitinh.Text = row.Cells[4].Value.ToString();
                txtdongia.Text = row.Cells[5].Value.ToString();
                combomaloaihanghoa.Text = row.Cells[6].Value.ToString();
                Delete.Enabled = true;
                action = true;

            }
        }
    }
}