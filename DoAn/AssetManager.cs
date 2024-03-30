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
    public partial class frmAssetManager : Form
    {
        public frmAssetManager()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            frmhome frm = new frmhome("AssetManager");
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmtaisan frm = new frmtaisan() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmloaitaisan frm = new frmloaitaisan() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmmuontra frm = new frmmuontra() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmsuachua frm = new frmsuachua() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmnhatkysudung frm = new frmnhatkysudung() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmluanchuyen frm = new frmluanchuyen() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }
    }
}
