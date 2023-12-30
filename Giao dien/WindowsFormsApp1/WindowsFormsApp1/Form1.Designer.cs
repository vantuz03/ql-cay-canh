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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.btnSuaPhieuNhap = new System.Windows.Forms.Button();
            this.btnXoaPhieuNhap = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemCay = new System.Windows.Forms.Button();
            this.btnSuaCay = new System.Windows.Forms.Button();
            this.btnXoaCay = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimTC = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimLC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimMC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(996, 656);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhập hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(984, 499);
            this.dataGridView3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXoaPhieuNhap);
            this.panel4.Controls.Add(this.btnSuaPhieuNhap);
            this.panel4.Controls.Add(this.btnThemPhieuNhap);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.numericUpDown2);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.txtNCC);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtMaPN);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(7, 512);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 138);
            this.panel4.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Mã phiếu nhập:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(115, 55);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(137, 23);
            this.txtMaPN.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Xuất xứ:";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(68, 15);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(406, 23);
            this.txtNCC.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ngày nhập";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(73, 97);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown2.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(107, 23);
            this.dateTimePicker2.TabIndex = 5;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm cây";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 499);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaCay);
            this.panel1.Controls.Add(this.btnSuaCay);
            this.panel1.Controls.Add(this.btnThemCay);
            this.panel1.Controls.Add(this.numGiaBan);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLC);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTC);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(7, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 138);
            this.panel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên cây:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(64, 8);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(419, 23);
            this.txtTC.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã cây:";
            // 
            // txtMC
            // 
            this.txtMC.Location = new System.Drawing.Point(64, 96);
            this.txtMC.Name = "txtMC";
            this.txtMC.Size = new System.Drawing.Size(101, 23);
            this.txtMC.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loại cây:";
            // 
            // txtLC
            // 
            this.txtLC.Location = new System.Drawing.Point(64, 52);
            this.txtLC.Name = "txtLC";
            this.txtLC.Size = new System.Drawing.Size(419, 23);
            this.txtLC.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(271, 97);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(59, 23);
            this.numSoLuong.TabIndex = 4;
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dg);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm kiếm cây";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(6, 6);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(984, 499);
            this.dg.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimMC);
            this.panel2.Controls.Add(this.txtTimLC);
            this.panel2.Controls.Add(this.txtTimTC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Location = new System.Drawing.Point(7, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 138);
            this.panel2.TabIndex = 8;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimkiem.Location = new System.Drawing.Point(526, 26);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(74, 80);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cây:";
            // 
            // txtTimTC
            // 
            this.txtTimTC.Location = new System.Drawing.Point(72, 17);
            this.txtTimTC.Name = "txtTimTC";
            this.txtTimTC.Size = new System.Drawing.Size(419, 23);
            this.txtTimTC.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại cây:";
            // 
            // txtTimLC
            // 
            this.txtTimLC.Location = new System.Drawing.Point(72, 55);
            this.txtTimLC.Name = "txtTimLC";
            this.txtTimLC.Size = new System.Drawing.Size(419, 23);
            this.txtTimLC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã cây:";
            // 
            // txtTimMC
            // 
            this.txtTimMC.Location = new System.Drawing.Point(72, 93);
            this.txtTimMC.Name = "txtTimMC";
            this.txtTimMC.Size = new System.Drawing.Size(419, 23);
            this.txtTimMC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá bán";
            // 
            // numGiaBan
            // 
            this.numGiaBan.Location = new System.Drawing.Point(424, 97);
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(59, 23);
            this.numGiaBan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "SĐT:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(307, 55);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(167, 23);
            this.txtSDT.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 709);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Giao dien";
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaPhieuNhap;
        private System.Windows.Forms.Button btnSuaPhieuNhap;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaCay;
        private System.Windows.Forms.Button btnSuaCay;
        private System.Windows.Forms.Button btnThemCay;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimLC;
        private System.Windows.Forms.TextBox txtTimTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtTimMC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
    }
}

