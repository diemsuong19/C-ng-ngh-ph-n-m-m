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
            ComboMaHangHoa.DataSource = data.HANGHOAs.ToList();
        }
        void getNhaCungCap()
        {
            data = new QuanLyCuaHangEntities();
            ComboMaNhaCungCap.DataSource = data.NHACUNGCAPs.ToList();
        }
        void init()
        {
            ComboMaNhaCungCap.DisplayMember = "TenNhaCungCap";
            ComboMaNhaCungCap.ValueMember = "MaNhaCungCap";
            ComboMaHangHoa.DisplayMember = "TenHangHoa";
            ComboMaHangHoa.ValueMember = "MaHangHoa";
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
                    MaNhaCungCap = ComboMaNhaCungCap.SelectedValue.ToString(),
                    MaHangHoa = ComboMaHangHoa.SelectedValue.ToString(),
                    GhiChu = TxtGhiChu.Text.Trim()


                };
                data.KHANANGs.Add(k);
                data.SaveChanges();
                getData();
            }
            else
            {
                data = new QuanLyCuaHangEntities();
                var s = (from t in data.KHANANGs
                         where t.MaNhaCungCap == ComboMaNhaCungCap.Text
                         select t).SingleOrDefault();
                var khanang = data.KHANANGs.FirstOrDefault(x => x.MaNhaCungCap.Contains(ComboMaNhaCungCap.Text));
                khanang.MaHangHoa = ComboMaHangHoa.Text.Trim();
                khanang.GhiChu = TxtGhiChu.Text.Trim();

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
                         where t.MaNhaCungCap == ComboMaNhaCungCap.Text
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
            TxtGhiChu.ReadOnly = false;
            Delete.Enabled = false;
            TxtGhiChu.Clear();
        }

        private void frm_dskhanang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = frm_dskhanang.Rows[e.RowIndex];
                ComboMaNhaCungCap.Text = row.Cells[1].Value.ToString();
                ComboMaHangHoa.Text = row.Cells[2].Value.ToString();
                TxtGhiChu.Text = row.Cells[3].Value.ToString();
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