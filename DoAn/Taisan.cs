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
using System.Linq.Expressions;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace DoAn
{
    public partial class frmtaisan : Form
    {
        private string sqltest;
        public frmtaisan()
        {
            InitializeComponent();
            string sql = "select*from LOAITAISAN";
            Function.Fillcombo(sql, cbomaloai, "Maloai", "Maloai");
            cbomaloai.SelectedIndex = -1;
            sql = "select*from nhacungcap";
            Function.Fillcombo(sql, cbomancc, "Mancc", "Mancc");
            cbomancc.SelectedIndex = -1;
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            string sql = "select*from TAISAN";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
            dinhdangdulieu();
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã tài sản";
            dtgdanhsach.Columns[1].HeaderText = "Tên tài sản";
            dtgdanhsach.Columns[2].HeaderText = "Đơn vị tính";
            dtgdanhsach.Columns[3].HeaderText = "Năm sản xuất";
            dtgdanhsach.Columns[4].HeaderText = "Mã loại";
            dtgdanhsach.Columns[5].HeaderText = "Nước SX";
            dtgdanhsach.Columns[6].HeaderText = "Mã NCC";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmats.Text = "";
            txttents.Text = "";
            txtdvt.Text = "";
            txtnamsx.Text = "";
            txtnuocsx.Text = "";
            cbomaloai.SelectedIndex = -1;
            cbomancc.SelectedIndex = -1;
            loaddatagridview();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string mats = txtmats.Text;
                string tents = txttents.Text;
                string dvt = txtdvt.Text;
                string namsx = txtnamsx.Text;
                string maloai = cbomaloai.Text;
                string nuocsx = txtnuocsx.Text;
                string mancc = cbomancc.Text;
                sql = "insert into taisan values('" + mats + "',N'" + tents + "',N'" + dvt + "','" + namsx + "','" + maloai + "',N'" + nuocsx + "','" + mancc + "')";
                sqltest = "select mats from taisan where mats='" + mats + "'";
                if (!Function.CheckKey(sqltest))
                {
                    Function.RunSQL(sql);
                    MessageBox.Show("Thêm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã tài sản đã tồn tại", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmats.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loaddatagridview();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string mats = txtmats.Text;
                string tents = txttents.Text;
                string dvt = txtdvt.Text;
                string namsx = txtnamsx.Text;
                string maloai = cbomaloai.Text;
                string nuocsx = txtnuocsx.Text;
                string mancc = cbomancc.Text;
                sql = "update taisan set tents=N'" + tents + "',donvitinh=N'" + dvt + "',namsx='" + namsx + "',maloai='" + maloai + "',nuocsx=N'" + nuocsx + "',mancc='" + mancc + "' where mats='" + mats + "'";
                sqltest = "select mats from taisan where mats='" + mats + "'";
                if (Function.CheckKey(sqltest))
                {
                    Function.RunSQL(sql);
                    MessageBox.Show("Sửa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã tài sản", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmats.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loaddatagridview();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string mats = txtmats.Text;
                sql = "delete taisan where mats='" + mats + "'";
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                sqltest = "select mats from taisan where mats='" + mats + "'";
                if (result == DialogResult.Yes)
                {
                    if (Function.CheckKey(sqltest))
                    {
                        Function.RunSQL(sql);
                        MessageBox.Show("Xoá thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã tài sản", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtmats.Focus();
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
            txtmats.Text = "";
            txtdvt.Text = "";
            txtnamsx.Text = "";
            txtnuocsx.Text = "";
            txttents.Text = "";
            txttimkiem.Text = "";
            cbomaloai.SelectedIndex = -1;
            cbomancc.SelectedIndex = -1;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "mats like '%" + txttimkiem.Text + "%' OR tents LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void dtgdanhsach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmats.Text = dtgdanhsach.CurrentRow.Cells["MaTS"].Value.ToString();
            txttents.Text = dtgdanhsach.CurrentRow.Cells["Tents"].Value.ToString();
            txtdvt.Text = dtgdanhsach.CurrentRow.Cells["Donvitinh"].Value.ToString();
            txtnamsx.Text = dtgdanhsach.CurrentRow.Cells["namsx"].Value.ToString();
            cbomaloai.Text = dtgdanhsach.CurrentRow.Cells["Maloai"].Value.ToString();
            txtnuocsx.Text = dtgdanhsach.CurrentRow.Cells["Nuocsx"].Value.ToString();
            cbomancc.Text = dtgdanhsach.CurrentRow.Cells["mancc"].Value.ToString();
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from taisan";
            Source = "DoAn.ReportTaisan.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data= Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
