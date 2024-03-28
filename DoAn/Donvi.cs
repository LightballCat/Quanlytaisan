using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Class;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace DoAn
{
    public partial class frmdonvi : Form
    {
        public frmdonvi()
        {
            InitializeComponent();
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from DONVI";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã đơn vị";
            dtgdanhsach.Columns[1].HeaderText = "Tên đơn vị";
            dtgdanhsach.Columns[2].HeaderText = "Trưởng đơn vị";
            dtgdanhsach.Columns[3].HeaderText = "Điện thoại";
            dtgdanhsach.Columns[4].HeaderText = "Email";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql;
            string madv = txtmadv.Text;
            string tendv = txttendv.Text;
            string truongdv = txttruongdv.Text;
            string sdt = txtdt.Text;
            string email = txtemail.Text;
            sql = "insert into DONVI values('" + madv + "',N'" + tendv + "',N'" + truongdv + "','" + sdt + "','" + email + "')";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            string madv = txtmadv.Text;
            string tendv = txttendv.Text;
            string truongdv = txttruongdv.Text;
            string sdt = txtdt.Text;
            string email = txtemail.Text;
            sql = "update DONVI set tendv=N'" + tendv + "',truongdonvi=N'" + truongdv + "',dienthoai='" + sdt + "',email='" + email + "' where madv='" + madv + "'";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            string madv = txtmadv.Text;
            sql = "delete donvi where madv='" + madv + "'";
            if (result == DialogResult.OK)
                Function.RunSQL(sql);
            loaddatagridview();
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from donvi";
            Source = "DoAn.ReportDonvi.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtdt.Text = "";
            txtemail.Text = "";
            txtmadv.Text = "";
            txttendv.Text = "";
            txttimkiem.Text = "";
            txttruongdv.Text = "";
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "madv like '%" + txttimkiem.Text + "%' OR tendv LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void dtgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmadv.Text = dtgdanhsach.CurrentRow.Cells["MaDV"].Value.ToString();
            txttendv.Text = dtgdanhsach.CurrentRow.Cells["TenDV"].Value.ToString();
            txttruongdv.Text = dtgdanhsach.CurrentRow.Cells["Truongdonvi"].Value.ToString();
            txtdt.Text = dtgdanhsach.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtemail.Text = dtgdanhsach.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
