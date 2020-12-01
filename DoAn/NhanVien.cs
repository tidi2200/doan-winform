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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien(dgvNhanVien);
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            string chucvu = xulynhanvien.LayChucVu(frmDangNhap.us);
            dgvNhanVien.RowsDefaultCellStyle.BackColor = Color.White;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            radma.Checked = true;
            AutoCompleteMNV();
            AutoCompleteTNV();
        }

        public void HienThiDanhSachNhanVien(DataGridView dgv)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            dgv.DataSource = xulynhanvien.LayDSNV();
           // HienThiDanhSachChucVu(cboChucVu);
        }

      //  public void HienThiDanhSachChucVu(ComboBox cbo)
       // {
        //    BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
       //     cbo.DataSource = xulynhanvien.LayDSCV();
         //   cbo.DisplayMember = "Chucvu";
       // }

        private int dongthu = -1;
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Enabled = false;
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvNhanVien.Rows[dongthu];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                    radNam.Checked = true;
                if (row.Cells[2].Value.ToString() == "Nữ")
                    radNu.Checked = true;
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtSoDT.Text = row.Cells[5].Value.ToString();
                if (row.Cells[6].Value.ToString() == "Quản lý")
                    radQuanLy.Checked = true;
                if (row.Cells[6].Value.ToString() == "Nhân viên")
                    radNhanVien.Checked = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            BEL_DM_NHANVIEN nv = new BEL_DM_NHANVIEN();
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            nv.Manv = txtMaNV.Text;
            nv.Hoten = txtTenNV.Text;
            if (radNam.Checked == true)
                nv.Gioitinh = "Nam";
            if (radNu.Checked == true)
                nv.Gioitinh = "Nữ";
            nv.Ngaysinh = dateTimePicker2.Value.ToString("dd-MM-yyyy");
            nv.Diachi = txtDiaChi.Text;
            nv.Sodienthoai = txtSoDT.Text;
            if (radQuanLy.Checked == true)
                nv.Chucvu = "Quản lý";
            if (radNhanVien.Checked == true)
                nv.Chucvu = "Nhân viên";
            if (xulynhanvien.KiemTraTonTai(nv.Manv))
                MessageBox.Show("Nhân viên đã có (trùng mã nhân viên)", "Thêm thất bại");
            else if (String.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Cần nhập ít nhất mã nhân viên!", "Thêm thất bại");
            }
            else
            {
                xulynhanvien.ThemNV(nv);
                dgvNhanVien.DataSource = null;
                MessageBox.Show("Thêm thành công!", "Thành công");
                HienThiDanhSachNhanVien(dgvNhanVien);
                txtMaNV.Text = null;
                txtDiaChi.Text = null;
                txtSoDT.Text = null;
                txtTenNV.Text = null;
                radNam.Checked = false;
                radNu.Checked = false;
                radQuanLy.Checked = false;
                radNhanVien.Checked = false;
                dateTimePicker2.Text = null;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien(dgvNhanVien);
            txtMaNV.Enabled = true;
            txtMaNV.Text = null;
            txtDiaChi.Text = null;
            txtSoDT.Text = null;
            txtTenNV.Text = null;
            radNam.Checked = false;
            radNu.Checked = false;
            radQuanLy.Checked = false;
            radNhanVien.Checked = false;
            dateTimePicker2.Text = null;
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            BEL_DM_NHANVIEN nv = new BEL_DM_NHANVIEN();
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            nv.Manv = txtMaNV.Text;
            nv.Hoten = txtTenNV.Text;
            if (radNam.Checked == true)
                nv.Gioitinh = "Nam";
            if (radNu.Checked == true)
                nv.Gioitinh = "Nữ";
            nv.Ngaysinh = dateTimePicker2.Value.ToString();
            nv.Diachi = txtDiaChi.Text;
            nv.Sodienthoai = txtSoDT.Text;
            if (radQuanLy.Checked == true)
                nv.Chucvu = "Quản lý";
            if (radNhanVien.Checked == true)
                nv.Chucvu = "Nhân viên";
            if (String.IsNullOrEmpty(txtMaNV.Text))
                MessageBox.Show("Cần nhập ít nhất mã nhân viên để cập nhật thông tin nhân viên!", "Cập nhật thất bại");
            else
            {
                xulynhanvien.CapNhatNV(nv);
                dgvNhanVien.DataSource = null;
                MessageBox.Show("Cập nhật thành công", "Thành công");
                HienThiDanhSachNhanVien(dgvNhanVien);
            }
        }

        private void radma_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTenNV.Enabled = false;
            txtTimMaNV.Enabled = true;
            txtTimTenNV.Text = null;
            txtTimMaNV.Focus();
        }

        private void radten_CheckedChanged(object sender, EventArgs e)
        {
            txtTimMaNV.Enabled = false;
            txtTimTenNV.Enabled = true;
            txtTimMaNV.Text = null;
            txtTimTenNV.Focus();
        }

        public void HienThiDanhSachNhanVienTheoMaNV(DataGridView dgv)
        {

            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            dgv.DataSource = xulynhanvien.LayDSNVTM(txtTimMaNV.Text);
        }

        public void HienThiDanhSachNhanVienTheoTen(DataGridView dgv)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            dgv.DataSource = xulynhanvien.LayDSNVTT(txtTimTenNV.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radma.Checked == true)
            {
                dgvNhanVien.DataSource = null;
                HienThiDanhSachNhanVienTheoMaNV(dgvNhanVien);
            }
            else if (radten.Checked == true)
            {
                dgvNhanVien.DataSource = null;
                HienThiDanhSachNhanVienTheoTen(dgvNhanVien);
            }
            else if (radma.Checked == false && radten.Checked == false)
                MessageBox.Show("Chưa chọn tiêu chí để tìm kiếm", "Thông báo");
        }


        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            if (string.IsNullOrEmpty(txtMaNV.Text))
                MessageBox.Show("Chưa chọn nhân viên cần xóa (chưa có mã nhân viên)", "Thông báo");
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    string manv = txtMaNV.Text;
                    xulynhanvien.XoaNV(manv);
                    MessageBox.Show("Đã xóa nhân viên", "Thông báo");
                    HienThiDanhSachNhanVien(dgvNhanVien);
                    txtMaNV.Text = null;
                    txtTenNV.Text = null;
                    radNam.Checked = false;
                    radNu.Checked = false;
                    dateTimePicker2.Text = null;
                    txtDiaChi.Text = null;
                    txtSoDT.Text = null;
                    radQuanLy.Checked = false;
                    radNhanVien.Checked = false;
                }
            }
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void AutoCompleteMNV()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            DataTable dt = new System.Data.DataTable();
            dt = xulynhanvien.LayDSNVTM("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Mã nhân viên"].ToString();
                autoComplete.Add(ten);
            }
            txtTimMaNV.AutoCompleteCustomSource = autoComplete;
            txtTimMaNV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimMaNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void AutoCompleteTNV()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            DataTable dt = new System.Data.DataTable();
            dt = xulynhanvien.LayDSNVTT("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Họ tên"].ToString();
                autoComplete.Add(ten);
            }
            txtTimTenNV.AutoCompleteCustomSource = autoComplete;
            txtTimTenNV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTenNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtTimMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }

        private void txtTimTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }
    }
}
