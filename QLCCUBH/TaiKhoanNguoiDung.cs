using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCCUBH
{
    internal class TaiKhoanNguoiDung
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoanNguoiDung()
        {
        }

        public TaiKhoanNguoiDung(string tenTaiKhoan, string matKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
