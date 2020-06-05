namespace QL_ban_sach
{
    partial class FrmTimKiemSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLinhVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenNXB);
            this.groupBox1.Controls.Add(this.txtTenLoaiSach);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo các điều kiện";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SoLuong,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.MaLoaiSach,
            this.MaTG,
            this.MaNXB,
            this.MaLinhVuc,
            this.MaNgonNgu,
            this.Anh,
            this.SoTrang});
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 273);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTimLai);
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 550);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mời chọn các chức năng";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(264, 34);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(121, 64);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(424, 34);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(125, 64);
            this.btnTimLai.TabIndex = 1;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(585, 34);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 64);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên nhà xuất bản";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 8;
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 8;
            this.TenSach.Name = "TenSach";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.MinimumWidth = 8;
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá Bán";
            this.DonGiaBan.MinimumWidth = 8;
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // MaLoaiSach
            // 
            this.MaLoaiSach.DataPropertyName = "MaLoaiSach";
            this.MaLoaiSach.HeaderText = "Mã Loại sách";
            this.MaLoaiSach.MinimumWidth = 8;
            this.MaLoaiSach.Name = "MaLoaiSach";
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã Tác giả";
            this.MaTG.MinimumWidth = 8;
            this.MaTG.Name = "MaTG";
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 8;
            this.MaNXB.Name = "MaNXB";
            // 
            // MaLinhVuc
            // 
            this.MaLinhVuc.DataPropertyName = "MaLinhVuc";
            this.MaLinhVuc.HeaderText = "Mã Lĩnh Vực";
            this.MaLinhVuc.MinimumWidth = 8;
            this.MaLinhVuc.Name = "MaLinhVuc";
            // 
            // MaNgonNgu
            // 
            this.MaNgonNgu.DataPropertyName = "MaNgonNgu";
            this.MaNgonNgu.HeaderText = "Mã ngôn ngữ";
            this.MaNgonNgu.MinimumWidth = 8;
            this.MaNgonNgu.Name = "MaNgonNgu";
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.MinimumWidth = 8;
            this.Anh.Name = "Anh";
            // 
            // SoTrang
            // 
            this.SoTrang.DataPropertyName = "SoTrang";
            this.SoTrang.HeaderText = "Số trang";
            this.SoTrang.MinimumWidth = 8;
            this.SoTrang.Name = "SoTrang";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(234, 58);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(243, 35);
            this.txtTenSach.TabIndex = 6;
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(234, 116);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(243, 35);
            this.txtTenLoaiSach.TabIndex = 7;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(679, 58);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(205, 35);
            this.txtTenNXB.TabIndex = 8;
            // 
            // FrmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTimKiemSach";
            this.Text = "FrmTimKiemSach";
            this.Load += new System.EventHandler(this.FrmTimKiemSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLinhVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTrang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.TextBox txtTenSach;
    }
}