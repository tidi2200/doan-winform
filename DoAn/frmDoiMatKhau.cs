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

namespace DoAn
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        bool isChecked = false;
        private void radHien_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radHien.Checked;
            if(isChecked == true)
            {
                txtMatkhauhientai.UseSystemPasswordChar = false;
                txtMatkhaumoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatkhauhientai.UseSystemPasswordChar = true;
                txtMatkhaumoi.UseSystemPasswordChar = true;
            }
            
        }

        private void radHien_MouseClick(object sender, MouseEventArgs e)
        {
            if (radHien.Checked && !isChecked)
                radHien.Checked = false;
            else
            {
                radHien.Checked = true;
                isChecked = false;
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtManv.Text = frmDangNhap.us;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL_DM_USER xulyuser = new BAL_DM_USER();
            if(xulyuser.KiemTraTrung(frmDangNhap.us, txtMatkhauhientai.Text) == false)
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác! Mời nhập lại.", "Thông báo");
                txtMatkhauhientai.Clear();
                txtMatkhauhientai.Focus();
                txtMatkhaumoi.Clear();
            }
            else
            {
                xulyuser.DoiMatKhau(frmDangNhap.us, txtMatkhaumoi.Text);
                DialogResult kq = MessageBox.Show("Đổi thành công", "Thông báo");
                if (kq == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
