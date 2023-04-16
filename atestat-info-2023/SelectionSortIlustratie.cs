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

        public void afisareVector()
        {
            for(int i = 0; i < Variables.n; i++)
            {
                PictureBox PBox1 = new PictureBox();

                PBox1.Location = new Point(50 * i + 50, 50);
                PBox1.Size = new System.Drawing.Size(50, Variables.v[i] * 50);
                PBox1.BackColor = Color.Blue;

                Controls.Add(PBox1);
            }
        }

        private void SelectionSortIlustratie_Load(object sender, EventArgs e)
        {
            this.Size = new Size(50 * (Variables.n + 2) + 20, 50 * (Variables.maxi + 3));
            afisareVector();
        }
    }
}
