using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //schimbam ferestrele in functie de butonul apasat--------------------------------------------------------
        private void button_selectionSort_Click(object sender, EventArgs e)
        {
            SelectionSortInfo ssi = new SelectionSortInfo();
            this.Hide();
            ssi.Show();
        }

        private void button_bubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSortInfo bsi = new BubbleSortInfo();
            this.Hide();
            bsi.Show();
        }

        private void button_quickSort_Click(object sender, EventArgs e)
        {
            InsertionSortInfo qsi = new InsertionSortInfo();
            this.Hide();
            qsi.Show();
        }
        //-------------------------------------------------------------------------------------------------------

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //daca utilizatorul inchide aplicatia, ne asiguram ca toate ferestrele se inchid-------------------------
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
