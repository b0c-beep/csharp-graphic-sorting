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

        private void button_selectionSort_Click(object sender, EventArgs e)
        {
            SelectionSortInfo ssi = new SelectionSortInfo();
            this.Close();
            ssi.Show();
        }

        private void button_bubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSortInfo bsi = new BubbleSortInfo();
            this.Close();
            bsi.Show();
        }

        private void button_quickSort_Click(object sender, EventArgs e)
        {
            QuickSortInfo qsi = new QuickSortInfo();
            this.Close();
            qsi.Show();
        }
    }
}
