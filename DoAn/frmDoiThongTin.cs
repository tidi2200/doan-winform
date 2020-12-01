using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;


namespace DoAn
{
    public partial class frmDoiThongTin : Form
    {
        public frmDoiThongTin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string us = frmDangNhap.us;
        private void frmDoiThongTin_Load(object sender, EventArgs e)
        {
            HienThiHoTen(txtHoTen);
            HienThiNgaySinh(dateTimePicker2);
            HienThiSoDienThoai(txtSDT);
            HienThiDiaChi(txtDiaChi);
            string Gender = HienThiGioiTinh();
            if (Gender == "Nam")
                radNam.Checked = true;
            if (Gender == "Nữ")
                radNu.Checked = true;
        }

        public void HienThiHoTen(TextBox txt)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            txt.Text = xulynhanvien.LayHoTen(us);
        }

        public void HienThiSoDienThoai(TextBox txt)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            txt.Text = xulynhanvien.LaySDT(us);
        }

        public void HienThiDiaChi(TextBox txt)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            txt.Text = xulynhanvien.LayDiaChi(us);
        }

        public void HienThiNgaySinh(DateTimePicker dtp)
        {
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            dtp.Text = xulynhanvien.LayNgaySinh(us);
        }

        public string HienThiGioiTinh()
        {
            string Gender = null;
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            Gender = xulynhanvien.LayGioiTinh(us);
            return Gender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BEL_DM_NHANVIEN nv = new BEL_DM_NHANVIEN();
            BAL_DM_NHANVIEN xulynhanvien = new BAL_DM_NHANVIEN();
            nv.Manv = us;
            nv.Chucvu = xulynhanvien.LayChucVu(us);
            nv.Hoten = txtHoTen.Text;
            if (radNam.Checked == true)
                nv.Gioitinh = "Nam";
            if (radNu.Checked == true)
                nv.Gioitinh = "Nữ";
            nv.Ngaysinh = dateTimePicker2.Value.ToString();
            nv.Diachi = txtDiaChi.Text;
            nv.Sodienthoai = txtSDT.Text;
            xulynhanvien.CapNhatNV(nv);
            MessageBox.Show("Thay đổi thông tin thành công", "Thành công");
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
