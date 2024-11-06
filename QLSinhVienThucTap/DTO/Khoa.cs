using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.DTO
{
    internal class Khoa
    {
        private string maKhoa;
        private string tenKhoa;
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
        public Khoa(string maKhoa, string tenKhoa)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
        }
        public Khoa(DataRow row)
        {
            this.MaKhoa = row["MaKhoa"].ToString();
            this.TenKhoa = row["TenKhoa"].ToString();
        }
    }
}
