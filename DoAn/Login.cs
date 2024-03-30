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
using DoAn.Class;

namespace DoAn
{
    public partial class frmlogin : Form
    {
        private ToolTip capsLockToolTip = new ToolTip();
        public frmlogin()
        {
            InitializeComponent();
            Function.Connect();
            txttk.Focus();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string user = txttk.Text.Trim();
            string pass = txtmk.Text.Trim();
            string sql = "select QuyenSuDung from TAI_KHOAN where username='" + user + "'";
            string quyen = Function.GetFieldValues(sql);
            sql = "select* from TAI_KHOAN where Username='" + user + "' and Pass='" + pass + "' and QuyenSuDung='admin'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Hide();
                frmhome frm = new frmhome(quyen);
                frm.Show();
            }
            else
            if (Function.CheckKey("select* from TAI_KHOAN where Username='" + user + "' and Pass='" + pass + "' and QuyenSuDung='AssetManager'"))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Hide();
                frmhome frm = new frmhome(quyen);
                frm.Show();
            }
            else
            if (Function.CheckKey("select* from TAI_KHOAN where Username='" + user + "' and Pass='" + pass + "' and QuyenSuDung='HumanResources'"))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Hide();
                frmhome frm = new frmhome(quyen);
                frm.Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Cảnh báo");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '\0') {
                txtmk.PasswordChar = '*';
                btncheckpass.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                txtmk.PasswordChar = '\0';
                btncheckpass.BackgroundImage = Properties.Resources.show;
            }
        }

        private void txttk_KeyUp(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                capsLockToolTip.Show("Caps Lock đang bật!", txttk, 1000);
            }
            else
            {
                capsLockToolTip.Hide(txttk);
            }
        }

        private void txttk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
