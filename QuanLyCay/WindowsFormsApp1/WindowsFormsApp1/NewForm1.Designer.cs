namespace WindowsFormsApp1
{
    partial class NewForm1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddTree = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.cbLoaiCay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenCay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanLyCay = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvQuanLyHoaDon = new System.Windows.Forms.DataGridView();
            this.cbLoaiHoaDon = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyCay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddTree);
            this.tabPage1.Controls.Add(this.btnTK);
            this.tabPage1.Controls.Add(this.cbLoaiCay);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtTenCay);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMaCay);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvQuanLyCay);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1262, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lí cây cảnh";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddTree
            // 
            this.btnAddTree.Location = new System.Drawing.Point(24, 60);
            this.btnAddTree.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTree.Name = "btnAddTree";
            this.btnAddTree.Size = new System.Drawing.Size(144, 36);
            this.btnAddTree.TabIndex = 8;
            this.btnAddTree.Text = "Thêm cây mới";
            this.btnAddTree.UseVisualStyleBackColor = true;
            this.btnAddTree.Click += new System.EventHandler(this.btnAddTree_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(1126, 16);
            this.btnTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(103, 36);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // cbLoaiCay
            // 
            this.cbLoaiCay.FormattingEnabled = true;
            this.cbLoaiCay.Location = new System.Drawing.Point(861, 22);
            this.cbLoaiCay.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiCay.Name = "cbLoaiCay";
            this.cbLoaiCay.Size = new System.Drawing.Size(198, 28);
            this.cbLoaiCay.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại cây:";
            // 
            // txtTenCay
            // 
            this.txtTenCay.Location = new System.Drawing.Point(474, 22);
            this.txtTenCay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenCay.Name = "txtTenCay";
            this.txtTenCay.Size = new System.Drawing.Size(198, 26);
            this.txtTenCay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên cây:";
            // 
            // txtMaCay
            // 
            this.txtMaCay.Location = new System.Drawing.Point(94, 22);
            this.txtMaCay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaCay.Name = "txtMaCay";
            this.txtMaCay.Size = new System.Drawing.Size(198, 26);
            this.txtMaCay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã cây:";
            // 
            // dgvQuanLyCay
            // 
            this.dgvQuanLyCay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyCay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyCay.Location = new System.Drawing.Point(7, 113);
            this.dgvQuanLyCay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvQuanLyCay.Name = "dgvQuanLyCay";
            this.dgvQuanLyCay.RowHeadersWidth = 51;
            this.dgvQuanLyCay.RowTemplate.Height = 24;
            this.dgvQuanLyCay.Size = new System.Drawing.Size(1250, 488);
            this.dgvQuanLyCay.TabIndex = 0;
            this.dgvQuanLyCay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyCay_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbLoaiHoaDon);
            this.tabPage2.Controls.Add(this.txtMaHoaDon);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnTim);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvQuanLyHoaDon);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1262, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lí hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(134, 37);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(198, 26);
            this.txtMaHoaDon.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1133, 31);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(103, 36);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại Cây :";
            // 
            // dgvQuanLyHoaDon
            // 
            this.dgvQuanLyHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyHoaDon.Location = new System.Drawing.Point(7, 106);
            this.dgvQuanLyHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvQuanLyHoaDon.Name = "dgvQuanLyHoaDon";
            this.dgvQuanLyHoaDon.RowHeadersWidth = 51;
            this.dgvQuanLyHoaDon.RowTemplate.Height = 24;
            this.dgvQuanLyHoaDon.Size = new System.Drawing.Size(1250, 488);
            this.dgvQuanLyHoaDon.TabIndex = 7;
            // 
            // cbLoaiHoaDon
            // 
            this.cbLoaiHoaDon.FormattingEnabled = true;
            this.cbLoaiHoaDon.Location = new System.Drawing.Point(786, 37);
            this.cbLoaiHoaDon.Name = "cbLoaiHoaDon";
            this.cbLoaiHoaDon.Size = new System.Drawing.Size(201, 28);
            this.cbLoaiHoaDon.TabIndex = 17;
            // 
            // NewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 666);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN CÂY";
            this.Load += new System.EventHandler(this.NewForm1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyCay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvQuanLyCay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtMaCay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiCay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenCay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnAddTree;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvQuanLyHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiHoaDon;
    }
}