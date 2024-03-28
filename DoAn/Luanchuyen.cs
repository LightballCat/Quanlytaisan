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
    public partial class frmluanchuyen : Form
    {
        private string sqltest;
        public frmluanchuyen()
        {
            string sql;
            InitializeComponent();
            sql = "select*from TAISAN";
            Function.Fillcombo(sql, cbomats, "mats", "mats");
            cbomats.SelectedIndex = -1;
            sql = "select*from DONVI";
            Function.Fillcombo(sql, cbomadvden, "madv", "madv");
            cbomadvden.SelectedIndex = -1;
            Function.Fillcombo(sql, cbomadvdi, "madv", "madv");
            cbomadvdi.SelectedIndex = -1;
            sql = "select*from NHANVIEN";
            Function.Fillcombo(sql, cbomanv, "manv", "manv");
            cbomanv.SelectedIndex = -1;
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from LUAN_CHUYEN";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã tài sản";
            dtgdanhsach.Columns[1].HeaderText = "Mã đơn vị đi";
            dtgdanhsach.Columns[2].HeaderText = "Mã đơn vị đến";
            dtgdanhsach.Columns[3].HeaderText = "Ngày chuyển";
            dtgdanhsach.Columns[4].HeaderText = "Số lượng";
            dtgdanhsach.Columns[5].HeaderText = "Mã nhân viên";
        }

        private void dtgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbomats.Text = dtgdanhsach.CurrentRow.Cells["MaTS"].Value.ToString();
            cbomadvdi.Text = dtgdanhsach.CurrentRow.Cells["MaDVDi"].Value.ToString();
            cbomadvden.Text = dtgdanhsach.CurrentRow.Cells["MaDVDen"].Value.ToString();
            txtngaychuyen.Text = dtgdanhsach.CurrentRow.Cells["NgayChuyen"].Value.ToString();
            txtsl.Text = dtgdanhsach.CurrentRow.Cells["SoLuong"].Value.ToString();
            cbomanv.Text = dtgdanhsach.CurrentRow.Cells["MaNV"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string mats = cbomats.Text;
                string madvdi = cbomadvdi.Text;
                string madvden = cbomadvden.Text;
                string ngaychuyen = txtngaychuyen.Text;
                string soluong = txtsl.Text;
                string manv = cbomanv.Text;
                sql = "insert into LUAN_CHUYEN values('" + mats + "','" + madvdi + "','" + madvden + "','" + ngaychuyen + "','" + soluong + "','" + manv + "')";
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
                string madvdi = cbomadvdi.Text;
                string madvden = cbomadvden.Text;
                string ngaychuyen = txtngaychuyen.Text;
                string soluong = txtsl.Text;
                string manv = cbomanv.Text;
                sql = "update LUAN_CHUYEN set madvdi=N'" + madvdi + "',madvden=N'" + madvden + "',ngaychuyen='" + ngaychuyen + "',soluong='" + soluong + "' where manv='" + manv + "' and manv='" + manv + "'";
                sqltest = "select * from nhanvien where manv='" + manv + "'";
                if (Function.CheckKey(sqltest))
                {
                    Function.RunSQL(sql);
                    MessageBox.Show("Sửa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                string madvdi = cbomadvdi.Text;
                string madvden = cbomadvden.Text;
                sql = "delete LUAN_CHUYEN where manv='" + manv + "', mats='" + mats + "', madvdi=N'" + madvdi + "' and madvden=N'" + madvden + "'";
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                sqltest = "select * from LUAN_CHUYEN where manv='" + manv + "', mats='" + mats + "', madvdi=N'" + madvdi + "' and madvden=N'" + madvden + "'";
                if (result == DialogResult.Yes)
                {
                    if (Function.CheckKey(sqltest))
                    {
                        Function.RunSQL(sql);
                        MessageBox.Show("Xoá thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

            txtsl.Text = "";
            txttimkiem.Text = "";
            txtngaychuyen.Text = "";
            cbomanv.SelectedIndex = -1;
            cbomadvden.SelectedIndex = -1;
            cbomadvdi.SelectedIndex = -1;
            cbomats.SelectedIndex = -1;
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from luan_chuyen";
            Source = "DoAn.ReportLuanchuyen.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "Manv like '%" + txttimkiem.Text + "%' OR mats LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }
    }
}
