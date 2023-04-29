using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class InsertionSortInfo : Form
    {
        public InsertionSortInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_ilustratie_Click(object sender, EventArgs e)
        {
            InsertionSortIlustratie isi = new InsertionSortIlustratie();
            this.Hide();
            isi.Show();
        }

        private void QuickSortInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
