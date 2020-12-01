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

namespace DoAn
{
    public partial class BanHang : UserControl
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNCC(cboNCC);
        }

        private void HienThiDanhSachNCC(ComboBox cbo)
        {
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            cbo.DataSource = xulysanpham.LayDSNCC();
            cbo.DisplayMember = "TenNCC";
        }

        public void HienThiDanhSachSanPhamKho(DataGridView dgv)
        {
            string tensp = txtTimTenSP.Text;
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            string mansx = xulysanpham.LayMaNCC(cboNCC.Text);
            dgv.DataSource = xulysanpham.TimSPBH(mansx, tensp);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSanPhamKho(dgvSPKho);
            //DataGridViewCellStyle style = new DataGridViewCellStyle();
            //style.BackColor = Color.Red;
            //DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.BackColor = Color.White;
            //for (int i = 0; i < dgvSPKho.Rows.Count; i++)
            //{
            //    if (int.Parse(dgvSPKho.Rows[i].Cells[3].Value.ToString()) <= 5)
            //    {
            //        dgvSPKho.Rows[i].DefaultCellStyle = style;
            //    }
            //    else
            //        dgvSPKho.Rows[i].DefaultCellStyle = style1;
            //}
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvSPKho.Rows[0];
                int SoLuongTonKho = int.Parse(row.Cells[3].Value.ToString());
                if (int.Parse(txtSoLuong.Text) <= SoLuongTonKho)
                {
                    HienThiDanhSachGioHang(dgvGioHang);
                    HienThiTongTien(lblTongTien);
                }
                else { MessageBox.Show("Không đủ số lượng trong kho", "Thông báo"); }
            }
            catch(Exception err)
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Thông báo");
            }
        }

        private int dongthu = -1;
        public void HienThiDanhSachGioHang(DataGridView dgv)
        {
            BEL_DM_SANPHAM sp = new BEL_DM_SANPHAM();
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            try
            {
                //dongthu = e.RowIndex;
                DataGridViewRow row = dgvSPKho.Rows[0];
                sp.Masp = row.Cells[0].Value.ToString();
                sp.Tensp = row.Cells[1].Value.ToString();
                sp.Dongia = row.Cells[2].Value.ToString();
                int soluongmua = int.Parse(txtSoLuong.Text);
                //sp.Mancc = xulysanpham.LayMaNCC(row.Cells[3].Value.ToString());
                //string ChietKhau = cboChietKhau.Text;
                //string MaKH = txtMaKH.Text;
                dgv.DataSource = xulysanpham.HienGioHang(sp, soluongmua);
            }
            catch(Exception err)
            {
                MessageBox.Show("Hãy chọn sản phẩm", "Thông báo");
            }
        }

        double TongTien = 0;
        public void HienThiTongTien(Label lbl)
        {
            try
            {
                DataGridViewRow row = dgvGioHang.Rows[0];
                lbl.Text = row.Cells[3].Value.ToString();
                TongTien = Double.Parse(row.Cells[3].Value.ToString());
            }
            catch(Exception err)
            {
                MessageBox.Show("Hãy chọn sản phẩm", "Thông báo");
            }
        }

        private void dgvSPKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BEL_DM_SANPHAM sp = new BEL_DM_SANPHAM();
            BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvSPKho.Rows[dongthu];
                sp.Masp = row.Cells[0].Value.ToString();
                sp.Tensp = row.Cells[1].Value.ToString();
                sp.Dongia = row.Cells[2].Value.ToString();
                sp.Soluong = txtSoLuong.Text;
                sp.Mancc = xulysanpham.LayMaNCC(row.Cells[4].Value.ToString());
                string ChietKhau = cboChietKhau.Text;
                string MaKH = txtMaKH.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double kq = double.Parse(txtTienKhachTra.Text)-double.Parse(lblTongTien.Text);
                if(kq < 0)
                {
                    MessageBox.Show("Tiền khách đưa phải lớn hơn Tổng tiền", "Thông báo");
                    txtTienKhachTra.Clear();
                    txtTienKhachTra.Focus();
                }
                else
                    lblTienTraLai.Text = kq.ToString();
            }
        }

        bool isChecked = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButton1.Checked;
            if(isChecked == true)
            {
                txtMaKH.Text = null;
                txtMaKH.Enabled = true; 
                txtMaKH.Focus();
            }
            else
            {
                txtMaKH.Text = "KVL";
                txtMaKH.Enabled = false;
            }
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked && !isChecked)
                radioButton1.Checked = false;
            else
            {
                radioButton1.Checked = true;
                isChecked = false;
            }
        }

        private void txtTimTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemMatHang_Click(this, new EventArgs());
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cboChietKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            double TongTien2 = TongTien;
            double TongTien3 = TongTien;
            double TienDaChietKhau = 0;
            double kq = 0;
            double ChietKhau = double.Parse(cboChietKhau.Text);
            TienDaChietKhau = TongTien2 - (TongTien3 * (ChietKhau / 100));
            lblTongTien.Text = TienDaChietKhau.ToString();
        }
        private void lblTienTraLai_Click(object sender, EventArgs e)
        {
            
        }
        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (lblTongTien.Text == "0")
            {
                MessageBox.Show("Chưa chọn sản phẩm để thanh toán", "Thông báo");
            }
            else
            {
                BAL_DM_KH xulykh = new BAL_DM_KH();
                if (xulykh.KiemTraTonTai(txtMaKH.Text))
                {
                    BEL_DM_HOADON hd = new BEL_DM_HOADON();
                    BEL_DM_CHITIETHD cthd = new BEL_DM_CHITIETHD();
                    DataGridViewRow row = dgvSPKho.Rows[0];
                    cthd.Masp = row.Cells[0].Value.ToString();
                    cthd.Tensp = row.Cells[1].Value.ToString();
                    cthd.Dongia = row.Cells[2].Value.ToString();
                    cthd.Soluong = txtSoLuong.Text;
                    double ChietKhau = TongTien - Double.Parse(lblTongTien.Text);
                    cthd.Chietkhau = ChietKhau.ToString();
                    cthd.Thanhtien = lblTongTien.Text;
                    BAL_DM_CHITIETHD xulycthd = new BAL_DM_CHITIETHD();
                    hd.Manv = frmDangNhap.us;
                    hd.Makh = txtMaKH.Text;
                    hd.Ngaylap = DateTime.Today.ToString("yyyy-MM-dd");
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    hd.Tongtien = lblTongTien.Text;
                    BAL_DM_HOADON xulyhoadon = new BAL_DM_HOADON();
                    BAL_DM_SANPHAM xulysanpham = new BAL_DM_SANPHAM();
                    DialogResult kq = MessageBox.Show("================BDD================\n====Liên bán hàng====\n-Số HD:  NV:" + hd.Manv + "\n" + hd.Ngaylap + " " + time + "\tMã KH:" + hd.Makh + "\n-Tên sản phẩm: " + cthd.Tensp + "\n-S.lượng: " + cthd.Soluong + "\n-Đơn giá:" + cthd.Dongia + "\n-Chiết khấu:" + cthd.Chietkhau + "\n-Thành tiền:" + cthd.Thanhtien + "\n-Tổng:" + hd.Tongtien + "\n-Tiền khách trả:" + txtTienKhachTra.Text + "\n-Tiền trả khách:" + lblTienTraLai.Text + "\n----------------------------------------------------\n\tXin cảm ơn và hẹn gặp lại\nBạn có muốn thanh toán hóa đơn không ?", "Xem trước hóa đơn", MessageBoxButtons.YesNo);
                    if (kq == DialogResult.Yes)
                    {
                        xulycthd.Them(cthd);
                        xulyhoadon.ThemHD(hd);
                        xulysanpham.UpdateSL(cthd);
                        MessageBox.Show("Thanh toán thành công", "Thông báo");
                        txtTienKhachTra.Text = null;
                        lblTienTraLai.Text = "0";
                        lblTongTien.Text = "0";
                        txtSoLuong.Text = "1";
                        dgvSPKho.DataSource = null;
                        dgvGioHang.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không tồn tại, xin kiểm tra lại", "Thông báo");
                    txtMaKH.Clear();
                    txtMaKH.Focus();
                }
            }
        }

        private void btnBoKhoiGioHang_Click(object sender, EventArgs e)
        {
            dgvGioHang.DataSource = null;
            txtTienKhachTra.Text = null;
            lblTienTraLai.Text = "0";
            lblTongTien.Text = "0";
            txtSoLuong.Text = "1";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

   
    }
}
