namespace DoAn
{
    partial class NhaCungCap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTen = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.txtTimTheoMaNCC = new System.Windows.Forms.TextBox();
            this.txtTimTheoTenNCC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnCapNhatNCC = new System.Windows.Forms.Button();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.Image = global::DoAn.Properties.Resources._02_Recycle_icon;
            this.btnXoaNCC.Location = new System.Drawing.Point(85, 500);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(123, 52);
            this.btnXoaNCC.TabIndex = 42;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Magneto", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(420, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 28);
            this.label11.TabIndex = 39;
            this.label11.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(237, 73);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 33);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(117, 294);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(170, 22);
            this.txtSDT.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Azure;
            this.label21.Location = new System.Drawing.Point(15, 294);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "SĐT";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::DoAn.Properties.Resources._10_Search_icon1;
            this.btnTimKiem.Location = new System.Drawing.Point(140, 90);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(50, 45);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radTen);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.radMa);
            this.groupBox1.Controls.Add(this.txtTimTheoMaNCC);
            this.groupBox1.Controls.Add(this.txtTimTheoTenNCC);
            this.groupBox1.Location = new System.Drawing.Point(783, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 139);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // radTen
            // 
            this.radTen.AutoSize = true;
            this.radTen.BackColor = System.Drawing.Color.Azure;
            this.radTen.Location = new System.Drawing.Point(15, 65);
            this.radTen.Margin = new System.Windows.Forms.Padding(2);
            this.radTen.Name = "radTen";
            this.radTen.Size = new System.Drawing.Size(91, 21);
            this.radTen.TabIndex = 46;
            this.radTen.Text = "Theo Tên";
            this.radTen.UseVisualStyleBackColor = false;
            this.radTen.CheckedChanged += new System.EventHandler(this.radTen_CheckedChanged);
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.BackColor = System.Drawing.Color.Azure;
            this.radMa.Location = new System.Drawing.Point(15, 31);
            this.radMa.Margin = new System.Windows.Forms.Padding(2);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(85, 21);
            this.radMa.TabIndex = 45;
            this.radMa.Text = "Theo Mã";
            this.radMa.UseVisualStyleBackColor = false;
            this.radMa.CheckedChanged += new System.EventHandler(this.radMa_CheckedChanged);
            // 
            // txtTimTheoMaNCC
            // 
            this.txtTimTheoMaNCC.Location = new System.Drawing.Point(117, 31);
            this.txtTimTheoMaNCC.Name = "txtTimTheoMaNCC";
            this.txtTimTheoMaNCC.Size = new System.Drawing.Size(170, 22);
            this.txtTimTheoMaNCC.TabIndex = 43;
            // 
            // txtTimTheoTenNCC
            // 
            this.txtTimTheoTenNCC.Location = new System.Drawing.Point(117, 65);
            this.txtTimTheoTenNCC.Name = "txtTimTheoTenNCC";
            this.txtTimTheoTenNCC.Size = new System.Drawing.Size(170, 22);
            this.txtTimTheoTenNCC.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(15, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(117, 220);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 22);
            this.txtDiaChi.TabIndex = 12;
            // 
            // btnCapNhatNCC
            // 
            this.btnCapNhatNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatNCC.Image = global::DoAn.Properties.Resources.Settings_icon__1_;
            this.btnCapNhatNCC.Location = new System.Drawing.Point(345, 500);
            this.btnCapNhatNCC.Name = "btnCapNhatNCC";
            this.btnCapNhatNCC.Size = new System.Drawing.Size(135, 52);
            this.btnCapNhatNCC.TabIndex = 41;
            this.btnCapNhatNCC.Text = "Cập Nhật ";
            this.btnCapNhatNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhatNCC.UseVisualStyleBackColor = true;
            this.btnCapNhatNCC.Click += new System.EventHandler(this.btnCapNhatNCC_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(117, 73);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(100, 22);
            this.txtMaNCC.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(15, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Mã NCC";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Azure;
            this.label15.Location = new System.Drawing.Point(15, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tên NCC";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.txtTenNCC);
            this.groupBox6.Controls.Add(this.btnNew);
            this.groupBox6.Controls.Add(this.txtSDT);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txtDiaChi);
            this.groupBox6.Controls.Add(this.txtMaNCC);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(783, 73);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(330, 373);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhà Cung Cấp";
            // 
            // dgvNCC
            // 
            this.dgvNCC.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(13, 26);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(691, 331);
            this.dgvNCC.TabIndex = 0;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvNCC);
            this.groupBox3.Location = new System.Drawing.Point(33, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 373);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.Image = global::DoAn.Properties.Resources.sign_add_icon;
            this.btnThemNCC.Location = new System.Drawing.Point(600, 500);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(135, 52);
            this.btnThemNCC.TabIndex = 44;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(117, 149);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(170, 22);
            this.txtTenNCC.TabIndex = 23;
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhatNCC);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThemNCC);
            this.Name = "NhaCungCap";
            this.Size = new System.Drawing.Size(1166, 631);
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.TextBox txtTimTheoMaNCC;
        private System.Windows.Forms.TextBox txtTimTheoTenNCC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnCapNhatNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.TextBox txtTenNCC;

    }
}
