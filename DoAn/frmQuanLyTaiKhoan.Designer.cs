namespace DoAn
{
    partial class frmQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radHien = new System.Windows.Forms.RadioButton();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtrepw = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnDatLaiPass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMoKhoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản (Mã nhân viên)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // radHien
            // 
            this.radHien.AutoSize = true;
            this.radHien.Location = new System.Drawing.Point(396, 182);
            this.radHien.Margin = new System.Windows.Forms.Padding(2);
            this.radHien.Name = "radHien";
            this.radHien.Size = new System.Drawing.Size(58, 21);
            this.radHien.TabIndex = 4;
            this.radHien.TabStop = true;
            this.radHien.Text = "Hiện";
            this.radHien.UseVisualStyleBackColor = true;
            this.radHien.CheckedChanged += new System.EventHandler(this.radHien_CheckedChanged);
            this.radHien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radHien_MouseClick_1);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(208, 92);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(184, 22);
            this.txtHoten.TabIndex = 5;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(208, 149);
            this.txtpw.Margin = new System.Windows.Forms.Padding(2);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(184, 22);
            this.txtpw.TabIndex = 6;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // txtrepw
            // 
            this.txtrepw.Location = new System.Drawing.Point(208, 218);
            this.txtrepw.Margin = new System.Windows.Forms.Padding(2);
            this.txtrepw.Name = "txtrepw";
            this.txtrepw.Size = new System.Drawing.Size(184, 22);
            this.txtrepw.TabIndex = 7;
            this.txtrepw.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(154, 278);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(165, 49);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Tạo tài khoản";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnDatLaiPass
            // 
            this.btnDatLaiPass.Location = new System.Drawing.Point(19, 78);
            this.btnDatLaiPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatLaiPass.Name = "btnDatLaiPass";
            this.btnDatLaiPass.Size = new System.Drawing.Size(167, 49);
            this.btnDatLaiPass.TabIndex = 10;
            this.btnDatLaiPass.Text = "Đặt lại mật khẩu";
            this.btnDatLaiPass.UseVisualStyleBackColor = true;
            this.btnDatLaiPass.Click += new System.EventHandler(this.btnDatLaiPass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtpw);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtrepw);
            this.groupBox1.Controls.Add(this.radHien);
            this.groupBox1.Location = new System.Drawing.Point(16, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 348);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm mới người dùng";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(208, 37);
            this.txtManv.Margin = new System.Windows.Forms.Padding(2);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(184, 22);
            this.txtManv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tài khoản (Mã nhân viên)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btnMoKhoa);
            this.groupBox2.Controls.Add(this.btnDatLaiPass);
            this.groupBox2.Location = new System.Drawing.Point(16, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 160);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnMoKhoa
            // 
            this.btnMoKhoa.Location = new System.Drawing.Point(225, 78);
            this.btnMoKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(167, 49);
            this.btnMoKhoa.TabIndex = 11;
            this.btnMoKhoa.Text = "Mở khóa tài khoản";
            this.btnMoKhoa.UseVisualStyleBackColor = true;
            this.btnMoKhoa.Click += new System.EventHandler(this.btnMoKhoa_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(486, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản (Quản lý)";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radHien;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtrepw;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnDatLaiPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMoKhoa;
    }
}