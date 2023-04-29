using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class InsertionSortInfo : Form
    {
        public InsertionSortInfo()
        {
            InitializeComponent();
        }

        //trecem in urmatoarea fereastra--------------------------------------------------------------
        private void button_ilustratie_Click(object sender, EventArgs e)
        {
            InsertionSortIlustratie isi = new InsertionSortIlustratie();
            this.Hide();
            isi.Show();
        }
        //--------------------------------------------------------------------------------------------

        //ne asiguram ca toate ferestrele sunt inchise la iesirea din aplicatie-----------------------
        private void InsertionSortInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //--------------------------------------------------------------------------------------------
    }
}
