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
        //variabilele locale utilizate---------------------------------------------------------
        PictureBox[] pictureBoxes = new PictureBox[Variables.n];
        public int i = 0;
        public int j = 0;
        public Point intermPoint;
        public Size intermSize;
        public int interschimbari = 0;
        //-------------------------------------------------------------------------------------

        public SelectionSortIlustratie()
        {
            InitializeComponent();
        }

        //creearea vectorului de imagini-------------------------------------------------------
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
        //--------------------------------------------------------------------------------------

        //afisarea vectorului de imagini--------------------------------------------------------
        public void afisareVector()
        {

            for (int c = 0; c < Variables.n; c++)
            {
          
                pictureBoxes[c].Location = new Point(Variables.lat * c + Variables.lat, Variables.lat);//setarea coordonatelor
                pictureBoxes[c].Size = new System.Drawing.Size(Variables.lat, Variables.v[c] * Variables.lat);//setarea marimii
                pictureBoxes[c].Visible = true;
                
            }
        }
        //----------------------------------------------------------------------------------------

        private void SelectionSortIlustratie_Load(object sender, EventArgs e)
        {
            interschimbari = 0;

            //deblocarea butoanelor-------------------------------------------
            buttonExit.Visible = true;
            buttonExit.Enabled = true;


            buttonMeniu.Visible = true;
            buttonMeniu.Visible = true;
            //----------------------------------------------------------------

            //deblocarea si setarea timer-ului--------------------------------
            timerSelectionSort.Enabled = true;
            timerSelectionSort.Interval = Variables.interval;
            //----------------------------------------------------------------

            i = 0;
            j = i + 1;

            //setarea initiala a coordonatelor butoanelor---------------------
            buttonMeniu.Top = 25;
            buttonMeniu.Left = 15;

            buttonExit.Top = 25;
            buttonExit.Left = 25 + buttonMeniu.Width;
            //----------------------------------------------------------------
            
            //setarea label-ului----------------------------------------------
            labelInterschimbari.Text = "Interschimbari: 0";
            labelInterschimbari.Top = 5;
            labelInterschimbari.Left = 15;
            //----------------------------------------------------------------

            creeareVector();
            afisareVector();

            //actualizarea coordonatelor butoanelor in cazul valorilor mari----
            if (Variables.lat != 50)
            {
                buttonExit.Location = new Point(pictureBoxes[Variables.n - 1].Left + pictureBoxes[Variables.n - 1].Width + 20,
                                                25);

                buttonMeniu.Location = new Point(pictureBoxes[Variables.n - 1].Left + pictureBoxes[Variables.n - 1].Width + 20, 
                                                buttonExit.Top + 40);
            }
            //-------------------------------------------------------------------

            //setarea dimensiunii ferestrei dupa valorile din vector-------------
            this.Size = new Size(Math.Max(Variables.lat * (Variables.n + 2) + 20, Math.Max(buttonMeniu.Left + buttonMeniu.Width + 30, 250)), 
                                 Variables.lat * (Variables.maxi + 3));
            //-------------------------------------------------------------------
        }


        //sortarea valorilor din vectorul de imagini si din cel de valori----------------------
        public void sortareVector()
        {
            if (Variables.v[i] > Variables.v[j])
            {
                //actualizarea label-ului si a numarului de interschimbari--------
                interschimbari++;
                labelInterschimbari.Text = "Interschimbari: " + interschimbari;
                //----------------------------------------------------------------

                //interschimbarea imaginilor--------------------------------------
                intermPoint = pictureBoxes[i].Location;
                intermSize = pictureBoxes[i].Size;

                pictureBoxes[i].Location = pictureBoxes[j].Location;
                pictureBoxes[i].Size = pictureBoxes[j].Size;

                pictureBoxes[j].Location = intermPoint;
                pictureBoxes[j].Size = intermSize;
                //----------------------------------------------------------------

                //interschimbarea valorilor---------------------------------------
                int aux = Variables.v[i];
                Variables.v[i] = Variables.v[j];
                Variables.v[j] = aux;
                //----------------------------------------------------------------
            }
        }
        //---------------------------------------------------------------------------------------

        private void timerSelectionSort_Tick(object sender, EventArgs e)
        {
            //sortarea vectorului la fiecare pas prin timer-----------------------
            sortareVector();
            afisareVector();
            //--------------------------------------------------------------------

            //parcurgerea vectorului dupa algoritm--------------------------------
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
            //--------------------------------------------------------------------

            else
            {
                timerSelectionSort.Enabled = false;//incheierea sortarii
                MessageBox.Show("Sortare Finalizata!");
            }
            
        }

        //trecerea in fereastra initiala-------------------------------------------------------------
        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
            
        }
        //-------------------------------------------------------------------------------------------

        //inchiderea tuturor ferestrelor la iesirea din aplicatie------------------------------------
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SelectionSortIlustratie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //------------------------------------------------------------------------------------------
    }
}
