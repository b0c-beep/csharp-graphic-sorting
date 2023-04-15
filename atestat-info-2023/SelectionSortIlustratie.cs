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
            for(int i = 1; i <= Variables.n; i++)
            {
                PictureBox PBox1 = new PictureBox();

                PBox1.Location = new System.Drawing.Point(30 * i + 20, 30);
                PBox1.Size = new System.Drawing.Size(30, Variables.v[--i] * 30 + 20);

                PBox1.BackColor = Color.Blue;

                this.Controls.Add(PBox1);
            }
        }

        private void SelectionSortIlustratie_Load(object sender, EventArgs e)
        {
            this.Size = new Size(100 * (Variables.n + 1), 30 * (Variables.maxi + 1) + 50);
            afisareVector();
        }
    }
}
