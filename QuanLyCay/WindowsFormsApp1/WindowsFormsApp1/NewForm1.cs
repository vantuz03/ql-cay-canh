using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewForm1 : Form
    {
        public string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCay;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void MoKetNoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }    
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }    
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        private void HienThiDuLieuQLCay()
        {
            MoKetNoi();

            string query = "select Macay as [Mã Cây], Tenloaicay as [Loại Cây], Tencay as [Tên Cây], Soluong as [Số Lượng], Xuatxu as [Xuất Xứ], Giaban as [Giá Bán]  from CAY, LOAICAY where CAY.Maloaicay = LOAICAY.Maloaicay";

            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "CAY");
            dgvQuanLyCay.DataSource = ds.Tables["CAY"];
        }

        private void HienThiDuLieuQLHoaDon()
        {
            MoKetNoi();

            string query = "select Mahoadon as [Mã hóa đơn], Tenloaicay as [Loại Cây], Ngaynhap as [Ngày Nhập], Xuatxu as [Xuất Xứ], SDT as [Số Điện Thoại], Soluong as [Số Lượng] from LOAICAY, HOADON where LOAICAY.Maloaicay = HOADON.Maloaicay";

            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "HOADON");
            dgvQuanLyHoaDon.DataSource = ds.Tables["HOADON"];
        }

        public NewForm1()
        {
            InitializeComponent();
            HienThiDuLieuQLCay();
        }

        private void btnAddTree_Click(object sender, EventArgs e)
        {
            NewForm2 formAdd = new NewForm2();
            formAdd.FormClosed += new FormClosedEventHandler(formAdd_FormClosed);
            formAdd.ShowDialog();
        }

        private void formAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            HienThiDuLieuQLCay();
        }

        private void NewForm1_Load(object sender, EventArgs e)
        {
            HienThiDuLieuQLCay();
            HienThiDuLieuQLHoaDon();
            
            cbLoaiCay.Items.Clear();
            cbLoaiCay.Items.Add("Cây Ăn Quả");
            cbLoaiCay.Items.Add("Cây Cảnh");

            cbLoaiHoaDon.Items.Clear();
            cbLoaiHoaDon.Items.Add("Cây Ăn Quả");
            cbLoaiHoaDon.Items.Add("Cây Cảnh");
        }

        private void dgvQuanLyCay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            DataGridViewRow row = dgvQuanLyCay.Rows[rowId];
            int maCay = (int)row.Cells[0].Value;
            string[] infoCay = new string[5];
            infoCay[0] = row.Cells[2].Value.ToString();
            infoCay[1] = row.Cells[1].Value.ToString();
            infoCay[2] = row.Cells[4].Value.ToString();
            infoCay[3] = row.Cells[3].Value.ToString();
            infoCay[4] = row.Cells[5].Value.ToString();
            NewForm3 newForm3 = new NewForm3(infoCay);
            newForm3.Show();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string queryBase = "select Tenloaicay as [Loại Cây], Tencay as [Tên Cây], Soluong as [Số Lượng], Xuatxu as [Xuất Xứ], Giaban as [Giá Bán] from CAY, LOAICAY where CAY.Maloaicay = LOAICAY.Maloaicay ";
            string queryCondition = "";
            SqlCommand cmd = new SqlCommand();

            if (!string.IsNullOrWhiteSpace(txtMaCay.Text) && int.TryParse(txtMaCay.Text, out int maCay))
            {
                queryCondition = "and CAY.Macay = @maCay";
                cmd.Parameters.AddWithValue("@maCay", maCay);
            }
            else if (!string.IsNullOrWhiteSpace(txtTenCay.Text))
            {
                queryCondition = "and CAY.Tencay LIKE @tenCay";
                cmd.Parameters.AddWithValue("@tenCay", "%" + txtTenCay.Text + "%");
            }
            else if (cbLoaiCay.SelectedIndex != -1)
            {
                queryCondition = "and LOAICAY.Tenloaicay = @loaiCay";
                cmd.Parameters.AddWithValue("@loaiCay", cbLoaiCay.SelectedItem.ToString());
            }

            string finalQuery = queryBase + queryCondition;
            cmd.CommandText = finalQuery;

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCay;Integrated Security=True"))
            {
                cmd.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                dgvQuanLyCay.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.");
                dgvQuanLyCay.DataSource = null;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string queryBase = "select Tenloaicay as [Loại Cây], Ngaynhap as [Ngày Nhập], Xuatxu as [Xuất Xứ], SDT as [Số Điện Thoại], Soluong as [Số Lượng] from LOAICAY, HOADON where HOADON.Maloaicay = LOAICAY.Maloaicay ";
            string queryCondition = "";
            SqlCommand cmd = new SqlCommand();

            if (!string.IsNullOrWhiteSpace(txtMaHoaDon.Text) && int.TryParse(txtMaHoaDon.Text, out int maHoaDon))
            {
                queryCondition = "and Mahoadon = @maHoaDon";
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
            }
            else if (cbLoaiHoaDon.SelectedIndex != -1)
            {
                queryCondition = "and LOAICAY.Tenloaicay = @loaiCay";
                cmd.Parameters.AddWithValue("@loaiCay", cbLoaiHoaDon.SelectedItem.ToString());
            }

            if (string.IsNullOrEmpty(queryCondition))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
                return;
            }

            string finalQuery = queryBase + queryCondition;
            cmd.CommandText = finalQuery;

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCay;Integrated Security=True"))
            {
                cmd.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                dgvQuanLyHoaDon.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.");
                dgvQuanLyHoaDon.DataSource = null;
            }
        }
    }
}
