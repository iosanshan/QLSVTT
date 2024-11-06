using QLSinhVienThucTap.DAL;
using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienThucTap.BLL
{
    internal class KhoaBLL
    {
        internal static List<Khoa> GetListKhoa()
        {
            return KhoaDAL.Instance.GetListKhoa();
        }
    }
}
