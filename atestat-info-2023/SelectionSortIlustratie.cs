using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class SelectionSortIlustratie : Form
    {
        public SelectionSortIlustratie()
        {
            InitializeComponent();
        }

        private void SelectionSortIlustratie_Load(object sender, EventArgs e)
        {
            this.Size = new Size(100 * (Variables.n + 1), 30 * (Variables.maxi + 1) + 50);
        }
    }
}
