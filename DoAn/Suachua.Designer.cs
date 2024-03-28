
namespace DoAn
{
    partial class frmsuachua
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgdanhsach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.bt_baocao = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_tenpb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtngayxong = new System.Windows.Forms.DateTimePicker();
            this.txtngaysua = new System.Windows.Forms.DateTimePicker();
            this.cbomats = new System.Windows.Forms.ComboBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.txtchiphi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsach)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txttimkiem);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Controls.Add(this.btnxoa);
            this.panel3.Controls.Add(this.btnsua);
            this.panel3.Location = new System.Drawing.Point(0, 257);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 36);
            this.panel3.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(262, 6);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(197, 26);
            this.txttimkiem.TabIndex = 8;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = global::DoAn.Properties.Resources.add1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(488, 3);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 29);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = global::DoAn.Properties.Resources.del1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(675, 3);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 29);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa bỏ";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = global::DoAn.Properties.Resources.edit1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(581, 3);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(89, 29);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgdanhsach);
            this.panel5.Location = new System.Drawing.Point(0, 297);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(779, 207);
            this.panel5.TabIndex = 37;
            // 
            // dtgdanhsach
            // 
            this.dtgdanhsach.AllowUserToAddRows = false;
            this.dtgdanhsach.AllowUserToDeleteRows = false;
            this.dtgdanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdanhsach.Location = new System.Drawing.Point(11, 12);
            this.dtgdanhsach.Margin = new System.Windows.Forms.Padding(2);
            this.dtgdanhsach.Name = "dtgdanhsach";
            this.dtgdanhsach.ReadOnly = true;
            this.dtgdanhsach.RowHeadersVisible = false;
            this.dtgdanhsach.RowTemplate.Height = 24;
            this.dtgdanhsach.Size = new System.Drawing.Size(757, 185);
            this.dtgdanhsach.TabIndex = 0;
            this.dtgdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdanhsach_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.bt_baocao);
            this.panel1.Controls.Add(this.bt_reset);
            this.panel1.Controls.Add(this.tb_diachi);
            this.panel1.Controls.Add(this.tb_tenpb);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 180);
            this.panel1.TabIndex = 12;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(229, 28);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(154, 23);
            this.tb_sdt.TabIndex = 57;
            // 
            // bt_baocao
            // 
            this.bt_baocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_baocao.Location = new System.Drawing.Point(674, 148);
            this.bt_baocao.Margin = new System.Windows.Forms.Padding(2);
            this.bt_baocao.Name = "bt_baocao";
            this.bt_baocao.Size = new System.Drawing.Size(89, 29);
            this.bt_baocao.TabIndex = 56;
            this.bt_baocao.Text = "In báo cáo";
            this.bt_baocao.UseVisualStyleBackColor = true;
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Location = new System.Drawing.Point(643, 148);
            this.bt_reset.Margin = new System.Windows.Forms.Padding(2);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(27, 29);
            this.bt_reset.TabIndex = 55;
            this.bt_reset.UseVisualStyleBackColor = true;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diachi.Location = new System.Drawing.Point(434, 28);
            this.tb_diachi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(154, 23);
            this.tb_diachi.TabIndex = 3;
            // 
            // tb_tenpb
            // 
            this.tb_tenpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenpb.Location = new System.Drawing.Point(16, 29);
            this.tb_tenpb.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenpb.Name = "tb_tenpb";
            this.tb_tenpb.Size = new System.Drawing.Size(154, 23);
            this.tb_tenpb.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(226, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên phòng ban";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(779, 67);
            this.panel4.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sửa chữa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ngày sửa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã tài sản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtngayxong);
            this.panel2.Controls.Add(this.txtngaysua);
            this.panel2.Controls.Add(this.cbomats);
            this.panel2.Controls.Add(this.txtghichu);
            this.panel2.Controls.Add(this.txtlydo);
            this.panel2.Controls.Add(this.btnbaocao);
            this.panel2.Controls.Add(this.btnlammoi);
            this.panel2.Controls.Add(this.txtchiphi);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 180);
            this.panel2.TabIndex = 35;
            // 
            // txtngayxong
            // 
            this.txtngayxong.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayxong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngayxong.Location = new System.Drawing.Point(403, 32);
            this.txtngayxong.Name = "txtngayxong";
            this.txtngayxong.Size = new System.Drawing.Size(153, 23);
            this.txtngayxong.TabIndex = 57;
            // 
            // txtngaysua
            // 
            this.txtngaysua.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaysua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaysua.Location = new System.Drawing.Point(206, 32);
            this.txtngaysua.Name = "txtngaysua";
            this.txtngaysua.Size = new System.Drawing.Size(153, 23);
            this.txtngaysua.TabIndex = 57;
            // 
            // cbomats
            // 
            this.cbomats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomats.FormattingEnabled = true;
            this.cbomats.Location = new System.Drawing.Point(18, 29);
            this.cbomats.Name = "cbomats";
            this.cbomats.Size = new System.Drawing.Size(153, 28);
            this.cbomats.TabIndex = 55;
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(403, 97);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(2);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(154, 26);
            this.txtghichu.TabIndex = 3;
            // 
            // txtlydo
            // 
            this.txtlydo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlydo.Location = new System.Drawing.Point(206, 97);
            this.txtlydo.Margin = new System.Windows.Forms.Padding(2);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(154, 26);
            this.txtlydo.TabIndex = 2;
            // 
            // btnbaocao
            // 
            this.btnbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaocao.Image = global::DoAn.Properties.Resources.print;
            this.btnbaocao.Location = new System.Drawing.Point(660, 147);
            this.btnbaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(103, 29);
            this.btnbaocao.TabIndex = 7;
            this.btnbaocao.Text = "Báo cáo";
            this.btnbaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Image = global::DoAn.Properties.Resources.load;
            this.btnlammoi.Location = new System.Drawing.Point(615, 147);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(41, 29);
            this.btnlammoi.TabIndex = 6;
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // txtchiphi
            // 
            this.txtchiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchiphi.Location = new System.Drawing.Point(18, 97);
            this.txtchiphi.Margin = new System.Windows.Forms.Padding(2);
            this.txtchiphi.Name = "txtchiphi";
            this.txtchiphi.Size = new System.Drawing.Size(154, 26);
            this.txtchiphi.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Ghi chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Lý do sửa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Chi phí";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ngày sửa xong";
            // 
            // frmsuachua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(779, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "frmsuachua";
            this.Text = "Sửa chữa";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgdanhsach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Button bt_baocao;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_tenpb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.TextBox txtchiphi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.ComboBox cbomats;
        private System.Windows.Forms.DateTimePicker txtngayxong;
        private System.Windows.Forms.DateTimePicker txtngaysua;
    }
}