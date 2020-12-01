using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
using System.IO;

namespace DoAn
{
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openHinhAnh = new OpenFileDialog();
            openHinhAnh.Filter = "";
            openHinhAnh.Title = "Image open";
            openHinhAnh.FilterIndex = 1;
            string filename = null;
            if(openHinhAnh.ShowDialog() == DialogResult.OK)
            {
                filename =  openHinhAnh.FileName;
                pictureBox1.ImageLocation = openHinhAnh.FileName;
                txtDuongDan.Text = filename;
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham(dgvSanPham);
            HienThiDanhSachNCC(cboNCC);
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            string chucvu = xulynhanvien.LayChucVu(frmDangNhap.us);
            radma.Checked = true;
            AutoCompleteMSP();
            AutoCompleteTSP();
            
        }

        private void HienThiDanhSachNCC(ComboBox cbo)
        {
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            cbo.DataSource = xulysanpham.LayDSNCC();
            cbo.DisplayMember = "TenNCC";
        }

        public void HienThiDanhSachSanPham(DataGridView dgv)
        {
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            dgv.DataSource = xulysanpham.LayDSSP();
        }

        public void HienThiDanhSachSanPhamTheoMaSP(DataGridView dgv)
        {

            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            dgv.DataSource = xulysanpham.LayDSSPTM(txtTimMaSP.Text);
        }

        public void HienThiDanhSachSanPhamTheoTen(DataGridView dgv)
        {
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            dgv.DataSource = xulysanpham.LayDSSPTT(txtTimTenSP.Text);
        }

        private int dongthu = -1;
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Enabled = false;
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvSanPham.Rows[dongthu];
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSanPham.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                cboNCC.Text = row.Cells[4].Value.ToString();
                txtDuongDan.Text = row.Cells[5].Value.ToString();
                pictureBox1.Image = Image.FromFile(txtDuongDan.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            BEL_DM_SANPHAM sp = new BEL_DM_SANPHAM();
            sp.Masp = txtMaSP.Text;
            sp.Tensp = txtTenSanPham.Text;
            sp.Dongia = txtDonGia.Text;
            sp.Soluong = txtSoLuong.Text;
            sp.Hinhanh = Path.GetFileName(txtDuongDan.Text);
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            sp.Mancc = xulysanpham.LayMaNCC(cboNCC.Text);
            if (xulysanpham.KiemTraTonTai(sp.Masp))
                MessageBox.Show("Sản phẩm đã có (trùng mã sản phẩm)", "Thêm thất bại");
            else if (String.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Cần nhập ít nhất mã sản phẩm!", "Thêm thất bại");
            }
            else if (String.IsNullOrEmpty(txtDuongDan.Text))
            {
                MessageBox.Show("Hãy chọn hình ảnh", "Thông báo");
            }
            else
            {
                xulysanpham.ThemSP(sp);
                File.Copy(txtDuongDan.Text, Path.Combine(@"..\..\product\", Path.GetFileName(txtDuongDan.Text)), true);
                dgvSanPham.DataSource = null;
                MessageBox.Show("Thêm thành công!", "Thành công");
                HienThiDanhSachSanPham(dgvSanPham);
                txtMaSP.Text = null;
                txtTenSanPham.Text = null;
                cboNCC.Text = null;
                txtDonGia.Text = null;
                txtSoLuong.Text = null;
                pictureBox1.InitialImage = null;
                txtDuongDan.Text = null;
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            if (string.IsNullOrEmpty(txtMaSP.Text))
                MessageBox.Show("Chưa chọn sản phẩm cần xóa (chưa có mã sản phẩm)", "Thông báo");
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    string masp = txtMaSP.Text;
                    xulysanpham.XoaSP(masp);
                    MessageBox.Show("Đã xóa sản phẩm", "Thông báo");
                    HienThiDanhSachSanPham(dgvSanPham);
                    txtMaSP.Text = null;
                    txtTenSanPham.Text = null;
                    txtDonGia.Text = null;
                    txtSoLuong.Text = null;
                    txtDuongDan.Text = null;
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            BEL_DM_SANPHAM sp = new BEL_DM_SANPHAM();
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            string a = txtDuongDan.Text; //Biến kiểm tra đã thay đổi đường dẫn hình ảnh hay chưa
            sp.Masp = txtMaSP.Text;
            sp.Tensp = txtTenSanPham.Text;
            sp.Dongia = txtDonGia.Text;
            sp.Soluong = txtSoLuong.Text;
            //File.Copy(txtDuongDan.Text, Path.Combine(@"..\..\product\", Path.GetFileName(txtDuongDan.Text)), true);
            sp.Hinhanh = Path.GetFileName(txtDuongDan.Text);
            sp.Mancc = xulysanpham.LayMaNCC(cboNCC.Text);
            if (String.IsNullOrEmpty(txtMaSP.Text))
                MessageBox.Show("Cần nhập ít nhất mã sản phẩm để cập nhật thông tin sản phẩm!", "Cập nhật thất bại");
            else if (String.IsNullOrEmpty(txtDuongDan.Text))
                MessageBox.Show("Vui lòng chọn hình ảnh", "Thông báo");
            else
            {
                xulysanpham.CapNhatSP(sp);

                if (a != txtDuongDan.Text)
                    File.Copy(txtDuongDan.Text, Path.Combine(@"..\..\product\", Path.GetFileName(txtDuongDan.Text)), true);

                dgvSanPham.DataSource = null;
                MessageBox.Show("Cập nhật thành công", "Thành công");
                HienThiDanhSachSanPham(dgvSanPham);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham(dgvSanPham);
            txtMaSP.Enabled = true;
            txtMaSP.Text = null;
            txtTenSanPham.Text = null;
            txtDonGia.Text = null;
            txtSoLuong.Text = null;
            txtDuongDan.Text = null;
            pictureBox1.Image = null;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radma.Checked == true)
            {
                dgvSanPham.DataSource = null;
                HienThiDanhSachSanPhamTheoMaSP(dgvSanPham);
            }
            else if (radten.Checked == true)
            {
                dgvSanPham.DataSource = null;
                HienThiDanhSachSanPhamTheoTen(dgvSanPham);
            }
            else if (radma.Checked == false && radten.Checked == false)
                MessageBox.Show("Chưa chọn tiêu chí để tìm kiếm", "Thông báo");
        }

        private void radma_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTenSP.Enabled = false;
            txtTimMaSP.Enabled = true;
            txtTimTenSP.Text = null;
            txtTimMaSP.Focus();
        }

        private void radten_CheckedChanged(object sender, EventArgs e)
        {
            txtTimMaSP.Enabled = false;
            txtTimTenSP.Enabled = true;
            txtTimMaSP.Text = null;
            txtTimTenSP.Focus();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void AutoCompleteTSP()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            DataTable dt = new System.Data.DataTable();

            dt = xulysanpham.LayDSSP();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Tên sản phẩm"].ToString();
                autoComplete.Add(ten);
            }
            txtTimTenSP.AutoCompleteCustomSource = autoComplete;
            txtTimTenSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTenSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void AutoCompleteMSP()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            DataTable dt = new System.Data.DataTable();

            dt = xulysanpham.LayDSSPTM("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Mã sản phẩm"].ToString();
                autoComplete.Add(ten);
            }
            txtTimMaSP.AutoCompleteCustomSource = autoComplete;
            txtTimMaSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimMaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtTimMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }

        private void txtTimTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }
    }
}
