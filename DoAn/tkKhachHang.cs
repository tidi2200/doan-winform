using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace DoAn
{
    public partial class tkKhachHang : UserControl
    {
        public tkKhachHang()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Khai báo câu lệnh SQL
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHangHoa;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetKhachHangReport";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Trangthai", cboTrangThai.Text));
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rpvKhachHang.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvKhachHang.LocalReport.ReportPath = "rptKhachHang.rdlc";
            //Nếu có dữ liệu
            MessageBox.Show(ds.Tables[0].Rows.Count.ToString(), "Danh sách khách hàng được thống kê!");
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSetKhachHang";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvKhachHang.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvKhachHang.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvKhachHang.RefreshReport();
            }
        }
        private void KhoiTaoCombobox(ComboBox cbo)
        {
            cbo.Items.Add("0");
            cbo.Items.Add("1");
        }

        private void tkKhachHang_Load(object sender, EventArgs e)
        {
            KhoiTaoCombobox(cboTrangThai);
        }
    }
}
