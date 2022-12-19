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
    public partial class frm_Chitietphieucungung : DevExpress.XtraEditors.XtraForm
    {
        QuanLyCuaHangEntities data;
        bool action = false;
        public frm_Chitietphieucungung()
        {
            InitializeComponent();
        }
        private void frm_Chitietphieucungung_Load(object sender, EventArgs e)
        {
            getData();
            getHangHoa();
            getPhieuCungUng();
            init();
        }
        void init()
        {
            combomahanghoa.DisplayMember = "TenHangHoa";
            combomahanghoa.ValueMember = "MaHangHoa";
            combosophieu.DisplayMember = "SoPhieu";
            combosophieu.ValueMember = "SoPhieu";
        }
        void getData()
        {
            data = new QuanLyCuaHangEntities();
            int i = 0;
            List<CHITIETCUNGUNG> lstChiTietCungUng = data.CHITIETCUNGUNGs.ToList();
            var columns = from t in lstChiTietCungUng
                          select new
                          {
                              stt = ++i,
                              SOPHIEU = t.PHIEUCUNGUNG.SoPhieu,
                              MAHANGHOA = t.HANGHOA.MaHangHoa,
                              SOLUONG = t.SoLuong,
                              THANHTIEN = t.ThanhTien


                          };
            frm_chitietcungung.DataSource = columns.ToList();
        }

        void getHangHoa()
        {
            data = new QuanLyCuaHangEntities();
            combomahanghoa.DataSource = data.HANGHOAs.ToList();
        }
        void getPhieuCungUng()
        {
            data = new QuanLyCuaHangEntities();
            combosophieu.DataSource = data.PHIEUCUNGUNGs.ToList();
        }
        private void barButtonsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (action == false)
            {
                if (int.Parse(txtthanhtien.Text.Trim()) < 0)
                {
                    MessageBox.Show("Số tiền không thể âm", "Thông báo");
                }
                else
                if (int.Parse(txtsoluong.Text.Trim()) <= 0)
                {
                    MessageBox.Show("Số lượng lớn hơn 0", "Thông báo");
                }
                else
                {
                    var k = new CHITIETCUNGUNG
                    {
                        SoPhieu = combosophieu.SelectedValue.ToString(),
                        MaHangHoa = combomahanghoa.SelectedValue.ToString(),
                        SoLuong = int.Parse(txtsoluong.Text.Trim()),
                        ThanhTien = int.Parse(txtthanhtien.Text.Trim()),


                    };
                    data.CHITIETCUNGUNGs.Add(k);
                    data.SaveChanges();
                    getData();
                }
            }
            else
            {
                data = new QuanLyCuaHangEntities();
                var s = (from t in data.CHITIETCUNGUNGs
                         where t.SoPhieu == combosophieu.Text
                         select t).SingleOrDefault();
                var chitietcungung = data.CHITIETCUNGUNGs.FirstOrDefault(x => x.SoPhieu.Contains(combosophieu.Text));
                chitietcungung.MaHangHoa = combomahanghoa.Text.Trim();
                chitietcungung.SoLuong = int.Parse(txtsoluong.Text.Trim());
                chitietcungung.ThanhTien = int.Parse(txtthanhtien.Text.Trim());
                data.SaveChanges();
                getData();
            }
        }

        private void barButtondelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QuanLyCuaHangEntities();
            if (MessageBox.Show("Are you sure ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.CHITIETCUNGUNGs
                         where t.MaHangHoa == combomahanghoa.Text
                         select t
                    ).SingleOrDefault();
                data.CHITIETCUNGUNGs.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void frm_chitietcungung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = frm_chitietcungung.Rows[e.RowIndex];
                combosophieu.Text = row.Cells[1].Value.ToString();
                combomahanghoa.Text = row.Cells[2].Value.ToString();
                txtsoluong.Text = row.Cells[3].Value.ToString();
                txtthanhtien.Text = row.Cells[4].Value.ToString();

                barButtondelete.Enabled = true;
                action = true;

            }
        }

        private void barButtonancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = false;
            txtsoluong.ReadOnly = false;
            barButtondelete.Enabled = false;
            txtsoluong.Clear();
            txtthanhtien.Clear();
        }

        private void barButtonexist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}