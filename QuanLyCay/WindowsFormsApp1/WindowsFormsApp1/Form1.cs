using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public DataProvider dataProvider = new DataProvider();
        private int maLoaiCay;
        private int maCay;

        public Form1()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            initTimkiem();
            initThemcay();
            initNhaphang();
        }
        private void initTimkiem()
        {
            loadDgvTimkiemcay();
        }

        private void initThemcay()
        {
            loadDgvThemCay();
            loadCbLoaiCay();
        }

        private void initNhaphang()
        {
            loadDgvNhapHang();
            loadCbNhapLoaiCay();
        }
        private void loadDgvTimkiemcay()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT Macay as [Mã Cây]");
            query.Append(",Tenloaicay as [Loại Cây]");
            query.Append(",Tencay as [Tên Cây]");
            query.Append(",Soluong as [Số Lượng]");
            query.Append(",Xuatxu as [Xuất Xứ]");
            query.Append(",Giaban as [Giá Bán]");
            query.Append(" from CAY, LOAICAY");
            query.Append(" where CAY.Maloaicay = LOAICAY.Maloaicay;");

            dt = dataProvider.execQuery(query.ToString());

            dgvTimkiemcay.DataSource = dt;
        }

        private void loadDgvThemCay()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT Macay as [Mã Cây]");
            query.Append(",Tenloaicay as [Loại Cây]");
            query.Append(",Tencay as [Tên Cây]");
            query.Append(",Soluong as [Số Lượng]");
            query.Append(",Xuatxu as [Xuất Xứ]");
            query.Append(",Giaban as [Giá Bán]");
            query.Append(" from CAY, LOAICAY");
            query.Append(" where CAY.Maloaicay = LOAICAY.Maloaicay;");

            dt = dataProvider.execQuery(query.ToString());

            dgvThemCay.DataSource = dt;
        }

        private void loadDgvNhapHang()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT Mahoadon as [Mã Hóa Đơn]");
            query.Append(",Tenloaicay as [Loại Cây]");
            query.Append(",Ngaynhap as [Ngày Nhập]");
            query.Append(",Xuatxu as [Xuất Xứ]");
            query.Append(",SDT as [Số Điện Thoại]");
            query.Append(",Soluong as [Số Lượng]");
            query.Append(" from HOADON, LOAICAY");
            query.Append(" where HOADON.Maloaicay = LOAICAY.Maloaicay;");

            dt = dataProvider.execQuery(query.ToString());

            dgvNhapHang.DataSource = dt;
        }

        private void loadCbLoaiCay()
        {
            DataTable dt = new DataTable();

            dt = dataProvider.execQuery("SELECT * from LOAICAY");

            cbLoaiCay.DisplayMember = "Tenloaicay";
            cbLoaiCay.ValueMember = "Maloaicay";

            cbLoaiCay.DataSource = dt;
        }

        private void dgvThemCay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            DataGridViewRow row = dgvThemCay.Rows[rowId];

            maCay = (int)row.Cells[0].Value;
            txtTenCay.Text = row.Cells[2].Value.ToString();
            cbLoaiCay.Text = row.Cells[1].Value.ToString();
            txtXuatXuCay.Text = row.Cells[4].Value.ToString();
            numSoLuong.Text = row.Cells[3].Value.ToString();
            txtGiaBan.Text = row.Cells[5].Value.ToString();

            maLoaiCay = (int)dataProvider.execScalar("SELECT Maloaicay FROM LOAICAY where Tenloaicay = N'" + cbLoaiCay.Text + "'");
        }

        private void btnThemCay_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_themCay");
            query.Append(" @maLoaiCay = " + maLoaiCay);
            query.Append(",@tenCay = N'" + txtTenCay.Text + "'");
            query.Append(",@soLuong = " + numSoLuong.Value);
            query.Append(",@xuatXu = N'" + txtXuatXuCay.Text + "'");
            query.Append(",@giaBan = " + txtGiaBan.Text);

            int result = dataProvider.execNonQuery(query.ToString());

            if(result > 0)
            {
                loadDgvThemCay();
                MessageBox.Show("Thêm cây thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm cây không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnSuaCay_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_suaCay");
            query.Append(" @maCay = " + maCay);
            query.Append(",@maLoaiCay = " + maLoaiCay);
            query.Append(",@tenCay = N'" + txtTenCay.Text + "'");
            query.Append(",@soLuong = " + numSoLuong.Value);
            query.Append(",@xuatXu = N'" + txtXuatXuCay.Text + "'");
            query.Append(",@giaBan = " + txtGiaBan.Text);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgvThemCay();
                MessageBox.Show("Cập nhật cây thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật cây không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCay_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa cây " + txtTenCay.Text + "?","Cảnh Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                string query = "DELETE FROM CAY where Macay = " + maCay;
                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadDgvThemCay();
                    MessageBox.Show("Xóa cây cây thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa cây cây không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void cbLoaiCay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            maLoaiCay = (int)comboBox.SelectedValue;
        }

        private void loadCbNhapLoaiCay()
        {
            DataTable dt = new DataTable();

            dt = dataProvider.execQuery("SELECT * from LOAICAY");

            cbNhapLoaiCay.DisplayMember = "Tenloaicay";
            cbNhapLoaiCay.ValueMember = "Maloaicay";

            cbNhapLoaiCay.DataSource = dt;
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            DataGridViewRow row = dgvNhapHang.Rows[rowId];

            //txtMaPN.Text = row.Cells[0].Value.ToString();
            cbNhapLoaiCay.Text = row.Cells[1].Value.ToString();
            dtpNgayNhap.Text = row.Cells[2].Value.ToString();
            txtXuatXu.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            numSLNhap.Text = row.Cells[5].Value.ToString();
        }

    }
}
