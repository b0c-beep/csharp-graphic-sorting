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
            for(int i = 0; i < Variables.n; i++)
            {
          
                pictureBoxes[i].Location = new Point(50 * i + 50, 50);
                pictureBoxes[i].Size = new System.Drawing.Size(50, Variables.v[i] * 50);
                pictureBoxes[i].Visible = true;
                
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
            timerSelectionSort.Enabled = true;
            timerSelectionSort.Interval = 1000;

            i = 0;
            j = i + 1;

            this.Size = new Size(50 * (Variables.n + 2) + 20, 50 * (Variables.maxi + 3));
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
            }
            
        }
    }
}
