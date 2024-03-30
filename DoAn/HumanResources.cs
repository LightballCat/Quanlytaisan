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
    public partial class frmHumanResources : Form
    {
        public frmHumanResources()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            frmhome frm = new frmhome("HumanResources");
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmnhanvien frm = new frmnhanvien() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmnhacungcap frm = new frmnhacungcap() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelshow.Controls.Clear();
            frmdonvi frm = new frmdonvi() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panelshow.Controls.Add(frm);
            frm.Show();
        }
    }
}
