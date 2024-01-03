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

        private void loadCbLoaiCay()
        {
            MoKetNoi();

            DataTable dt = new DataTable();
            string query = "select * from LOAICAY";

            adapter = new SqlDataAdapter(query, sqlCon);
            adapter.Fill(dt);

            cbLoaiCay.DisplayMember = "Tenloaicay";
            cbLoaiCay.ValueMember = "Maloaicay";
            cbLoaiCay.DataSource = dt;
        }

        public NewForm1()
        {
            InitializeComponent();
        }

        private void btnAddTree_Click(object sender, EventArgs e)
        {
            NewForm2 formAdd = new NewForm2();
            formAdd.ShowDialog();
        }

        private void NewForm1_Load(object sender, EventArgs e)
        {
            HienThiDuLieuQLCay();
            HienThiDuLieuQLHoaDon();
            loadCbLoaiCay();
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
    }
}
