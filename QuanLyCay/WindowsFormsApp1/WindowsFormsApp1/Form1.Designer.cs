namespace WindowsFormsApp1
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tpNhapHang = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbNhapLoaiCay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoaPhieuNhap = new System.Windows.Forms.Button();
            this.btnSuaPhieuNhap = new System.Windows.Forms.Button();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.numSLNhap = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.tpThemCay = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cbLoaiCay = new System.Windows.Forms.ComboBox();
            this.txtXuatXuCay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaCay = new System.Windows.Forms.Button();
            this.btnSuaCay = new System.Windows.Forms.Button();
            this.btnThemCay = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenCay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvThemCay = new System.Windows.Forms.DataGridView();
            this.tpTimKiemCay = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimkiemMa = new System.Windows.Forms.TextBox();
            this.txtTimkiemTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgvTimkiemcay = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhapHang.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.tpThemCay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCay)).BeginInit();
            this.tpTimKiemCay.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemcay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpNhapHang
            // 
            this.tpNhapHang.Controls.Add(this.panel4);
            this.tpNhapHang.Controls.Add(this.dgvNhapHang);
            this.tpNhapHang.Location = new System.Drawing.Point(4, 29);
            this.tpNhapHang.Name = "tpNhapHang";
            this.tpNhapHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhapHang.Size = new System.Drawing.Size(997, 553);
            this.tpNhapHang.TabIndex = 3;
            this.tpNhapHang.Text = "Nhập hàng";
            this.tpNhapHang.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbNhapLoaiCay);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnXoaPhieuNhap);
            this.panel4.Controls.Add(this.btnSuaPhieuNhap);
            this.panel4.Controls.Add(this.btnThemPhieuNhap);
            this.panel4.Controls.Add(this.dtpNgayNhap);
            this.panel4.Controls.Add(this.numSLNhap);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.txtXuatXu);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(6, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 138);
            this.panel4.TabIndex = 4;
            // 
            // cbNhapLoaiCay
            // 
            this.cbNhapLoaiCay.FormattingEnabled = true;
            this.cbNhapLoaiCay.Location = new System.Drawing.Point(353, 15);
            this.cbNhapLoaiCay.Name = "cbNhapLoaiCay";
            this.cbNhapLoaiCay.Size = new System.Drawing.Size(132, 28);
            this.cbNhapLoaiCay.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Loại cây :";
            // 
            // btnXoaPhieuNhap
            // 
            this.btnXoaPhieuNhap.BackColor = System.Drawing.Color.White;
            this.btnXoaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPhieuNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaPhieuNhap.Location = new System.Drawing.Point(881, 90);
            this.btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            this.btnXoaPhieuNhap.Size = new System.Drawing.Size(89, 35);
            this.btnXoaPhieuNhap.TabIndex = 6;
            this.btnXoaPhieuNhap.Text = "Xóa";
            this.btnXoaPhieuNhap.UseVisualStyleBackColor = false;
            // 
            // btnSuaPhieuNhap
            // 
            this.btnSuaPhieuNhap.BackColor = System.Drawing.Color.White;
            this.btnSuaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaPhieuNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaPhieuNhap.Location = new System.Drawing.Point(881, 49);
            this.btnSuaPhieuNhap.Name = "btnSuaPhieuNhap";
            this.btnSuaPhieuNhap.Size = new System.Drawing.Size(89, 35);
            this.btnSuaPhieuNhap.TabIndex = 6;
            this.btnSuaPhieuNhap.Text = "Sửa";
            this.btnSuaPhieuNhap.UseVisualStyleBackColor = false;
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.BackColor = System.Drawing.Color.White;
            this.btnThemPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemPhieuNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(881, 8);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(89, 35);
            this.btnThemPhieuNhap.TabIndex = 6;
            this.btnThemPhieuNhap.Text = "Thêm";
            this.btnThemPhieuNhap.UseVisualStyleBackColor = false;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(215, 99);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(107, 26);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // numSLNhap
            // 
            this.numSLNhap.Location = new System.Drawing.Point(313, 55);
            this.numSLNhap.Name = "numSLNhap";
            this.numSLNhap.Size = new System.Drawing.Size(59, 26);
            this.numSLNhap.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ngày nhập";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(237, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Số lượng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(57, 58);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(167, 26);
            this.txtSDT.TabIndex = 3;
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(79, 15);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(180, 26);
            this.txtXuatXu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "SĐT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Xuất xứ:";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Location = new System.Drawing.Point(6, 6);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.Size = new System.Drawing.Size(985, 395);
            this.dgvNhapHang.TabIndex = 3;
            this.dgvNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellClick);
            // 
            // tpThemCay
            // 
            this.tpThemCay.Controls.Add(this.panel1);
            this.tpThemCay.Controls.Add(this.dgvThemCay);
            this.tpThemCay.Location = new System.Drawing.Point(4, 29);
            this.tpThemCay.Name = "tpThemCay";
            this.tpThemCay.Padding = new System.Windows.Forms.Padding(3);
            this.tpThemCay.Size = new System.Drawing.Size(997, 553);
            this.tpThemCay.TabIndex = 1;
            this.tpThemCay.Text = "Thêm cây";
            this.tpThemCay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(this.cbLoaiCay);
            this.panel1.Controls.Add(this.txtXuatXuCay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnXoaCay);
            this.panel1.Controls.Add(this.btnSuaCay);
            this.panel1.Controls.Add(this.btnThemCay);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTenCay);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(6, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 138);
            this.panel1.TabIndex = 4;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(348, 98);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(153, 26);
            this.txtGiaBan.TabIndex = 10;
            // 
            // cbLoaiCay
            // 
            this.cbLoaiCay.FormattingEnabled = true;
            this.cbLoaiCay.Location = new System.Drawing.Point(82, 53);
            this.cbLoaiCay.Name = "cbLoaiCay";
            this.cbLoaiCay.Size = new System.Drawing.Size(186, 28);
            this.cbLoaiCay.TabIndex = 9;
            this.cbLoaiCay.SelectedIndexChanged += new System.EventHandler(this.cbLoaiCay_SelectedIndexChanged);
            // 
            // txtXuatXuCay
            // 
            this.txtXuatXuCay.Location = new System.Drawing.Point(348, 52);
            this.txtXuatXuCay.Name = "txtXuatXuCay";
            this.txtXuatXuCay.Size = new System.Drawing.Size(153, 26);
            this.txtXuatXuCay.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Xuất xứ :";
            // 
            // btnXoaCay
            // 
            this.btnXoaCay.BackColor = System.Drawing.Color.White;
            this.btnXoaCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaCay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaCay.Location = new System.Drawing.Point(881, 90);
            this.btnXoaCay.Name = "btnXoaCay";
            this.btnXoaCay.Size = new System.Drawing.Size(89, 35);
            this.btnXoaCay.TabIndex = 6;
            this.btnXoaCay.Text = "Xóa";
            this.btnXoaCay.UseVisualStyleBackColor = false;
            this.btnXoaCay.Click += new System.EventHandler(this.btnXoaCay_Click);
            // 
            // btnSuaCay
            // 
            this.btnSuaCay.BackColor = System.Drawing.Color.White;
            this.btnSuaCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaCay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaCay.Location = new System.Drawing.Point(881, 49);
            this.btnSuaCay.Name = "btnSuaCay";
            this.btnSuaCay.Size = new System.Drawing.Size(89, 35);
            this.btnSuaCay.TabIndex = 6;
            this.btnSuaCay.Text = "Sửa";
            this.btnSuaCay.UseVisualStyleBackColor = false;
            this.btnSuaCay.Click += new System.EventHandler(this.btnSuaCay_Click);
            // 
            // btnThemCay
            // 
            this.btnThemCay.BackColor = System.Drawing.Color.White;
            this.btnThemCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemCay.Location = new System.Drawing.Point(881, 8);
            this.btnThemCay.Name = "btnThemCay";
            this.btnThemCay.Size = new System.Drawing.Size(89, 35);
            this.btnThemCay.TabIndex = 6;
            this.btnThemCay.Text = "Thêm";
            this.btnThemCay.UseVisualStyleBackColor = false;
            this.btnThemCay.Click += new System.EventHandler(this.btnThemCay_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(82, 95);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(59, 26);
            this.numSoLuong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loại cây:";
            // 
            // txtTenCay
            // 
            this.txtTenCay.Location = new System.Drawing.Point(82, 8);
            this.txtTenCay.Name = "txtTenCay";
            this.txtTenCay.Size = new System.Drawing.Size(419, 26);
            this.txtTenCay.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên cây:";
            // 
            // dgvThemCay
            // 
            this.dgvThemCay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThemCay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemCay.Location = new System.Drawing.Point(6, 6);
            this.dgvThemCay.Name = "dgvThemCay";
            this.dgvThemCay.RowHeadersWidth = 51;
            this.dgvThemCay.Size = new System.Drawing.Size(984, 397);
            this.dgvThemCay.TabIndex = 3;
            this.dgvThemCay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemCay_CellClick);
            // 
            // tpTimKiemCay
            // 
            this.tpTimKiemCay.Controls.Add(this.panel2);
            this.tpTimKiemCay.Controls.Add(this.dgvTimkiemcay);
            this.tpTimKiemCay.Location = new System.Drawing.Point(4, 29);
            this.tpTimKiemCay.Name = "tpTimKiemCay";
            this.tpTimKiemCay.Padding = new System.Windows.Forms.Padding(3);
            this.tpTimKiemCay.Size = new System.Drawing.Size(997, 553);
            this.tpTimKiemCay.TabIndex = 0;
            this.tpTimKiemCay.Text = "Tìm kiếm cây";
            this.tpTimKiemCay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimkiemMa);
            this.panel2.Controls.Add(this.txtTimkiemTen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Location = new System.Drawing.Point(7, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 140);
            this.panel2.TabIndex = 8;
            // 
            // txtTimkiemMa
            // 
            this.txtTimkiemMa.Location = new System.Drawing.Point(82, 82);
            this.txtTimkiemMa.Name = "txtTimkiemMa";
            this.txtTimkiemMa.Size = new System.Drawing.Size(256, 26);
            this.txtTimkiemMa.TabIndex = 3;
            // 
            // txtTimkiemTen
            // 
            this.txtTimkiemTen.Location = new System.Drawing.Point(82, 25);
            this.txtTimkiemTen.Name = "txtTimkiemTen";
            this.txtTimkiemTen.Size = new System.Drawing.Size(256, 26);
            this.txtTimkiemTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã cây:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cây:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimkiem.Location = new System.Drawing.Point(369, 25);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(74, 80);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // dgvTimkiemcay
            // 
            this.dgvTimkiemcay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimkiemcay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiemcay.Location = new System.Drawing.Point(6, 6);
            this.dgvTimkiemcay.Name = "dgvTimkiemcay";
            this.dgvTimkiemcay.RowHeadersWidth = 51;
            this.dgvTimkiemcay.Size = new System.Drawing.Size(994, 392);
            this.dgvTimkiemcay.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTimKiemCay);
            this.tabControl1.Controls.Add(this.tpThemCay);
            this.tabControl1.Controls.Add(this.tpNhapHang);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 608);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ BÁN CÂY";
            this.tpNhapHang.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.tpThemCay.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCay)).EndInit();
            this.tpTimKiemCay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemcay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tpNhapHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaPhieuNhap;
        private System.Windows.Forms.Button btnSuaPhieuNhap;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.NumericUpDown numSLNhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.TabPage tpThemCay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaCay;
        private System.Windows.Forms.Button btnSuaCay;
        private System.Windows.Forms.Button btnThemCay;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenCay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvThemCay;
        private System.Windows.Forms.TabPage tpTimKiemCay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimkiemTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dgvTimkiemcay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtTimkiemMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXuatXuCay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLoaiCay;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cbNhapLoaiCay;
    }
}

