using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class BubbleSortIlustratie : Form
    {
        PictureBox[] pictureBoxes = new PictureBox[100];
        public int i = 0;
        public int j = 0;
        public int last_i = 0, last_j = 0;
        public Point intermPoint;
        public Size intermSize;
        public int interschimbari = 0;
        //public bool sortat = true;

        public BubbleSortIlustratie()
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

                pictureBoxes[c].Location = new Point(50 * c + 50, 50);
                pictureBoxes[c].Size = new System.Drawing.Size(50, Variables.v[c] * 50);
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
            if (Variables.v[j] > Variables.v[j + 1])
            {
                interschimbari++;
                labelInterschimbari.Text = "Interschimbari: " + interschimbari;

                intermPoint = pictureBoxes[j].Location;
                intermSize = pictureBoxes[j].Size;

                pictureBoxes[j].Location = pictureBoxes[j + 1].Location;
                pictureBoxes[j].Size = pictureBoxes[j + 1].Size;

                pictureBoxes[j + 1].Location = intermPoint;
                pictureBoxes[j + 1].Size = intermSize;

                int aux = Variables.v[j];
                Variables.v[j] = Variables.v[j + 1];
                Variables.v[j + 1] = aux;
                //sortat = false;
            }
        }

        private void BubbleSortIlustratie_Load(object sender, EventArgs e)
        {
            interschimbari = 0;

            buttonExit.Visible = true;
            buttonExit.Enabled = true;


            buttonMeniu.Visible = true;
            buttonMeniu.Visible = true;


            timerBubbleSort.Enabled = true;
            timerBubbleSort.Interval = Variables.interval;

            i = 0;
            j = 0;

            this.Size = new Size(50 * (Variables.n + 2) + 20, 50 * (Variables.maxi + 3));

            buttonMeniu.Top = 25;
            buttonMeniu.Left = 15;

            buttonExit.Top = 25;
            buttonExit.Left = 25 + buttonMeniu.Width;

            labelInterschimbari.Text = "Interschimbari: 0";
            labelInterschimbari.Top = 5;
            labelInterschimbari.Left = 15;

            creeareVector();
            afisareVector();
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BubbleSortIlustratie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void timerBubbleSort_Tick(object sender, EventArgs e)
        {
            sortareVector();
            afisareVector();

            if (i < Variables.n - 1)
            {
                if (j < Variables.n - i - 1)
                {
                    j++;
                    if (j == Variables.n - i - 1)
                        j = 0;
                }
                else
                {
                    i++;
                  
                    j = 0;
                }
            }
            else
            {
                
                timerBubbleSort.Enabled = false;

            }


        }
    }
}
