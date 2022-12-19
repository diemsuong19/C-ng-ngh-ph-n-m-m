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
            if (action == false)
            {
                data = new QuanLyCuaHangEntities();
                var k = new NHACUNGCAP
                {
                    MaNhaCungCap = txtMaNhaCungCap.Text.Trim(),
                    TenNhaCungCap = txtTenNhaCungCap.Text.Trim(),
                    DiaChi = txtDiachi.Text.Trim(),
                    GhiChu = txtGhiChu.Text.Trim(),
                    DienThoai = int.Parse(txtDienthoai.Text.Trim()),
                    MaTaiKhoan = txtMaTaiKhoan.Text.Trim(),
                    KhuVuc = txtKhuVuc.Text.Trim(),
                };
                data.NHACUNGCAPs.Add(k);
                data.SaveChanges();
                getData();
            }
            else
            {
                data = new QuanLyCuaHangEntities();
                var s = (from t in data.NHACUNGCAPs
                         where t.MaNhaCungCap == txtMaNhaCungCap.Text
                         select t).SingleOrDefault();
                var nhacungcap = data.NHACUNGCAPs.FirstOrDefault(x => x.MaNhaCungCap.Contains(txtMaNhaCungCap.Text));
                nhacungcap.TenNhaCungCap = txtTenNhaCungCap.Text.Trim();
                nhacungcap.DiaChi = txtDiachi.Text.Trim();
                nhacungcap.GhiChu = txtGhiChu.Text.Trim();
                nhacungcap.DienThoai = int.Parse(txtDienthoai.Text.Trim());
                nhacungcap.MaTaiKhoan = txtMaTaiKhoan.Text.Trim();
                nhacungcap.KhuVuc = txtKhuVuc.Text.Trim();
                data.SaveChanges();
                getData();
            }
        }

        private void Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QuanLyCuaHangEntities();
            if (MessageBox.Show("Are you sure ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.NHACUNGCAPs
                         where t.MaNhaCungCap == txtMaNhaCungCap.Text
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
            txtMaNhaCungCap.ReadOnly = false;
            Delete.Enabled = false;
            txtMaNhaCungCap.Clear();
            txtTenNhaCungCap.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            txtMaTaiKhoan.Clear();
            txtKhuVuc.Clear();
            txtGhiChu.Clear();
        }

        private void datanhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datanhacungcap.Rows[e.RowIndex];
                txtMaNhaCungCap.Text = row.Cells[1].Value.ToString();
                txtTenNhaCungCap.Text = row.Cells[2].Value.ToString();
                txtDiachi.Text = row.Cells[3].Value.ToString();
                txtDienthoai.Text = row.Cells[4].Value.ToString();
                txtMaTaiKhoan.Text = row.Cells[5].Value.ToString();
                txtKhuVuc.Text = row.Cells[6].Value.ToString();
                txtGhiChu.Text = row.Cells[7].Value.ToString();
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