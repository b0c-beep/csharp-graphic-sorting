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
        PictureBox[] pictureBoxes = new PictureBox[Variables.n];
        public int i = 0;
        public int j = 0;
        public int last_i = 0, last_j = 0;
        public Point intermPoint;
        public Size intermSize;

        public SelectionSortIlustratie()
        {
            InitializeComponent();
        }

        public void creeareVector()
        {
            for(int i = 0; i < Variables.n; i++)
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

        private void SelectionSortIlustratie_Load(object sender, EventArgs e)
        {
            buttonExit.Visible = true;
            buttonExit.Enabled = true;


            buttonMeniu.Visible = true;
            buttonMeniu.Visible = true;


            timerSelectionSort.Enabled = true;
            timerSelectionSort.Interval = 1000;

            i = 0;
            j = i + 1;

            this.Size = new Size(50 * (Variables.n + 2) + 20, 50 * (Variables.maxi + 3));

            buttonMeniu.Top = 15;
            buttonMeniu.Left = 15;

            buttonExit.Top = 15;
            buttonExit.Left = 25 + buttonMeniu.Width;

            creeareVector();
            afisareVector();

        }


        
        public void sortareVector()
        {
            if (Variables.v[i] > Variables.v[j])
            {
                intermPoint = pictureBoxes[i].Location;
                intermSize = pictureBoxes[i].Size;

                pictureBoxes[i].Location = pictureBoxes[j].Location;
                pictureBoxes[i].Size = pictureBoxes[j].Size;

                pictureBoxes[j].Location = intermPoint;
                pictureBoxes[j].Size = intermSize;

                int aux = Variables.v[i];
                Variables.v[i] = Variables.v[j];
                Variables.v[j] = aux;
            }
        }


        private void timerSelectionSort_Tick(object sender, EventArgs e)
        {

            sortareVector();
            afisareVector();
            //stergereVector();

            //last_i = i;
            //last_j = j;

            if(i < Variables.n - 1 - 1)
            {
                if (j < Variables.n - 1)
                {
                    j++;
                }
                else
                {
                    i++;
                    j = i + 1;
                }
            }
            else
            {
                timerSelectionSort.Enabled = false;

                //buttonExit.Visible = true;
                //buttonExit.Enabled = true;

                //buttonMeniu.Visible = true;
                //buttonMeniu.Visible = true;
            }
            
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Dispose();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SelectionSortIlustratie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
