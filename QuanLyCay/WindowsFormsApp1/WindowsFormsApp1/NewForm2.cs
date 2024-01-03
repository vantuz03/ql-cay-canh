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
    public partial class NewForm2 : Form
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
        public NewForm2()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKetNoi();

            string loaiCay = "";
            if(cbThemLoaiCay.SelectedIndex == 0)
            {
                loaiCay = "CAYANQUA";
            }    
            else
            {
                loaiCay = "CAYCANH";
            }    
            string tenCay = txtTenCay.Text;
            string xuatXu = txtXuatXuCay.Text;
            string giaBan = txtGiaBan.Text;
            string soLuong = numSoLuong.Value.ToString();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into CAY values ('" + loaiCay + "', N'" + tenCay + "', '" + soLuong + "', N'" + xuatXu + "', '" + giaBan + "')";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if(kq > 0)
            {
                MessageBox.Show("Thêm cây thành công !","Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm cây không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenCay.Text = "";
            cbThemLoaiCay.Text = "";
            txtXuatXuCay.Text = "";
            numSoLuong.Value = 0;
            txtGiaBan.Text = "";
        }

        private void NewForm2_Load(object sender, EventArgs e)
        {
            cbThemLoaiCay.Items.Clear();
            cbThemLoaiCay.Items.Add("Cây Ăn Quả");
            cbThemLoaiCay.Items.Add("Cây Cảnh");
        }

    }
}
