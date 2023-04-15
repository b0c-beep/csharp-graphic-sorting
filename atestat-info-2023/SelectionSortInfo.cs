using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class SelectionSortInfo : Form
    {
        public SelectionSortInfo()
        {
            InitializeComponent();
        }

        private void button_ilustratie_Click(object sender, EventArgs e)
        {
            SelectionSortIlustratie s = new SelectionSortIlustratie();
            this.Hide();
            s.Show();
        }
    }
}
