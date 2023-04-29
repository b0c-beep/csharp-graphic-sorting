using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class BubbleSortInfo : Form
    {
        public BubbleSortInfo()
        {
            InitializeComponent();
        }

        //trecem in urmatoarea fereastra--------------------------------------------------
        private void button_ilustratie_Click(object sender, EventArgs e)
        {
            this.Hide();
            BubbleSortIlustratie bbsi = new BubbleSortIlustratie();
            bbsi.Show();
        }
        //--------------------------------------------------------------------------------

        //ne asiguram ca toate ferestrele sunt inchise la inchiderea aplicatiei-----------
        private void BubbleSortInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //--------------------------------------------------------------------------------
    }
}
