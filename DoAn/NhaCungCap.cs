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
    public partial class NhaCungCap : UserControl
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            radMa.Checked = true;
            AutoCompleteMNCC();
            AutoCompleteTNCC();
            HienThiDanhSachNCC(dgvNCC);
            dgvNCC.RowsDefaultCellStyle.BackColor = Color.White;
            dgvNCC.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
        }

        private void txtTimMaNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }

        private void txtTimTenNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(this, new EventArgs());
            }
        }

        public void HienThiDanhSachNCC(DataGridView dgv)
        {
            BAL_DM_NCC xulyncc = new BAL_DM_NCC();
            dgv.DataSource = xulyncc.LayDSNCC();

        }

        private int dongthu = -1;

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                dgvNCC.DataSource = null;
                HienThiDanhSachNCCTheoMaNCC(dgvNCC);
            }
            else if (radTen.Checked == true)
            {
                dgvNCC.DataSource = null;
                HienThiDanhSachNCCTheoTenNCC(dgvNCC);
            }
            else if (radMa.Checked == false && radTen.Checked == false)
                MessageBox.Show("Chưa chọn tiêu chí để tìm kiếm", "Thông báo");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNCC(dgvNCC);
            txtMaNCC.Enabled = true;
            txtTenNCC.Text = null;
            txtMaNCC.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNCC.Enabled = false;
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvNCC.Rows[dongthu];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void HienThiDanhSachNCCTheoMaNCC(DataGridView dgv)
        {
            BAL_DM_NCC xulyncc = new BAL_DM_NCC();
            dgv.DataSource = xulyncc.LayDSNCCTMNCC(txtTimTheoMaNCC.Text);
        }

        public void HienThiDanhSachNCCTheoTenNCC(DataGridView dgv)
        {
            BAL_DM_NCC xulyncc = new BAL_DM_NCC();
            dgv.DataSource = xulyncc.LayDSNCCTTNCC(txtTimTheoTenNCC.Text);
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            BAL_DM_NCC xulyncc = new BAL_DM_NCC();
            if (string.IsNullOrEmpty(txtMaNCC.Text))
                MessageBox.Show("Chưa chọn nhà cung cấp cần xóa (chưa có mã nhà cung cấp)", "Thông báo");
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    xulyncc.XoaNCC(txtMaNCC.Text);
                    MessageBox.Show("Đã xóa nhà cung cấp", "Thông báo");
                    HienThiDanhSachNCC(dgvNCC);
                    txtMaNCC.Enabled = true;
                    txtMaNCC.Text = null;
                    txtTenNCC.Text = null;
                    txtDiaChi.Text = null;
                    txtSDT.Text = null;
                }
            }
        }

        private void btnCapNhatNCC_Click(object sender, EventArgs e)
        {
            BEL_DM_NCC ncc = new BEL_DM_NCC();
            BAL_DM_NCC xulyncc = new BAL_DM_NCC();
            ncc.Mancc = txtMaNCC.Text;
            ncc.Tenncc = txtTenNCC.Text;
            ncc.Diachi = txtDiaChi.Text;
            ncc.Sdt = txtSDT.Text;
            if (String.IsNullOrEmpty(txtMaNCC.Text))
                MessageBox.Show("Cần nhập ít nhất mã nhà cung cấp!", "Cập nhật thất bại");
            else
            {
                xulyncc.CapNhat(ncc);
                dgvNCC.DataSource = null;
                MessageBox.Show("Cập nhật thành công!", "Thành công");
                HienThiDanhSachNCC(dgvNCC);
                txtMaNCC.Enabled = true;
                txtMaNCC.Text = null;
                txtDiaChi.Text = null;
                txtSDT.Text = null;
                txtTenNCC.Text = null;
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            BEL_DM_NCC ncc = new BEL_DM_NCC();
            BAL_DM_NCC xulyncc = new BAL_DM_NCC();
            ncc.Mancc = txtMaNCC.Text;
            ncc.Tenncc = txtTenNCC.Text;
            ncc.Diachi = txtDiaChi.Text;
            ncc.Sdt = txtSDT.Text;
            if (xulyncc.KiemTraTonTai(ncc.Mancc))
                MessageBox.Show("Nhà cung cấp đã có (trùng mã nhà cung cấp)", "Thêm thất bại");
            else if (String.IsNullOrEmpty(txtMaNCC.Text))
            {
                MessageBox.Show("Cần nhập ít nhất mã nhà cung cấp!", "Thêm thất bại");
            }
            else
            {
                xulyncc.ThemNCC(ncc);
                dgvNCC.DataSource = null;
                MessageBox.Show("Thêm thành công!", "Thành công");
                HienThiDanhSachNCC(dgvNCC);
                txtMaNCC.Enabled = true;
                txtMaNCC.Text = null;
                txtTenNCC.Text = null;
                txtDiaChi.Text = null;
                txtSDT.Text = null;
                
            }
        }

        private void radMa_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTheoMaNCC.Enabled = true;
            txtTimTheoTenNCC.Enabled = false;
            txtTimTheoTenNCC.Text = null;
        }

        private void radTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTheoMaNCC.Enabled = false;
            txtTimTheoTenNCC.Enabled = true;
            txtTimTheoMaNCC.Text = null;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void AutoCompleteTNCC()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_NCC xulyncc = new BAL_DM_NCC(); //Thay thành BAL của NCC
            DataTable dt = new System.Data.DataTable();

            dt = xulyncc.LayDSNCC();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Tên NCC"].ToString(); //Thay bằng tên đặt của Tên NCC
                autoComplete.Add(ten);
            }
            txtTimTheoTenNCC.AutoCompleteCustomSource = autoComplete;
            txtTimTheoTenNCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTheoTenNCC.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void AutoCompleteMNCC()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            BAL_DM_NCC xulyncc = new BAL_DM_NCC(); //Thay thành BAL của NCC
            DataTable dt = new System.Data.DataTable();

            dt = xulyncc.LayDSNCC();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i]["Mã NCC"].ToString(); //Thay bằng tên đặt của Mã NCC
                autoComplete.Add(ten);
            }
            txtTimTheoMaNCC.AutoCompleteCustomSource = autoComplete;
            txtTimTheoMaNCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimTheoMaNCC.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
