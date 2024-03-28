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
    public partial class frmsuachua : Form
    {
        private string sqltest;
        public frmsuachua()
        {
            InitializeComponent();
            string sql = "select*from TAISAN";
            Function.Fillcombo(sql, cbomats, "MaTS", "MaTS");
            cbomats.SelectedIndex = -1;
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from SUA_CHUA";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã tài sản";
            dtgdanhsach.Columns[1].HeaderText = "Ngày sửa";
            dtgdanhsach.Columns[2].HeaderText = "Ngày sửa xong";
            dtgdanhsach.Columns[3].HeaderText = "Chi phí";
            dtgdanhsach.Columns[4].HeaderText = "Lý do sửa";
            dtgdanhsach.Columns[5].HeaderText = "Ghi chú";
        }
        private void dtgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbomats.Text = dtgdanhsach.CurrentRow.Cells["MaTS"].Value.ToString();
            txtngaysua.Text = dtgdanhsach.CurrentRow.Cells["NgaySua"].Value.ToString();
            txtngayxong.Text = dtgdanhsach.CurrentRow.Cells["NgaySuaXong"].Value.ToString();
            txtchiphi.Text = dtgdanhsach.CurrentRow.Cells["ChiPhi"].Value.ToString();
            txtlydo.Text = dtgdanhsach.CurrentRow.Cells["LyDoSua"].Value.ToString();
            txtghichu.Text = dtgdanhsach.CurrentRow.Cells["GhiChu"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string mats = cbomats.Text;
                string ngaysua = txtngaysua.Text;
                string ngayxong = txtngayxong.Text;
                string lydo = txtlydo.Text;
                string chiphi = txtchiphi.Text;
                string ghichu = txtghichu.Text;
                sql = "insert into SUA_CHUA values('" + mats + "','" + ngaysua + "','" + ngayxong + "','" + chiphi + "','" + lydo + "',N'" + ghichu + "')";
                Function.RunSQL(sql);
                MessageBox.Show("Thêm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loaddatagridview();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string mats = cbomats.Text;
                string ngaysua = txtngaysua.Text;
                string ngayxong = txtngayxong.Text;
                string lydo = txtlydo.Text;
                string chiphi = txtchiphi.Text;
                string ghichu = txtghichu.Text;
                sql = "update SUA_CHUA set ngaysuaxong='" + ngayxong + "',chiphi='" + chiphi + "',lydosua='" + lydo + "',ghichu='" + ghichu + "' where mats='" + mats + "' and ngaysua='" + ngaysua + "'";
                Function.RunSQL(sql);
                MessageBox.Show("Sửa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loaddatagridview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string mats = cbomats.Text;
                string ngaysua = txtngaysua.Text;
                string ngayxong = txtngayxong.Text;
                sql = "delete SUA_CHUA where mats='" + mats + "' and ngaysua='" + ngaysua + "' and ngaysuaxong='" + ngayxong + "'";
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Function.RunSQL(sql);
                    MessageBox.Show("Xoá thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loaddatagridview();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtchiphi.Text = "";
            txtghichu.Text = "";
            txtlydo.Text = "";
            txtngaysua.Text = "";
            txtngayxong.Text = "";
            txttimkiem.Text = "";
            cbomats.SelectedIndex = -1;
            loaddatagridview();
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from sua_chua";
            Source = "DoAn.ReportSuachua.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "mats like '%" + txttimkiem.Text + "%' OR tents LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
