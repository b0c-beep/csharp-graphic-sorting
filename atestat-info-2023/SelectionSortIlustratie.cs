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
                PBox1.Tag = "patrat";
                Controls.Add(PBox1);
            }
        }
        public void stergereVector()
        {
            for (int i = 0; i < Variables.n; i++)
            {
                PictureBox PBox1 = new PictureBox();

                PBox1.Location = new Point(50 * i + 50, 50);
                PBox1.Size = new System.Drawing.Size(50, Variables.v[i] * 50);
                PBox1.BackColor = Color.Transparent;

                Controls.Add(PBox1);
            }
        }

        private void SelectionSortIlustratie_Load(object sender, EventArgs e)
        {
            timerSelectionSort.Enabled = true;
            timerSelectionSort.Interval = 1000;

            this.Size = new Size(50 * (Variables.n + 2) + 20, 50 * (Variables.maxi + 3));
            afisareVector();
            stergereVector();
        }

        private void timerSelectionSort_Tick(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < Variables.n - 1; i++) { 
                for (int j = i + 1; j < Variables.n; j++) { 
                    if (Variables.v[i] > Variables.v[j]) {
                        int aux = Variables.v[i];
                        Variables.v[i] = Variables.v[j];
                        Variables.v[j] = aux;
                    }
                    afisareVector();
                    stergereVector();
                }
            }
            */
        }
    }
}
