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
    public partial class frmtaikhoan : Form
    {
        public frmtaikhoan()
        {
            InitializeComponent();
            cboquyen.SelectedIndex = -1;
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from TAI_KHOAN";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Tên tài khoan";
            dtgdanhsach.Columns[1].HeaderText = "Mật khẩu";
            dtgdanhsach.Columns[2].HeaderText = "Quyền sử dụng";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql;
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            string quyen = cboquyen.Text;
            sql = "insert into tai_khoan values('" + taikhoan + "','" + matkhau + "','" + quyen + "')";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            string quyen = cboquyen.Text;
            sql = "update tai_khoan set Pass='" + matkhau + "', QuyenSuDung='" + quyen + "' where Username='" + taikhoan + "'";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            string taikhoan = txttaikhoan.Text;
            sql = "delete tai_khoan where Username='" + taikhoan + "'";
            Function.RunSQL(sql);
            loaddatagridview();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txttaikhoan.Text = "";
            txtmatkhau.Text = "";
            txttimkiem.Text = "";
            cboquyen.SelectedIndex = -1;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "Convert(Username, 'System.String') like '%" + txttimkiem.Text + "%' OR Pass LIKE '%" + txttimkiem.Text + "%' OR QuyenSuDung LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void dtgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttaikhoan.Text = dtgdanhsach.CurrentRow.Cells["Username"].Value.ToString();
            txtmatkhau.Text = dtgdanhsach.CurrentRow.Cells["Pass"].Value.ToString();
            cboquyen.Text = dtgdanhsach.CurrentRow.Cells["Quyensudung"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            frmhome frm = new frmhome("");
            frm.Show();
        }
    }
}
