using System;
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
    public partial class NewForm3 : Form
    {
        public NewForm3()
        {
            InitializeComponent();          
        }

        public NewForm3(string[] infoCay) : this()
        {
            txtTenCay.Text = infoCay[0];
            txtLoaiCay.Text = infoCay[1];
            cbSuaLoaiCay.Text = infoCay[1];
            txtXuatXuCay.Text = infoCay[2];
            txtSoLuong.Text = infoCay[3];
            numSoLuong.Text = infoCay[3];
            txtGiaBan.Text = infoCay[4];
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (btnSua.Visible)
                this.Close();
            else
            {
                txtTenCay.ReadOnly = true;
                txtLoaiCay.Visible = true;
                cbSuaLoaiCay.Visible = false;
                txtXuatXuCay.ReadOnly = true;
                txtSoLuong.Visible = true;
                numSoLuong.Visible = false;
                txtGiaBan.ReadOnly = true;
                btnSua.Visible = true;
                btnCapNhat.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenCay.ReadOnly = false;
            txtLoaiCay.Visible = false;
            cbSuaLoaiCay.Visible = true;
            txtXuatXuCay.ReadOnly = false;
            txtSoLuong.Visible = false;
            numSoLuong.Visible = true;
            txtGiaBan.ReadOnly = false;
            btnSua.Visible = false;
            btnCapNhat.Visible = true;
        }
    }
}
