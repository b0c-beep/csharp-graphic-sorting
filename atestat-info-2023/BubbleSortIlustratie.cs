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
        //variabilele locale folosite---------------------------------------------------------------------
        PictureBox[] pictureBoxes = new PictureBox[100];
        public int i = 0;
        public int j = 0;
        public Point intermPoint;
        public Size intermSize;
        public int interschimbari = 0;
        //------------------------------------------------------------------------------------------------

        public BubbleSortIlustratie()
        {
            InitializeComponent();
        }

        //creearea vectorului de imagini------------------------------------------------------------------
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
        //------------------------------------------------------------------------------------------------

        //afisarea vectorului de imagini------------------------------------------------------------------
        public void afisareVector()
        {

            for (int c = 0; c < Variables.n; c++)
            {

                pictureBoxes[c].Location = new Point(Variables.lat * c + Variables.lat, Variables.lat);//pozitie
                pictureBoxes[c].Size = new System.Drawing.Size(Variables.lat, Variables.v[c] * Variables.lat);//marime
                pictureBoxes[c].Visible = true;

            }
        }
        //--------------------------------------------------------------------------------------------------

        //sortarea vectorului de valori si a vectorului de imagini------------------------------------------
        public void sortareVector()
        {
            if (Variables.v[j] > Variables.v[j + 1])
            {
                //actualizarea numarului de interschimbari----------------------------
                interschimbari++;
                labelInterschimbari.Text = "Interschimbari: " + interschimbari;
                //--------------------------------------------------------------------

                //interschimbarea imaginilor------------------------------------------
                intermPoint = pictureBoxes[j].Location;
                intermSize = pictureBoxes[j].Size;

                pictureBoxes[j].Location = pictureBoxes[j + 1].Location;
                pictureBoxes[j].Size = pictureBoxes[j + 1].Size;

                pictureBoxes[j + 1].Location = intermPoint;
                pictureBoxes[j + 1].Size = intermSize;
                //--------------------------------------------------------------------

                //interschimbarea valorilor-------------------------------------------
                int aux = Variables.v[j];
                Variables.v[j] = Variables.v[j + 1];
                Variables.v[j + 1] = aux;
                //--------------------------------------------------------------------
            }
        }
        //--------------------------------------------------------------------------------------------------

        private void BubbleSortIlustratie_Load(object sender, EventArgs e)
        {
            interschimbari = 0;

            //deblocarea butoanelor---------------------------------------------------
            buttonExit.Visible = true;
            buttonExit.Enabled = true;

            buttonMeniu.Visible = true;
            buttonMeniu.Visible = true;
            //------------------------------------------------------------------------

            //activarea si setarea timerului------------------------------------------
            timerBubbleSort.Enabled = true;
            timerBubbleSort.Interval = Variables.interval;
            //------------------------------------------------------------------------

            i = 0;
            j = 0;

            //setarea initiala a coordonatelor butoanelor-----------------------------
            buttonMeniu.Top = 25;
            buttonMeniu.Left = 15;

            buttonExit.Top = 25;
            buttonExit.Left = 25 + buttonMeniu.Width;
            //------------------------------------------------------------------------

            //setarea coordonatelor label-ului----------------------------------------
            labelInterschimbari.Text = "Interschimbari: 0";
            labelInterschimbari.Top = 5;
            labelInterschimbari.Left = 15;
            //------------------------------------------------------------------------

            //creearea initiala a vectorului de imagini-------------------------------
            creeareVector();
            afisareVector();
            //------------------------------------------------------------------------

            //actualizarea coordonatelor butoanelor daca valorile sunt prea mari------
            if (Variables.lat != 50)
            {
                buttonExit.Location = new Point(pictureBoxes[Variables.n - 1].Left + pictureBoxes[Variables.n - 1].Width + 20,
                                                25);

                buttonMeniu.Location = new Point(pictureBoxes[Variables.n - 1].Left + pictureBoxes[Variables.n - 1].Width + 20,
                                                buttonExit.Top + 40);
            }
            //-------------------------------------------------------------------------

            //setarea dimensiunilor ferestrei------------------------------------------
            this.Size = new Size(Math.Max(Variables.lat * (Variables.n + 2) + 20, Math.Max(buttonMeniu.Left + buttonMeniu.Width + 30, 250)),
                                Variables.lat * (Variables.maxi + 3));
            //-------------------------------------------------------------------------
        }

        //trecerea in fereastra initiala----------------------------------------------------------------------
        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }
        //-----------------------------------------------------------------------------------------------------

        //iesirea din aplicatie--------------------------------------------------------------------------------
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BubbleSortIlustratie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //-----------------------------------------------------------------------------------------------------

        private void timerBubbleSort_Tick(object sender, EventArgs e)
        {
            //sortarea vectorului la fiecare pas---------------------------------------
            sortareVector();
            afisareVector();
            //-------------------------------------------------------------------------

            //parcurgerea vectorului dupa algoritm-------------------------------------
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
            //-------------------------------------------------------------------------
            else
            {
                
                timerBubbleSort.Enabled = false;//finalizarea sortarii
                MessageBox.Show("Sortare Finalizata!");
            }


        }
    }
}
