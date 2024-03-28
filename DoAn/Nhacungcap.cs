using DoAn.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmnhacungcap : Form
    {
        public frmnhacungcap()
        {
            InitializeComponent();
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from NHACUNGCAP";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã NCC";
            dtgdanhsach.Columns[1].HeaderText = "Tên NCC";
            dtgdanhsach.Columns[2].HeaderText = "Địa chỉ";
            dtgdanhsach.Columns[3].HeaderText = "SĐT";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string sql;
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            sql = "insert into nhacungcap values('" + mancc + "',N'" + tenncc + "',N'" + diachi + "','" + sdt + "')";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string sql;
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            sql = "update nhacungcap set tenncc=N'" + tenncc + "',diachi=N'" + diachi + "',dienthoai='" + sdt + "' where mancc='" + mancc + "'"; ;
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            string mancc = txtmancc.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            sql = "delete nhacungcap where mancc='" + mancc + "'";
            if (result == DialogResult.OK)
                Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtsdt.Text = "";
            txttimkiem.Text = "";
            txtdiachi.Text = "";
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from nhacungcap";
            Source = "DoAn.ReportNCC.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "Mancc like '%" + txttimkiem.Text + "%' OR Tenncc LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void dtgdanhsach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmancc.Text = dtgdanhsach.CurrentRow.Cells["MaNCC"].Value.ToString();
            txttenncc.Text = dtgdanhsach.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtdiachi.Text = dtgdanhsach.CurrentRow.Cells["Diachi"].Value.ToString();
            txtsdt.Text = dtgdanhsach.CurrentRow.Cells["Dienthoai"].Value.ToString();
        }
    }
}
