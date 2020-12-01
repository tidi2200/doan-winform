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
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang(dgvKhachHang);
            dgvKhachHang.RowsDefaultCellStyle.BackColor = Color.White;
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            radsdt.Checked = true;
            AutoCompleteSDT();
            AutoCompleteTKH();
        }

        public void HienThiDanhSachKhachHang(DataGridView dgv)
        {
            BAL_DM_KH xulykhachhang = new BAL_DM_KH();
            dgv.DataSource = xulykhachhang.LayDSKH();
        }

        private int dongthu = -1;
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Enabled = false;
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvKhachHang.Rows[dongthu];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                    radNu.Checked = true;
                if (row.Cells[2].Value.ToString() == "Nữ")
                    radNam.Checked = true;
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSoDT.Text = row.Cells[5].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            BEL_DM_KH kh = new BEL_DM_KH();
            BAL_DM_KH xulykh = new BAL_DM_KH();
            kh.Makhachhang = txtMaKH.Text;
            kh.Tenkhachhang = txtTenKH.Text;
            if (radNu.Checked == true)
                kh.Gioitinh = "Nam";
            if (radNam.Checked == true)
                kh.Gioitinh = "Nữ";
            kh.Diachi = txtDiaChi.Text;
            kh.Sdt = txtSoDT.Text;
            kh.Ngaysinh = dateTimePicker2.Value.ToString("dd-MM-yy");
            if (xulykh.KiemTraTonTai(kh.Makhachhang))
                MessageBox.Show("Khách hàng đã có (trùng mã khách hàng)", "Thêm thất bại");
            else if (String.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Cần nhập ít nhất mã khách hàng!", "Thêm thất bại");
            }
            else
            {
                xulykh.ThemKH(kh);
                dgvKhachHang.DataSource = null;
                MessageBox.Show("Thêm thành công!", "Thành công");
                HienThiDanhSachKhachHang(dgvKhachHang);
                txtMaKH.Text = null;
                txtDiaChi.Text = null;
                txtSoDT.Text = null;
                txtTenKH = null;
                radNu.Checked = false;
                radNam.Checked = false;
                dateTimePicker2.Text = null;
            }
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            BEL_DM_KH kh = new BEL_DM_KH();
            BAL_DM_KH xulykh = new BAL_DM_KH();
            kh.Makhachhang = txtMaKH.Text;
            kh.Tenkhachhang = txtTenKH.Text;
            if (radNu.Checked == true)
                kh.Gioitinh = "Nam";
            if (radNam.Checked == true)
                kh.Gioitinh = "Nữ";
            kh.Ngaysinh = dateTimePicker2.Value.ToString();
            kh.Diachi = txtDiaChi.Text;
            kh.Sdt = txtSoDT.Text;
            if (String.IsNullOrEmpty(txtMaKH.Text))
                MessageBox.Show("Cần nhập ít nhất mã khách hàng để cập nhật thông tin khách hàng!", "Cập nhật thất bại");
            else
            {
                xulykh.CapNhat(kh);
                dgvKhachHang.DataSource = null;
                MessageBox.Show("Cập nhật thành công", "Thành công");
                HienThiDanhSachKhachHang(dgvKhachHang);
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            BAL_DM_KH xulykh = new BAL_DM_KH();
            if (string.IsNullOrEmpty(txtMaKH.Text))
                MessageBox.Show("Chưa chọn khách hàng cần xóa (chưa có mã khách hàng)", "Thông báo");
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    xulykh.XoaKH(txtMaKH.Text);
                    MessageBox.Show("Đã xóa khách hàng", "Thông báo");
                    HienThiDanhSachKhachHang(dgvKhachHang);
                    txtMaKH.Text = null;
                    txtTenKH.Text = null;
                    radNu.Checked = false;
                    radNam.Checked = false;
                    dateTimePicker2.Text = null;
                    txtDiaChi.Text = null;
                    txtSoDT.Text = null;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radsdt.Checked == true)
            {
                dgvKhachHang.DataSource = null;
                HienThiDanhSachKHTheoSDT(dgvKhachHang);
            }
            else if (radten.Checked == true)
            {
                dgvKhachHang.DataSource = null;
                HienThiDanhSachKHTheoTen(dgvKhachHang);
            }
            else if (radsdt.Checked == false && radten.Checked == false)
                MessageBox.Show("Chưa chọn tiêu chí để tìm kiếm", "Thông báo");
        }

        public void HienThiDanhSachKHTheoSDT(DataGridView dgv)
        {
            BAL_DM_KH xulykh = new BAL_DM_KH();
            dgv.DataSource = xulykh.TimTheoSDT(txtTimSĐTKH.Text);
        }

        public void HienThiDanhSachKHTheoTen(DataGridView dgv)
        {
            BAL_DM_KH xulykh = new BAL_DM_KH();
            dgv.DataSource = xulykh.TimTheoTen(txtTimTenKH.Text);
        }

        private void radsdt_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTenKH.Enabled = false;
            txtTimSĐTKH.Enabled = true;
            txtTimTenKH.Text = null;
            txtTimSĐTKH.Focus();
        }

        private void radten_CheckedChanged(object sender, EventArgs e)
        {
            txtTimSĐTKH.Enabled = false;
            txtTimTenKH.Enabled = true;
            txtTimSĐTKH.Text = null;
            txtTimTenKH.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang(dgvKhachHang);
            txtMaKH.Enabled = true;
            txtMaKH.Text = null;
            txtDiaChi.Text = null;
            txtSoDT.Text = null;
            txtTenKH.Text = null;
            radNu.Checked = false;
            radNam.Checked = false;
            dateTimePicker2.Text = null;
        }

        public void AutoCompleteSDT()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_KH xulykh = new BAL_DM_KH();
            DataTable dt = new System.Data.DataTable();
            dt = xulykh.LayDSKH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Số điện thoại"].ToString();
                autoComplete.Add(ten);
            }
            txtTimSĐTKH.AutoCompleteCustomSource = autoComplete;
            txtTimSĐTKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimSĐTKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void AutoCompleteTKH()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_KH xulykh = new BAL_DM_KH();
            DataTable dt = new System.Data.DataTable();
            dt = xulykh.LayDSKH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Tên KH"].ToString();
                autoComplete.Add(ten);
            }
            txtTimTenKH.AutoCompleteCustomSource = autoComplete;
            txtTimTenKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTenKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtTimSĐTKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }

        private void txtTimTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }
    }
}
