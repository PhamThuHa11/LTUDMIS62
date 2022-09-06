using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class Tachten : Form
    {
        string ht, KQ;
        int vt1, vt2;
        public Tachten()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tachten_Load(object sender, EventArgs e)
        {

        }

        private void btnDEM_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.IndexOf(" ");
            vt2 = ht.LastIndexOf(" ");
            KQ = ht.Substring(vt1, vt2-vt1);
            lblKQ.Text =KQ ;
        }

        private void btnDEMTEN_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.IndexOf(" ");
            KQ = ht.Substring(vt1, txtHT.TextLength - vt1);
            lblKQ.Text = KQ;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHODEM_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            KQ = ht.Substring(0, vt1);
            lblKQ.Text = KQ;
        }
    }
}
