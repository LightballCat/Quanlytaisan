namespace DoAn
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taikhoanmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taisanmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvienmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.nccmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.baocaomenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaChữaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luânChuyểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậtKýSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = global::DoAn.Properties.Resources.dhnlbg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 473);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taikhoanmenuitem,
            this.quảnLýThôngTinToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.baocaomenuitem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taikhoanmenuitem
            // 
            this.taikhoanmenuitem.Name = "taikhoanmenuitem";
            this.taikhoanmenuitem.Size = new System.Drawing.Size(87, 25);
            this.taikhoanmenuitem.Text = "Tài khoản";
            this.taikhoanmenuitem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            this.quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            this.quảnLýThôngTinToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.quảnLýThôngTinToolStripMenuItem.Text = "Quản lý thông tin";
            this.quảnLýThôngTinToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThôngTinToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taisanmenuitem,
            this.nhanvienmenuitem,
            this.nccmenuitem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // taisanmenuitem
            // 
            this.taisanmenuitem.Name = "taisanmenuitem";
            this.taisanmenuitem.Size = new System.Drawing.Size(180, 26);
            this.taisanmenuitem.Text = "Tài sản";
            this.taisanmenuitem.Click += new System.EventHandler(this.tàiSảnToolStripMenuItem_Click);
            // 
            // nhanvienmenuitem
            // 
            this.nhanvienmenuitem.Name = "nhanvienmenuitem";
            this.nhanvienmenuitem.Size = new System.Drawing.Size(180, 26);
            this.nhanvienmenuitem.Text = "Nhân viên";
            this.nhanvienmenuitem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // nccmenuitem
            // 
            this.nccmenuitem.Name = "nccmenuitem";
            this.nccmenuitem.Size = new System.Drawing.Size(180, 26);
            this.nccmenuitem.Text = "Nhà cung cấp";
            this.nccmenuitem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // baocaomenuitem
            // 
            this.baocaomenuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaChữaToolStripMenuItem,
            this.luânChuyểnToolStripMenuItem,
            this.nhậtKýSửDụngToolStripMenuItem,
            this.mượnTrảToolStripMenuItem});
            this.baocaomenuitem.Name = "baocaomenuitem";
            this.baocaomenuitem.Size = new System.Drawing.Size(76, 25);
            this.baocaomenuitem.Text = "Báo cáo";
            // 
            // sửaChữaToolStripMenuItem
            // 
            this.sửaChữaToolStripMenuItem.Name = "sửaChữaToolStripMenuItem";
            this.sửaChữaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.sửaChữaToolStripMenuItem.Text = "Sửa chữa";
            this.sửaChữaToolStripMenuItem.Click += new System.EventHandler(this.sửaChữaToolStripMenuItem_Click);
            // 
            // luânChuyểnToolStripMenuItem
            // 
            this.luânChuyểnToolStripMenuItem.Name = "luânChuyểnToolStripMenuItem";
            this.luânChuyểnToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.luânChuyểnToolStripMenuItem.Text = "Luân chuyển";
            this.luânChuyểnToolStripMenuItem.Click += new System.EventHandler(this.luânChuyểnToolStripMenuItem_Click);
            // 
            // nhậtKýSửDụngToolStripMenuItem
            // 
            this.nhậtKýSửDụngToolStripMenuItem.Name = "nhậtKýSửDụngToolStripMenuItem";
            this.nhậtKýSửDụngToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.nhậtKýSửDụngToolStripMenuItem.Text = "Nhật ký sử dụng";
            this.nhậtKýSửDụngToolStripMenuItem.Click += new System.EventHandler(this.nhậtKýSửDụngToolStripMenuItem_Click);
            // 
            // mượnTrảToolStripMenuItem
            // 
            this.mượnTrảToolStripMenuItem.Name = "mượnTrảToolStripMenuItem";
            this.mượnTrảToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.mượnTrảToolStripMenuItem.Text = "Mượn trả";
            this.mượnTrảToolStripMenuItem.Click += new System.EventHandler(this.mượnTrảToolStripMenuItem_Click_1);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trường Đại học Nông Lâm Bắc Giang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taisanmenuitem;
        private System.Windows.Forms.ToolStripMenuItem nhanvienmenuitem;
        private System.Windows.Forms.ToolStripMenuItem nccmenuitem;
        private System.Windows.Forms.ToolStripMenuItem baocaomenuitem;
        private System.Windows.Forms.ToolStripMenuItem luânChuyểnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậtKýSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaChữaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taikhoanmenuitem;
    }
}