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
    public partial class frmnhanvien : Form
    {
        private string sqltest;
        public frmnhanvien()
        {
            string sql;
            InitializeComponent();
            sql = "select*from DONVI";
            Function.Fillcombo(sql, cbomadv, "madv", "madv");
            cbomadv.SelectedIndex = -1;
            loaddatagridview();
            dinhdangdulieu();
        }
        public void loaddatagridview()
        {
            DataTable table = new DataTable();
            string sql = "select*from NHANVIEN";
            dtgdanhsach.DataSource = Function.GetDataToDataTable(sql);
            dinhdangdulieu();
            dtgdanhsach.AllowUserToAddRows = false;
            dtgdanhsach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dinhdangdulieu()
        {
            dtgdanhsach.Columns[0].HeaderText = "Mã nhân vien";
            dtgdanhsach.Columns[1].HeaderText = "Tên nhân viên";
            dtgdanhsach.Columns[2].HeaderText = "Địa chỉ";
            dtgdanhsach.Columns[3].HeaderText = "Điện thoại";
            dtgdanhsach.Columns[4].HeaderText = "Mã dịch vụ";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttennv.Text = "";
            txttimkiem.Text = "";
            cbomadv.SelectedIndex = -1;
        }
        public string Data { get; set; }
        public string Source { get; set; }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Data = "select*from nhanvien";
            Source = "DoAn.ReportNhanvien.rdlc";
            FormReport formReport = new FormReport();
            formReport.Data = Data;
            formReport.Source = Source;
            formReport.ShowDialog();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgdanhsach.DataSource;
            bs.Filter = "Manv like '%" + txttimkiem.Text + "%' OR Tennv LIKE '%" + txttimkiem.Text + "%'";
            dtgdanhsach.DataSource = bs;
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql;
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string diachi = txtdiachi.Text;
                string sdt = txtsdt.Text;
                string madv = cbomadv.Text;
                sql = "insert into NHANVIEN values('" + manv + "',N'" + tennv + "',N'" + diachi + "','" + sdt + "','" + madv + "')";
                sqltest = "select manv from nhanvien where manv='" + manv + "'";
                if (!Function.CheckKey(sqltest))
                {
                    Function.RunSQL(sql);
                    MessageBox.Show("Thêm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmanv.Focus();
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
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string diachi = txtdiachi.Text;
                string sdt = txtsdt.Text;
                string madv = cbomadv.Text;
                sql = "update NHANVIEN set tennv=N'" + tennv + "',diachi=N'" + diachi + "',dienthoai='" + sdt + "',madv='" + madv + "' where manv='" + manv + "'";
                sqltest = "select manv from nhanvien where manv='" + manv + "'";
                if (Function.CheckKey(sqltest))
                {
                    Function.RunSQL(sql);
                    MessageBox.Show("Sửa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmanv.Focus();
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
                string manv = txtmanv.Text;
                sql = "delete nhanvien where manv='" + manv + "'";
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                sqltest = "select manv from nhanvien where manv='" + manv + "'";
                if (result == DialogResult.Yes)
                {
                    if (Function.CheckKey(sqltest))
                    {
                        Function.RunSQL(sql);
                        MessageBox.Show("Xoá thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã nhân viên", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtmanv.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loaddatagridview();

        }

        private void dtgdanhsach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dtgdanhsach.CurrentRow.Cells["MaNV"].Value.ToString();
            txttennv.Text = dtgdanhsach.CurrentRow.Cells["TenNV"].Value.ToString();
            txtdiachi.Text = dtgdanhsach.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtsdt.Text = dtgdanhsach.CurrentRow.Cells["DienThoai"].Value.ToString();
            cbomadv.Text = dtgdanhsach.CurrentRow.Cells["MaDV"].Value.ToString();
        }
    }
}
