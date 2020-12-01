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
using BEL;


namespace DoAn
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiMaNhanVien(comboBox1);
        }

        public void HienThiMaNhanVien(ComboBox cbo)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            cbo.DataSource = xulynhanvien.HienThiMaNV();
            cbo.DisplayMember = "Manhanvien";
        }

        private void btnDatLaiPass_Click(object sender, EventArgs e)
        {
            string newpw = "1";
            BAL_DM_USER xulyuser = new BAL_DM_USER();
            xulyuser.DoiMatKhau(comboBox1.Text, newpw);
            MessageBox.Show("Đặt lại mật khẩu thành công\n Mật khẩu mới: 1", "Thông báo");
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            BEL_DM_NHANVIEN nv = new BEL_DM_NHANVIEN();
            nv.Manv = txtManv.Text;
            nv.Hoten = txtHoten.Text;
            nv.Password = txtpw.Text;
            BAL_DM_USER xulyuser = new BAL_DM_USER();
            BAL_DM_NHANVIEN xulynhanvien = new BAL.BAL_DM_NHANVIEN();
            if(string.IsNullOrEmpty(txtManv.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản (Mã nhân viên)", "Thông báo");
                txtManv.Focus();
            }
            else if(string.IsNullOrEmpty(txtpw.Text) || string.IsNullOrEmpty(txtrepw.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu", "Thông báo");
                if (string.IsNullOrEmpty(txtpw.Text))
                    txtpw.Focus();
                if (string.IsNullOrEmpty(txtrepw.Text))
                    txtrepw.Focus();
            }
            else if (xulynhanvien.KiemTraTonTai(nv.Manv))
            {
                MessageBox.Show("Tài khoản (Mã nhân viên) đã tồn tại, vui lòng nhập lại", "Thông báo");
                txtManv.Clear();
                txtManv.Focus();
            }
            else if(txtpw.Text == txtrepw.Text)
            {
                xulyuser.TaoTaiKhoan(nv);
                DialogResult kq = MessageBox.Show("Tạo thành công!\nhãy cập nhật thông tin vào lần đăng nhập đầu tiên.", "Thông báo");
                if(kq == DialogResult.OK)
                {
                    txtHoten.Clear();
                    txtManv.Clear();
                    txtpw.Clear();
                    txtrepw.Clear();
                    radHien.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không giống nhau, vui lòng nhập lại chính xác", "Thông báo");
                txtpw.Clear();
                txtrepw.Clear();
                txtpw.Focus();
            }
        }

        bool isChecked = false;
        private void radHien_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radHien.Checked;
            if (isChecked == true)
            {
                txtpw.UseSystemPasswordChar = false;
                txtrepw.UseSystemPasswordChar = false;
            }
            else
            {
                txtpw.UseSystemPasswordChar = true;
                txtrepw.UseSystemPasswordChar = true;
            }

        }

        private void radHien_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (radHien.Checked && !isChecked)
                radHien.Checked = false;
            else
            {
                radHien.Checked = true;
                isChecked = false;
            }
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            BAL_DM_USER xulyuser = new BAL_DM_USER();
            xulyuser.MoTK(comboBox1.Text);
            MessageBox.Show("Tài khoản đã được mở", "Thông báo");
        }
    }
}
