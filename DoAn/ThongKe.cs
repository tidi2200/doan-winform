using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            tkNhanVien UsertkNhanVien = new tkNhanVien();
            UsertkNhanVien.Dock = DockStyle.Fill;

            tkKhachHang UsertkKhachHang = new tkKhachHang();
            UsertkKhachHang.Dock = DockStyle.Fill;

            tkSanPham UsertkSanPham = new tkSanPham();
            UsertkSanPham.Dock = DockStyle.Fill;

            tkHoaDon UsertkHoaDon = new tkHoaDon();
            UsertkHoaDon.Dock = DockStyle.Fill;

            tkDoanhThu UserDoanhThu = new tkDoanhThu();
            UserDoanhThu.Dock = DockStyle.Fill;

            TabPage MytabtkNhanVien = new TabPage();
            MytabtkNhanVien.Controls.Add(UsertkNhanVien);
            MytabtkNhanVien.Name = "tabtkNhanVien";
            MytabtkNhanVien.Text = "Nhân Viên";

            TabPage MytabtkKhachHang = new TabPage();
            MytabtkKhachHang.Controls.Add(UsertkKhachHang);
            MytabtkKhachHang.Name = "tabtkKhachHang";
            MytabtkKhachHang.Text = "Khách Hàng";

            TabPage MytabtkSanPham = new TabPage();
            MytabtkSanPham.Controls.Add(UsertkSanPham);
            MytabtkSanPham.Name = "tabtkSanPham";
            MytabtkSanPham.Text = "Sản Phẩm";

            TabPage MytabtkHoaDon = new TabPage();
            MytabtkHoaDon.Controls.Add(UsertkHoaDon);
            MytabtkHoaDon.Name = "tabtkHoaDon";
            MytabtkHoaDon.Text = "Hóa Đơn";

            TabPage MytabDoanhThu = new TabPage();
            MytabDoanhThu.Controls.Add(UserDoanhThu);
            MytabDoanhThu.Name = "tabtkDoanhThu";
            MytabDoanhThu.Text = "Doanh Thu";

            tabControl1.TabPages.Add(MytabtkNhanVien);
            tabControl1.TabPages.Add(MytabtkKhachHang);
            tabControl1.TabPages.Add(MytabtkSanPham);
            tabControl1.TabPages.Add(MytabtkHoaDon);
            tabControl1.TabPages.Add(MytabDoanhThu);
        }
    }
}
