using DoAn.Class;
using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    public partial class frmnhatkysudung : Form
    {
        private string sqltest;
        public frmnhatkysudung()
        {
            InitializeComponent();
            loaddatagridview();
            dinhdangdulieu();
            string sql = "select MaNV from NHANVIEN";
            Function.Fillcombo(sql, cbomanv, "Manv", "Manv");
            cbomanv.SelectedIndex = -1;
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from NHAT_KY_SU_DUNG";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã nhân viên";
            dtgdanhsach.Columns[1].HeaderText = "Tên phòng máy";
            dtgdanhsach.Columns[2].HeaderText = "Ca dạy";
            dtgdanhsach.Columns[3].HeaderText = "Ngày dạy";
            dtgdanhsach.Columns[4].HeaderText = "Tình trạng nhận";
            dtgdanhsach.Columns[5].HeaderText = "Tình trạng trả";
            dtgdanhsach.Columns[6].HeaderText = "Kiến nghị";
        }
        private void dtgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbomanv.Text = dtgdanhsach.CurrentRow.Cells["MaNV"].Value.ToString();
            txttenphong.Text = dtgdanhsach.CurrentRow.Cells["Tenphongmay"].Value.ToString();
            txtcaday.Text = dtgdanhsach.CurrentRow.Cells["Caday"].Value.ToString();
            txtngayday.Text = dtgdanhsach.CurrentRow.Cells["Ngayday"].Value.ToString();
            cbonhan.Text = dtgdanhsach.CurrentRow.Cells["Tinhtrangnhan"].Value.ToString();
            cbotra.Text = dtgdanhsach.CurrentRow.Cells["Tinhtrangtra"].Value.ToString();
            txtkiennghi.Text = dtgdanhsach.CurrentRow.Cells["Kiennghi"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string manv = cbomanv.Text;
                string tenphong = txttenphong.Text;
                string caday = txtcaday.Text;
                string ngayday = txtngayday.Text;
                string nhan = cbonhan.Text;
                string tra = cbotra.Text;
                string kiennghi = txtkiennghi.Text;
                sql = "insert into NHAT_KY_SU_DUNG values('" + manv + "',N'" + tenphong + "',N'" + caday + "','" + ngayday + "',N'" + nhan + "',N'" + tra + "',N'" + kiennghi + "')";
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
                string manv = cbomanv.Text;
                string tenphong = txttenphong.Text;
                string caday = txtcaday.Text;
                string ngayday = txtngayday.Text;
                string nhan = cbonhan.Text;
                string tra = cbotra.Text;
                string kiennghi = txtkiennghi.Text;
                string themnhan = txtthemnhan.Text;
                string themtra = txtthemtra.Text;
                sql = "update NHAT_KY_SU_DUNG set caday='" + caday + "',ngayday='" + ngayday + "',tinhtrangnhat=N'" + nhan + "("+themnhan+")',tinhtrangtra=N'" + tra + "("+themtra+")',kiennghi=N'" + kiennghi + "' where manv='" + manv + "' and tenphongmay=N'" + tenphong + "'";
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
                string manv = cbomanv.Text;
                string tenphong = txttenphong.Text;
                sql = "delete NHAT_KY_SU_DUNG where manv='" + manv + "' and tenphongmay=N'" + tenphong + "'";
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
            txtkiennghi.Text = "";
            txtcaday.Text = "";
            txttenphong.Text = "";
            txtngayday.Text = "";
            txtthemnhan.Text = "";
            txttimkiem.Text = "";
            txtthemtra.Text = "";
            cbomanv.SelectedIndex = -1;
            cbonhan.SelectedIndex = -1;
            cbotra.SelectedIndex = -1;
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from nhat_ky_su_dung";
            Source = "DoAn.ReportNhatky.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "manv like '%" + txttimkiem.Text + "%' OR caday LIKE '%" + txttimkiem.Text + "%'  OR tenphongmay LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void cbonhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonhan.SelectedIndex == 1)
                txtthemnhan.Visible = true;
            else
            {
                txtthemnhan.Visible = false;
                txtthemnhan.Text = "";
            }
        }

        private void cbotra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotra.SelectedIndex == 1)
                txtthemtra.Visible = true;
            else
            {
                txtthemtra.Visible = false;
                txtthemtra.Text = "";
            }
        }
    }
}
