using QLSinhVienThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienThucTap.GUI
{
    public partial class frmHome : Form
    {
        private TaiKhoan user;
        public TaiKhoan User
        {
            get { return user; }
            set { user = value; changeAccount(user.VaiTro); }
        }

        public frmHome(TaiKhoan TaiKhoan)
        {
            InitializeComponent();
            this.User = TaiKhoan;
        }
        void changeAccount(bool VaiTro)
        {
            tsmAdmin.Enabled = VaiTro;
            tsmAccountProfile.Text += " (" + User.TenNguoiDung + ")";
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau(User.TenDangNhap);
            doiMatKhau.ShowDialog();
        }

        private void tsmAccountProfile_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan thongTinCaNhan = new frmThongTinCaNhan(User);
            thongTinCaNhan.UpdateProfile += ThongTinCaNhan_UpdateProfile;
            thongTinCaNhan.ShowDialog();
        }
        private void ThongTinCaNhan_UpdateProfile(object sender, frmThongTinCaNhan.UpdateProfileEventArgs e)
        {
            this.User = e.User;
            tsmAccountProfile.Text = "Thông tin cá nhân (" + User.TenNguoiDung + ")";
        }
        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
