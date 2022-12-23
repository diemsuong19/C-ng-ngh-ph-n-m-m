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
    public partial class frm_Hanghoa : DevExpress.XtraEditors.XtraForm
    {
        QuanLyCuaHangEntities data;
        bool action = false;
        public frm_Hanghoa()
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
            ComboMaLoaiHangHoa.DataSource = data.LOAIHANGHOAs.ToList();
        }
        void init()
        {
            ComboMaLoaiHangHoa.DisplayMember = "TenHangHoa";
            ComboMaLoaiHangHoa.ValueMember = "MaLoaiHangHoa";
        }
        private void Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (int.Parse(TxtDonGia.Text.Trim()) < 0)
            {
                MessageBox.Show("Số tiền không thể âm", "Thông báo");
            }
            else
            {
                if (action == false)
                {
                    data = new QuanLyCuaHangEntities();
                    var k = new HANGHOA
                    {
                        MaHangHoa = TxtMaHangHoa.Text.Trim(),
                        TenHangHoa = TxtTenHangHoa.Text.Trim(),
                        QuyCach = TxtQuyCach.Text.Trim(),
                        DonViTinh = TxtDonViTinh.Text.Trim(),
                        DonGia = int.Parse(TxtDonGia.Text.Trim()),
                        MaLoaiHangHoa = ComboMaLoaiHangHoa.SelectedValue.ToString(),
                    };
                    data.HANGHOAs.Add(k);
                    data.SaveChanges();
                    getData();
                }
                else
                {
                    data = new QuanLyCuaHangEntities();
                    var s = (from t in data.HANGHOAs
                             where t.MaHangHoa == TxtMaHangHoa.Text
                             select t).SingleOrDefault();
                    var hanghoa = data.HANGHOAs.FirstOrDefault(x => x.MaHangHoa.Contains(TxtMaHangHoa.Text));
                    hanghoa.TenHangHoa = TxtTenHangHoa.Text.Trim();
                    hanghoa.QuyCach = TxtQuyCach.Text.Trim();
                    hanghoa.DonViTinh = TxtDonViTinh.Text.Trim();
                    hanghoa.DonGia = int.Parse(TxtDonGia.Text.Trim());
                    hanghoa.MaLoaiHangHoa = ComboMaLoaiHangHoa.SelectedValue.ToString();
                    data.SaveChanges();
                    getData();
                }
            }
        }

        private void Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QuanLyCuaHangEntities();
            if (MessageBox.Show("Are you sure ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.HANGHOAs
                         where t.MaHangHoa == TxtMaHangHoa.Text
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
            TxtMaHangHoa.ReadOnly = false;
            DeleteHangHoa.Enabled = false;
            TxtMaHangHoa.Clear();
            TxtTenHangHoa.Clear();
            TxtQuyCach.Clear();
            TxtDonViTinh.Clear();
            TxtDonGia.Clear();
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
                TxtMaHangHoa.Text = row.Cells[1].Value.ToString();
                TxtTenHangHoa.Text = row.Cells[2].Value.ToString();
                TxtQuyCach.Text = row.Cells[3].Value.ToString();
                TxtDonViTinh.Text = row.Cells[4].Value.ToString();
                TxtDonGia.Text = row.Cells[5].Value.ToString();
                ComboMaLoaiHangHoa.Text = row.Cells[6].Value.ToString();
                DeleteHangHoa.Enabled = true;
                action = true;

            }
        }

        
    }
}