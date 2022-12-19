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
    public partial class frm_Khanang : DevExpress.XtraEditors.XtraForm
    {
        QuanLyCuaHangEntities data;
        bool action = false;
        public frm_Khanang()
        {
            InitializeComponent();
        }

        private void frm_Khanang_Load(object sender, EventArgs e)
        {
            getData();
            getHangHoa();
            getNhaCungCap();
            init();
        }
        void getHangHoa()
        {
            data = new QuanLyCuaHangEntities();
            combomahanghoa.DataSource = data.HANGHOAs.ToList();
        }
        void getNhaCungCap()
        {
            data = new QuanLyCuaHangEntities();
            combomanhacungcap.DataSource = data.NHACUNGCAPs.ToList();
        }
        void init()
        {
            combomanhacungcap.DisplayMember = "TenNhaCungCap";
            combomanhacungcap.ValueMember = "MaNhaCungCap";
            combomahanghoa.DisplayMember = "TenHangHoa";
            combomahanghoa.ValueMember = "MaHangHoa";
        }
        void getData()
        {
            data = new QuanLyCuaHangEntities();
            int i = 0;
            List<KHANANG> lstKhaNang = data.KHANANGs.ToList();
            var columns = from t in lstKhaNang
                          select new
                          {
                              stt = ++i,
                              MANHACUNGCAP = t.NHACUNGCAP.TenNhaCungCap,
                              MAHANGHOA = t.HANGHOA.TenHangHoa,
                              GHICHU = t.GhiChu


                          };
            frm_dskhanang.DataSource = columns.ToList();
        }

        private void Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (action == false)
            {
                data = new QuanLyCuaHangEntities();
                var k = new KHANANG
                {
                    MaNhaCungCap = combomanhacungcap.SelectedValue.ToString(),
                    MaHangHoa = combomahanghoa.SelectedValue.ToString(),
                    GhiChu = txtghichu.Text.Trim()


                };
                data.KHANANGs.Add(k);
                data.SaveChanges();
                getData();
            }
            else
            {
                data = new QuanLyCuaHangEntities();
                var s = (from t in data.KHANANGs
                         where t.MaNhaCungCap == combomanhacungcap.Text
                         select t).SingleOrDefault();
                var khanang = data.KHANANGs.FirstOrDefault(x => x.MaNhaCungCap.Contains(combomanhacungcap.Text));
                khanang.MaHangHoa = combomahanghoa.Text.Trim();
                khanang.GhiChu = txtghichu.Text.Trim();

                data.SaveChanges();
                getData();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QuanLyCuaHangEntities();
            if (MessageBox.Show("Are you sure ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.KHANANGs
                         where t.MaNhaCungCap == combomanhacungcap.Text
                         select t
                    ).SingleOrDefault();
                data.KHANANGs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = false;
            txtghichu.ReadOnly = false;
            Delete.Enabled = false;
            txtghichu.Clear();
        }

        private void frm_dskhanang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = frm_dskhanang.Rows[e.RowIndex];
                combomanhacungcap.Text = row.Cells[1].Value.ToString();
                combomahanghoa.Text = row.Cells[2].Value.ToString();
                txtghichu.Text = row.Cells[3].Value.ToString();
                Delete.Enabled = true;
                action = true;

            }
        }

        private void Exist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}