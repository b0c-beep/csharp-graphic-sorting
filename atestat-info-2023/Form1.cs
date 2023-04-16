using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat_info_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_alegeMetoda_Click(object sender, EventArgs e)
        {
            Variables.marimeVector = textbox_marimeVector.Text;
            Variables.n = Convert.ToInt32(Variables.marimeVector);
            Variables.valoriVector = textbox_valoriVector.Text;
            string[] cuv = Variables.valoriVector.Split(' ');
            for(int i = 0; i < Variables.n; i++)
            {
                Variables.v[i] = Convert.ToInt32(cuv[i]);
            }
            Variables.maxi = Variables.v.Max();
            
            
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            
        }
    }
}
