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
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon(dgvHoaDon);
            BAL_DM_HOADON xulynhanvien = new BAL_DM_HOADON();
            dgvHoaDon.RowsDefaultCellStyle.BackColor = Color.White;
            dgvHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            radHD.Checked = true;
            AutoCompleteMHD();
            AutoCompleteMKH();
            AutoCompleteMNV();
        }
        public void HienThiDanhSachHoaDon(DataGridView dgv)
        {
            BAL_DM_HOADON xulyhoadon = new BAL_DM_HOADON();
            dgv.DataSource = xulyhoadon.LayDSHD();
        }
        //public void HienThiDanhSachHoadon(DataGridView dgv)
        //{
        //    string mahoadon = txtTimTheoMaHD.Text;
        //    string manhanvien = txtTimTheoMaNV.Text;
        //    string makhachhang = txtTimTheoMaKH.Text;
        //    BAL_DM_HOADON xulyhoadon = new BAL_DM_HOADON();
        //    dgv.DataSource = xulyhoadon.TimHD(mahoadon, manhanvien, makhachhang);
        //}
        private int dongthu = -1;

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BEL_DM_HOADON sp = new BEL_DM_HOADON();
            BAL_DM_HOADON xulysanpham = new BAL_DM_HOADON();
            try
            {

                dongthu = e.RowIndex;
                DataGridViewRow row = dgvHoaDon.Rows[dongthu];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtMaNV.Text = row.Cells[1].Value.ToString();
                txtMaKH.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtTongTien.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        public void HienThiDanhSachHoaDonTheoMaHD(DataGridView dgv)
        {

            BAL_DM_HOADON xulyhoadon = new BAL_DM_HOADON();
            dgv.DataSource = xulyhoadon.LayDSHDTMHD(txtTimTheoMaHD.Text);
        }

        public void HienThiDanhSachHoaDonTheoMaNV(DataGridView dgv)
        {

            BAL_DM_HOADON xulyhoadon = new BAL_DM_HOADON();
            dgv.DataSource = xulyhoadon.LayDSHDTMNV(txtTimTheoMaNV.Text);
        }
        public void HienThiDanhSachHoaDonTheoMaKH(DataGridView dgv)
        {

            BAL_DM_HOADON xulyhoadon = new BAL_DM_HOADON();
            dgv.DataSource = xulyhoadon.LayDSHDTMKH(txtTimTheoMaKH.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void btnInHD_Click(object sender, EventArgs e)
        //{
        //    {
        //        BEL_DM_HOADON hd = new BEL_DM_HOADON();
        //        DataGridViewRow row = dgvHoaDon.Rows[0];
        //        hd.Mahd = txtMaHD.Text;
        //        hd.Manv=txtMaNV.Text;
        //        hd.Makh=txtMaKH.Text;
        //        hd.Ngaylap = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        //        hd.Tongtien=txtTongTien.Text;
        //        DialogResult kq = MessageBox.Show("================BDD================\n====Chi tiết hóa đơn====\n-Số HD: Mã HD: " + hd.Mahd + "\n" + "Mã Nhân Viên: " + hd.Manv + "\nMã khách hàng" + hd.Makh + "\nNgày lập" + hd.Ngaylap + "\nTổng tiền" + hd.Tongtien, "", MessageBoxButtons.OK);
        //    }
        //}

        private void btnInHD_Click_1(object sender, EventArgs e)
        {
            {
                BEL_DM_HOADON hd = new BEL_DM_HOADON();
                DataGridViewRow row = dgvHoaDon.Rows[0];
                hd.Mahd = txtMaHD.Text;
                hd.Manv = txtMaNV.Text;
                hd.Makh = txtMaKH.Text;
                hd.Ngaylap = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                hd.Tongtien = txtTongTien.Text;
                DialogResult kq = MessageBox.Show("================BDD================\n====Chi tiết hóa đơn====\n-Số HD: Mã HD: " + hd.Mahd + "\n" + "Mã Nhân Viên: " + hd.Manv + "\nMã khách hàng: " + hd.Makh + "\nNgày lập: " + hd.Ngaylap + "\nTổng tiền: " + hd.Tongtien, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoaHD_Click_1(object sender, EventArgs e)
        {
            BAL_DM_HOADON xulyhoadon = new BAL_DM_HOADON();
            if (string.IsNullOrEmpty(txtMaHD.Text))
                MessageBox.Show("Chưa chọn hóa đơn cần xóa (chưa có hóa đơn", "Thông báo");
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    string masp = txtMaHD.Text;
                    xulyhoadon.XoaHD(masp);
                    MessageBox.Show("Đã xóa sản phẩm", "Thông báo");
                    HienThiDanhSachHoaDon(dgvHoaDon);
                    txtMaHD.Text = null;
                    txtMaNV.Text = null;
                    txtMaKH.Text = null;
                    dateTimePicker1 = null;
                    txtTongTien.Text = null;
                }
            }
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            if (radHD.Checked == true)
            {
                dgvHoaDon.DataSource = null;
                HienThiDanhSachHoaDonTheoMaHD(dgvHoaDon);
            }
            else if (radNV.Checked == true)
            {
                dgvHoaDon.DataSource = null;
                HienThiDanhSachHoaDonTheoMaNV(dgvHoaDon);
            }
            else if (radKH.Checked == true)
            {
                dgvHoaDon.DataSource = null;
                HienThiDanhSachHoaDonTheoMaKH(dgvHoaDon);
            }
            else if (radHD.Checked == false && radNV.Checked == false && radKH.Checked == false)
                MessageBox.Show("Chưa chọn tiêu chí để tìm kiếm", "Thông báo");
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            {
                BEL_DM_HOADON hd = new BEL_DM_HOADON();
                DataGridViewRow row = dgvHoaDon.Rows[0];
                hd.Mahd = txtMaHD.Text;
                hd.Manv = txtMaNV.Text;
                hd.Makh = txtMaKH.Text;
                hd.Ngaylap = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                hd.Tongtien = txtTongTien.Text;
                DialogResult kq = MessageBox.Show("================BDD================\n====Chi tiết hóa đơn====\n-Số HD: Mã HD: " + hd.Mahd + "\n" + "Mã Nhân Viên: " + hd.Manv + "\nMã khách hàng: " + hd.Makh + "\nNgày lập: " + hd.Ngaylap + "\nTổng tiền: " + hd.Tongtien, "", MessageBoxButtons.OK);
            }
        }

        private void radHD_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTheoMaHD.Enabled = true;
            txtTimTheoMaNV.Enabled = false;
            txtTimTheoMaKH.Enabled = false;
            txtTimTheoMaNV.Text = null;
            txtTimTheoMaKH.Text = null;
            txtTimTheoMaHD.Focus();
        }

        private void radNV_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTheoMaNV.Enabled = true;
            txtTimTheoMaHD.Enabled = false;
            txtTimTheoMaKH.Enabled = false;
            txtTimTheoMaHD.Text = null;
            txtTimTheoMaKH.Text = null;
            txtTimTheoMaNV.Focus();
        }

        private void radKH_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTheoMaKH.Enabled = true;
            txtTimTheoMaHD.Enabled = false;
            txtTimTheoMaNV.Enabled = false;
            txtTimTheoMaHD.Text = null;
            txtTimTheoMaNV.Text = null;
            txtTimTheoMaKH.Focus();
        }

        public void AutoCompleteMHD()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_HOADON xulyhd = new BAL_DM_HOADON();
            DataTable dt = new System.Data.DataTable();
            dt = xulyhd.LayDSHD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Mã hóa đơn"].ToString();
                autoComplete.Add(ten);
            }
            txtTimTheoMaHD.AutoCompleteCustomSource = autoComplete;
            txtTimTheoMaHD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTheoMaHD.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void AutoCompleteMKH()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_HOADON xulyhd = new BAL_DM_HOADON();
            DataTable dt = new System.Data.DataTable();
            dt = xulyhd.LayDSHD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Mã khách hàng"].ToString();
                autoComplete.Add(ten);
            }
            txtTimTheoMaKH.AutoCompleteCustomSource = autoComplete;
            txtTimTheoMaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTheoMaKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void AutoCompleteMNV()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_HOADON xulyhd = new BAL_DM_HOADON();
            DataTable dt = new System.Data.DataTable();
            dt = xulyhd.LayDSHD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Mã nhân viên"].ToString();
                autoComplete.Add(ten);
            }
            txtTimTheoMaNV.AutoCompleteCustomSource = autoComplete;
            txtTimTheoMaNV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTheoMaNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }

}
