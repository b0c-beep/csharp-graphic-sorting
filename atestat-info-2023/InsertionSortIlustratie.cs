using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class InsertionSortIlustratie : Form
    {
        PictureBox[] pictureBoxes = new PictureBox[100];
        public int i = 0;
        public int j = 0;
        public int p;
        public Point intermPoint;
        public Size intermSize;
        public int interschimbari = 0;

        public InsertionSortIlustratie()
        {
            InitializeComponent();
        }

        public void creeareVector()
        {
            int i;
            for (i = 0; i < Variables.n; i++)
            {
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].Name = "pbBox" + i;
                pictureBoxes[i].Tag = "pbbox";
                pictureBoxes[i].BackColor = Color.Blue;
                Controls.Add(pictureBoxes[i]);
                pictureBoxes[i].Visible = false;
            }

        }

        public void afisareVector()
        {

            for (int c = 0; c < Variables.n; c++)
            {

                pictureBoxes[c].Location = new Point(Variables.lat * c + Variables.lat, Variables.lat);
                pictureBoxes[c].Size = new System.Drawing.Size(Variables.lat, Variables.v[c] * Variables.lat);
                pictureBoxes[c].Visible = true;

            }
        }
        public void stergereVector()
        {
            for (int i = 0; i < Variables.n; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }

        public void sortareVector()
        {
            if (Variables.v[p] < Variables.v[p - 1])
            {
                interschimbari++;
                labelInterschimbari.Text = "Interschimbari: " + interschimbari;

                intermPoint = pictureBoxes[p].Location;
                intermSize = pictureBoxes[p].Size;

                pictureBoxes[p].Location = pictureBoxes[p - 1].Location;
                pictureBoxes[p].Size = pictureBoxes[p - 1].Size;

                pictureBoxes[p - 1].Location = intermPoint;
                pictureBoxes[p - 1].Size = intermSize;

                int aux = Variables.v[p];
                Variables.v[p] = Variables.v[p - 1];
                Variables.v[p - 1] = aux;
                
            }
        }

        private void QuickSortIlustratie_Load(object sender, EventArgs e)
        {
            interschimbari = 0;

            buttonExit.Visible = true;
            buttonExit.Enabled = true;


            buttonMeniu.Visible = true;
            buttonMeniu.Visible = true;


            timerQuickSort.Enabled = true;
            timerQuickSort.Interval = Variables.interval;

            i = 1;
            p = i;
            j = 0;

            this.Size = new Size(Math.Max(Variables.lat * (Variables.n + 2) + 20, 250), Variables.lat * (Variables.maxi + 3));

            buttonMeniu.Top = 25;
            buttonMeniu.Left = 15;

            buttonExit.Top = 25;
            buttonExit.Left = 25 + buttonMeniu.Width;

            if (Variables.lat != 50)
            {
                buttonMeniu.Location = new Point(buttonExit.Left - 15, buttonExit.Top + 40);
            }

            labelInterschimbari.Text = "Interschimbari: 0";
            labelInterschimbari.Top = 5;
            labelInterschimbari.Left = 15;

            creeareVector();
            afisareVector();
        }

        private void QuickSortIlustratie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }

        private void timerQuickSort_Tick(object sender, EventArgs e)
        {
            //sortareVector();
            //afisareVector();

            if (i < Variables.n)
            {
                //p = i;
                if(p > 0)
                {
                    sortareVector();
                    p--;
                    afisareVector();
                    
                }
                else
                {
                    i++;
                    p = i;
                }
            }
            else
            {
                afisareVector();
                timerQuickSort.Enabled = false;
                MessageBox.Show("Sortare Finalizata!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
