using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class Maytinh : Form
    {
        double giatri;
        string pheptinh;
        bool check;
        public Maytinh()
        {
            InitializeComponent();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtkq.Text="0";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((pheptinh=="+")||(pheptinh=="-")||(pheptinh=="/")||(pheptinh=="*"))
            { if (check)
                    check = false;
                txtkq.Text = "0";
            }   
            Button b = sender as Button;
            if (txtkq.Text == "0")
                txtkq.Text = b.Text;
            else
                txtkq.Text += b.Text;
        }
        private void Pheptinh(object sender,EventArgs e)
        {
            Button b = sender as Button;
            giatri = Convert.ToDouble(txtkq.Text);
            pheptinh = b.Text;
            txtkq.Text += b.Text;
            check = true;
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtkq.Clear();
            giatri = 0;
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            switch(pheptinh)
            {
                case "+":
                    txtkq.Text = (giatri + Double.Parse(txtkq.Text)).ToString();
                    break;
                case "-":
                    txtkq.Text = (giatri - Double.Parse(txtkq.Text)).ToString();
                    break;
                case "*":
                    txtkq.Text = (giatri * Double.Parse(txtkq.Text)).ToString();
                    break;
                case "/":
                    txtkq.Text = (giatri / Double.Parse(txtkq.Text)).ToString();
                    break;
            }               
        }
    }
}
