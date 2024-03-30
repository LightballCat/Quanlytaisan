using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmhome : Form
    {
        public string Data { get; set; }
        public string Source { get; set; }
        public string permission { get; set; }
        public frmhome(string quyen)
        {
            InitializeComponent();
            permission = quyen.Trim();
            if(permission == "AssetManager")
            {
                taikhoanmenuitem.Visible = false;
                nhanvienmenuitem.Visible = false;
                nccmenuitem.Visible = false;
            }
            if(permission== "HumanResources")
            {
                taikhoanmenuitem.Visible = false;
                baocaomenuitem.Visible = false;
                taisanmenuitem.Visible = false;
            }
        }

        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permission == "AssetManager")
            {
                Hide();
                frmAssetManager frmAsset = new frmAssetManager();
                frmAsset.Show();
            }
            else
            if (permission == "HumanResources")
            {
                Hide();
                frmHumanResources frmHuman = new frmHumanResources();
                frmHuman.Show();
            }
            else
            {
                Hide();
                frmtrangchu frm = new frmtrangchu();
                frm.Show();
            }
        }

        private void tàiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = "select*from Taisan";
            Source = "DoAn.ReportTaisan.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = "select*from nhanvien";
            Source = "DoAn.ReportNhanvien.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = "select*from nhacungcap";
            Source = "DoAn.ReportNCC.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = "select*from muon_tra";
            Source = "DoAn.ReportMuontran.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void luânChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = "select*from luan_chuyen";
            Source = "DoAn.ReportLuanchuyen.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void nhậtKýSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = "select*from nhat_ky_su_dung";
            Source = "DoAn.ReportNhatky.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmlogin frm = new frmlogin();
            frm.Show();
        }

        private void mượnTrảToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Data = "select*from muon_tra";
            Source = "DoAn.ReportMuontra.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void sửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data = "select*from sua_chua";
            Source = "DoAn.ReportSuachua.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmtaikhoan frm = new frmtaikhoan();
            frm.Show();
        }
    }
}
