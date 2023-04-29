using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class SelectionSortInfo : Form
    {
        public SelectionSortInfo()
        {
            InitializeComponent();
        }

        //trecem in urmatoarea fereastra----------------------------------------------------
        private void button_ilustratie_Click(object sender, EventArgs e)
        {
            SelectionSortIlustratie s = new SelectionSortIlustratie();
            s.Show();
            this.Hide();
        }
        //----------------------------------------------------------------------------------

        //ne asiguram ca inchidem toate ferestrele la inchiderea aplicatiei-----------------
        private void SelectionSortInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //----------------------------------------------------------------------------------
    }
}
