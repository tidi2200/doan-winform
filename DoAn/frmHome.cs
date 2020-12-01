using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            string chucvu = xulynhanvien.LayChucVu(frmDangNhap.us);
            ImageList iconList = new ImageList();
            iconList.TransparentColor = Color.Blue;
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageSize = new Size(25, 25);
            iconList.Images.Add(Image.FromFile(@"img\Home-icon.png"));
            iconList.Images.Add(Image.FromFile(@"img\Shop-Clothes-icon.png"));
            iconList.Images.Add(Image.FromFile(@"img\engineer-icon.png"));
            iconList.Images.Add(Image.FromFile(@"img\Users-icon.png"));
            iconList.Images.Add(Image.FromFile(@"img\Ecommerce-Shopping-Cart-icon.png"));
            iconList.Images.Add(Image.FromFile(@"img\payment-icon.png"));
            iconList.Images.Add(Image.FromFile(@"img\chart-icon.png"));
            iconList.Images.Add(Image.FromFile(@"img\distributor.png"));

            TrangChu userTrangChu = new TrangChu();
            userTrangChu.Dock = DockStyle.Fill;

            BanHang UserBanHang = new BanHang();
            UserBanHang.Dock = DockStyle.Fill;

            SanPham UserSanPham = new SanPham();
            UserSanPham.Dock = DockStyle.Fill;

            NhaCungCap UserNhaCungCap = new NhaCungCap();
            UserNhaCungCap.Dock = DockStyle.Fill;

            NhanVien UserNhanVien = new NhanVien();
            UserNhanVien.Dock = DockStyle.Fill;

            KhachHang UserKhachHang = new KhachHang();
            UserKhachHang.Dock = DockStyle.Fill;

            HoaDon UserHoaDon = new HoaDon();
            UserHoaDon.Dock = DockStyle.Fill;

            ThongKe UserThongKe = new ThongKe();
            UserThongKe.Dock = DockStyle.Fill;

            if (chucvu == "Quản lý")
            {
                TabPage MyTabTrangChu = new TabPage();
                MyTabTrangChu.Controls.Add(userTrangChu);
                MyTabTrangChu.Name = "tabTrangChu";
                MyTabTrangChu.Text = "Trang Chủ";
                MyTabTrangChu.ImageIndex = 0;

                TabPage MyTabBanHang = new TabPage();
                MyTabBanHang.Controls.Add(UserBanHang);
                MyTabBanHang.Name = "tabBanHang";
                MyTabBanHang.Text = "Bán Hàng";
                MyTabBanHang.ImageIndex = 5;

                TabPage MyTabSanPham = new TabPage();
                MyTabSanPham.Controls.Add(UserSanPham);
                MyTabSanPham.Name = "tabSanPham";
                MyTabSanPham.Text = "Sản Phẩm";
                MyTabSanPham.ImageIndex = 1;

                TabPage MyTabNhaCungCap = new TabPage();
                MyTabNhaCungCap.Controls.Add(UserNhaCungCap);
                MyTabNhaCungCap.Name = "tabNhaCungCap";
                MyTabNhaCungCap.Text = "Nhà Cung Cấp";
                MyTabNhaCungCap.ImageIndex=7;

                TabPage MyTabNhanVien = new TabPage();
                MyTabNhanVien.Controls.Add(UserNhanVien);
                MyTabNhanVien.Name = "tabNhanVien";
                MyTabNhanVien.Text = "Nhân Viên";
                MyTabNhanVien.ImageIndex = 2;

                TabPage MyTabKhachHang = new TabPage();
                MyTabKhachHang.Controls.Add(UserKhachHang);
                MyTabKhachHang.Name = "tabKhachHang";
                MyTabKhachHang.Text = "Khách Hàng";
                MyTabKhachHang.ImageIndex = 3;

                TabPage MyTabHoaDon = new TabPage();
                MyTabHoaDon.Controls.Add(UserHoaDon);
                MyTabHoaDon.Name = "tabHoaDon";
                MyTabHoaDon.Text = "Hóa Đơn";
                MyTabHoaDon.ImageIndex = 4;

                TabPage MyTabThongKe = new TabPage();
                MyTabThongKe.Controls.Add(UserThongKe);
                MyTabThongKe.Name = "tabThongKe";
                MyTabThongKe.Text = "Thống Kê";
                MyTabThongKe.ImageIndex = 6;

                tabControl1.ImageList = iconList;
                tabControl1.TabPages.Add(MyTabTrangChu);
                tabControl1.TabPages.Add(MyTabBanHang);
                tabControl1.TabPages.Add(MyTabSanPham);
                tabControl1.TabPages.Add(MyTabNhaCungCap);
                tabControl1.TabPages.Add(MyTabNhanVien);
                tabControl1.TabPages.Add(MyTabKhachHang);
                tabControl1.TabPages.Add(MyTabHoaDon);
                tabControl1.TabPages.Add(MyTabThongKe);
            }
            else
            {
                TabPage MyTabTrangChu = new TabPage();
                MyTabTrangChu.Controls.Add(userTrangChu);
                MyTabTrangChu.Name = "tabTrangChu";
                MyTabTrangChu.Text = "Trang Chủ";
                MyTabTrangChu.ImageIndex = 0;

                TabPage MyTabBanHang = new TabPage();
                MyTabBanHang.Controls.Add(UserBanHang);
                MyTabBanHang.Name = "tabBanHang";
                MyTabBanHang.Text = "Bán Hàng";
                MyTabBanHang.ImageIndex = 5;

                TabPage MyTabKhachHang = new TabPage();
                MyTabKhachHang.Controls.Add(UserKhachHang);
                MyTabKhachHang.Name = "tabKhachHang";
                MyTabKhachHang.Text = "Khách Hàng";
                MyTabKhachHang.ImageIndex = 3;

                TabPage MyTabHoaDon = new TabPage();
                MyTabHoaDon.Controls.Add(UserHoaDon);
                MyTabHoaDon.Name = "tabHoaDon";
                MyTabHoaDon.Text = "Hóa Đơn";
                MyTabHoaDon.ImageIndex = 4;

                tabControl1.ImageList = iconList;
                tabControl1.TabPages.Add(MyTabTrangChu);
                tabControl1.TabPages.Add(MyTabBanHang);
                tabControl1.TabPages.Add(MyTabKhachHang);
                tabControl1.TabPages.Add(MyTabHoaDon);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if(kq == DialogResult.Yes)
                this.Close();
        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                btnLogout.PerformClick();
            }
        }
    }
}
