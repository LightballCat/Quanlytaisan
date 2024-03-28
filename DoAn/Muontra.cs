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
using static System.Net.Mime.MediaTypeNames;

namespace DoAn
{
    public partial class frmmuontra : Form
    {
        private string sqltest;
        public frmmuontra()
        {
            InitializeComponent();
            string sql = "select MaTS from TAISAN";
            Function.Fillcombo(sql, cbomats, "Mats", "Mats");
            cbomats.SelectedIndex = -1;
            sql = "select MaNV from NHANVIEN";
            Function.Fillcombo(sql, cbomanv, "Manv", "Manv");
            cbomanv.SelectedIndex = -1;
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from MUON_TRA";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã tài sản";
            dtgdanhsach.Columns[1].HeaderText = "Ma nhân viên";
            dtgdanhsach.Columns[2].HeaderText = "Ngày mượn";
            dtgdanhsach.Columns[3].HeaderText = "Ngày trả";
            dtgdanhsach.Columns[4].HeaderText = "Số lượng mượn";
            dtgdanhsach.Columns[5].HeaderText = "Số lượng trả";
            dtgdanhsach.Columns[6].HeaderText = "Tình trạng";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try { 
                string sql;
                string mats = cbomats.Text;
                string manv = cbomanv.Text;
                string ngaymuon = txtngaymuon.Text;
                string ngaytra = txtngaytra.Text;
                string slmuon = txtslmuon.Text;
                string sltra = txtsltra.Text;
                string tinhtrang = cbotinhtrang.Text;
                sql = "insert into MUON_TRA values('" + mats + "','" + manv + "','" + ngaymuon + "','" + ngaytra + "','" + slmuon + "',N'" + sltra + "','" + tinhtrang + "')";
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
                string manv = cbomanv.Text;
                string ngaymuon = txtngaymuon.Text;
                string ngaytra = txtngaytra.Text;
                string slmuon = txtslmuon.Text;
                string sltra = txtsltra.Text;
                string tinhtrang = cbotinhtrang.Text;
                sql = "update MUON_TRA set ngaymuon='" + ngaymuon + "',ngaytra='" + ngaytra + "',soluongmuon='" + slmuon + "',soluongtra='" + sltra + "',nuocsx=N'" + tinhtrang + "' where mats='" + mats + "' and manv='" + manv + "'";
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
                string manv = cbomanv.Text;
                sql = "delete MUON_TRA where mats='" + mats + "' and manv='" + manv + "'";
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                sqltest = "select mats from taisan";
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
            cbomats.SelectedIndex = -1;
            cbomanv.SelectedIndex = -1;
            cbotinhtrang.SelectedIndex = -1;
            txtngaymuon.Text = "";
            txtngaytra.Text = "";
            txtslmuon.Text = "";
            txtsltra.Text = "";
            txttimkiem.Text = "";
            loaddatagridview();
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from muon_tra";
            Source = "DoAn.ReportMuontra.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void dtgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbomats.Text = dtgdanhsach.CurrentRow.Cells["MaTS"].Value.ToString();
            cbomanv.Text = dtgdanhsach.CurrentRow.Cells["MaNV"].Value.ToString();
            txtngaymuon.Text = dtgdanhsach.CurrentRow.Cells["NgayMuon"].Value.ToString();
            txtngaytra.Text = dtgdanhsach.CurrentRow.Cells["NgayTra"].Value.ToString();
            txtslmuon.Text = dtgdanhsach.CurrentRow.Cells["SoLuongMuon"].Value.ToString();
            txtsltra.Text = dtgdanhsach.CurrentRow.Cells["SoLuongTra"].Value.ToString();
            cbotinhtrang.Text = dtgdanhsach.CurrentRow.Cells["TinhTrang"].Value.ToString();
        }
    }
}
