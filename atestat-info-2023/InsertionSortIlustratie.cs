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
        //variabilele locale folosite----------------------------------------------------------------
        PictureBox[] pictureBoxes = new PictureBox[100];
        public int i = 0;
        public int j = 0;
        public int p;
        public Point intermPoint;
        public Size intermSize;
        public int interschimbari = 0;
        //-------------------------------------------------------------------------------------------

        public InsertionSortIlustratie()
        {
            InitializeComponent();
        }

        //crearea vectorului de imagini-------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------------

        //afisarea vectorului de imagini-------------------------------------------------------------
        public void afisareVector()
        {

            for (int c = 0; c < Variables.n; c++)
            {

                pictureBoxes[c].Location = new Point(Variables.lat * c + Variables.lat, Variables.lat);//pozitie
                pictureBoxes[c].Size = new System.Drawing.Size(Variables.lat, Variables.v[c] * Variables.lat);//marime
                pictureBoxes[c].Visible = true;

            }
        }
        //-------------------------------------------------------------------------------------------

        //sortarea vectorului------------------------------------------------------------------------
        public void sortareVector()
        {
            if (Variables.v[p] < Variables.v[p - 1])
            {
                //actualizarea numarului de interschimbari---------------------------
                interschimbari++;
                labelInterschimbari.Text = "Interschimbari: " + interschimbari;
                //-------------------------------------------------------------------

                //interschimbarea imaginilor-----------------------------------------
                intermPoint = pictureBoxes[p].Location;
                intermSize = pictureBoxes[p].Size;

                pictureBoxes[p].Location = pictureBoxes[p - 1].Location;
                pictureBoxes[p].Size = pictureBoxes[p - 1].Size;

                pictureBoxes[p - 1].Location = intermPoint;
                pictureBoxes[p - 1].Size = intermSize;
                //-------------------------------------------------------------------

                //interschimbarea valorilor------------------------------------------
                int aux = Variables.v[p];
                Variables.v[p] = Variables.v[p - 1];
                Variables.v[p - 1] = aux;
                //-------------------------------------------------------------------
            }
        }
        //--------------------------------------------------------------------------------------------

        //trecerea in fereastra initiala------------------------------------------------------------------
        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }
        //------------------------------------------------------------------------------------------------

        //iesirea din aplicatie-----------------------------------------------------------------------------
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //--------------------------------------------------------------------------------------------------

        private void InsertionSortIlustratie_Load(object sender, EventArgs e)
        {
            interschimbari = 0;

            //deblocarea butoanelor---------------------------------------------------
            buttonExit.Visible = true;
            buttonExit.Enabled = true;

            buttonMeniu.Visible = true;
            buttonMeniu.Visible = true;
            //------------------------------------------------------------------------

            //activarea si setarea timer-ului-----------------------------------------
            timerInsertionSort.Enabled = true;
            timerInsertionSort.Interval = Variables.interval;
            //------------------------------------------------------------------------

            i = 1;
            p = i;

            //setarea initiala a coordonatelor butoanelor------------------------------
            buttonMeniu.Top = 25;
            buttonMeniu.Left = 15;

            buttonExit.Top = 25;
            buttonExit.Left = 25 + buttonMeniu.Width;
            //-------------------------------------------------------------------------

            //setarea label-ului--------------------------------------------------------
            labelInterschimbari.Text = "Interschimbari: 0";
            labelInterschimbari.Top = 5;
            labelInterschimbari.Left = 15;
            //--------------------------------------------------------------------------

            //afisarea initiala a vectorului--------------------------------------------
            creeareVector();
            afisareVector();
            //--------------------------------------------------------------------------

            //actualizarea coordonatelor butoanelor in cazul valorilor mari-------------
            if (Variables.lat != 50)
            {
                buttonExit.Location = new Point(pictureBoxes[Variables.n - 1].Left + pictureBoxes[Variables.n - 1].Width + 20,
                                                25);

                buttonMeniu.Location = new Point(pictureBoxes[Variables.n - 1].Left + pictureBoxes[Variables.n - 1].Width + 20,
                                                buttonExit.Top + 40);
            }
            //---------------------------------------------------------------------------

            //setarea marimii ferestrei---------------------------------------------------
            this.Size = new Size(Math.Max(Variables.lat * (Variables.n + 2) + 20, Math.Max(buttonMeniu.Left + buttonMeniu.Width + 30, 250)),
                                Variables.lat * (Variables.maxi + 3));
            //----------------------------------------------------------------------------
        }

        private void timerInsertionSort_Tick(object sender, EventArgs e)
        {
            //parcurgerea vectorului dupa algoritm---------------------------------------
            if (i < Variables.n)
            {
                if (p > 0)
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
            //---------------------------------------------------------------------------
            else
            {
                afisareVector();
                timerInsertionSort.Enabled = false;//finalizarea sortarii
                MessageBox.Show("Sortare Finalizata!");
            }
        }

        //iesirea din aplicatie---------------------------------------------------------------------------
        private void InsertionSortIlustratie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //------------------------------------------------------------------------------------------------
    }
}
