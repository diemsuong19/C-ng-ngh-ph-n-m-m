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
    public partial class frm_nhacungcap : DevExpress.XtraEditors.XtraForm
    {
        QuanLyCuaHangEntities data;
        bool action = false;
        public frm_nhacungcap()
        {
            InitializeComponent();
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            getData();
        }
        void getData()
        {
            data = new QuanLyCuaHangEntities();
            int i = 0;
            List<NHACUNGCAP> lstNhaCungCap = data.NHACUNGCAPs.ToList();
            var columns = from t in lstNhaCungCap
                          select new
                          {
                              stt = ++i,
                              MANHACUNGCAP = t.MaNhaCungCap,
                              TENNHACUNGCAP = t.TenNhaCungCap,
                              DIACHI = t.DiaChi,
                              DIENTHOAI = t.DienThoai,
                              MATAIKHOAN = t.MaTaiKhoan,
                              KHUVUC = t.KhuVuc,
                              GHICHU = t.GhiChu
                          };
            datanhacungcap.DataSource = columns.ToList();
        }

        private void save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (int.Parse(TxtDienThoai.Text.Trim())<100000000)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
            }
            else
            {

                if (action == false)
                {
                    data = new QuanLyCuaHangEntities();
                    var k = new NHACUNGCAP
                    {
                        MaNhaCungCap = TxtMaNhaCungCap.Text.Trim(),
                        TenNhaCungCap = TxtTenNhaCungCap.Text.Trim(),
                        DiaChi = TxtDiaChi.Text.Trim(),
                        GhiChu = TxtGhiChu.Text.Trim(),
                        DienThoai = int.Parse(TxtDienThoai.Text.Trim()),
                        MaTaiKhoan = TxtMaTaiKhoan.Text.Trim(),
                        KhuVuc = TxtKhuVuc.Text.Trim(),
                    };
                    data.NHACUNGCAPs.Add(k);
                    data.SaveChanges();
                    getData();
                }
                else
                {
                    data = new QuanLyCuaHangEntities();
                    var s = (from t in data.NHACUNGCAPs
                             where t.MaNhaCungCap == TxtMaNhaCungCap.Text
                             select t).SingleOrDefault();
                    var nhacungcap = data.NHACUNGCAPs.FirstOrDefault(x => x.MaNhaCungCap.Contains(TxtMaNhaCungCap.Text));
                    nhacungcap.TenNhaCungCap = TxtTenNhaCungCap.Text.Trim();
                    nhacungcap.DiaChi = TxtDiaChi.Text.Trim();
                    nhacungcap.GhiChu = TxtGhiChu.Text.Trim();
                    nhacungcap.DienThoai = int.Parse(TxtDienThoai.Text.Trim());
                    nhacungcap.MaTaiKhoan = TxtMaTaiKhoan.Text.Trim();
                    nhacungcap.KhuVuc = TxtKhuVuc.Text.Trim();
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
                var s = (from t in data.NHACUNGCAPs
                         where t.MaNhaCungCap == TxtMaNhaCungCap.Text
                         select t
                    ).SingleOrDefault();
                data.NHACUNGCAPs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = false;
            TxtMaNhaCungCap.ReadOnly = false;
            DeleteNhaCungCap.Enabled = false;
            TxtMaNhaCungCap.Clear();
            TxtTenNhaCungCap.Clear();
            TxtDiaChi.Clear();
            TxtDienThoai.Clear();
            TxtMaTaiKhoan.Clear();
            TxtKhuVuc.Clear();
            TxtGhiChu.Clear();
        }

        private void datanhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datanhacungcap.Rows[e.RowIndex];
                TxtMaNhaCungCap.Text = row.Cells[1].Value.ToString();
                TxtTenNhaCungCap.Text = row.Cells[2].Value.ToString();
                TxtDiaChi.Text = row.Cells[3].Value.ToString();
                TxtDienThoai.Text = row.Cells[4].Value.ToString();
                TxtMaTaiKhoan.Text = row.Cells[5].Value.ToString();
                TxtKhuVuc.Text = row.Cells[6].Value.ToString();
                TxtGhiChu.Text = row.Cells[7].Value.ToString();
                DeleteNhaCungCap.Enabled = true;
                action = true;

            }

        }

        private void Exist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}