using DoAn.Class;
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
    public partial class frmloaitaisan : Form
    {
        public frmloaitaisan()
        {
            InitializeComponent();
            loaddatagridview();
            dinhdangdulieu();
        }

        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from LOAITAISAN";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã loại";
            dtgdanhsach.Columns[1].HeaderText = "Tên loại";
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "Convert(Maloai, 'System.String') like '%" + txttimkiem.Text + "%' OR Tenloai LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void dtgdanhsach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmaloai.Text = dtgdanhsach.CurrentRow.Cells["Maloai"].Value.ToString();
            txttenloai.Text = dtgdanhsach.CurrentRow.Cells["Tenloai"].Value.ToString();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string sql;
            string maloai = txtmaloai.Text;
            string tenloai = txttenloai.Text;
            sql = "insert into loaitaisan values('" + maloai + "',N'" + tenloai + "')";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string sql;
            string maloai = txtmaloai.Text;
            string tenloai = txttenloai.Text;
            sql = "update loaitaisan set tenloai=N'" + tenloai + "' where maloai='" + maloai + "'";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            string maloai = txtmaloai.Text;
            sql = "delete loaitaisan where maloai='" + maloai + "'";
            Function.RunSQL(sql);
            loaddatagridview();
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from loaitaisan";
            Source = "DoAn.ReportLoaitaisan.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";
            txttimkiem.Text = "";
        }
    }
}
