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
            Variables.lat = 50;
        }

        private void button_alegeMetoda_Click(object sender, EventArgs e)
        {
            string[] cuv;
            
            //stergem spatiile care nu sunt necesare din input-ul textbox-urilor----------------------------
            string s1 = textbox_marimeVector.Text.Trim();
            textbox_marimeVector.Text = s1;

            string s2 = textbox_valoriVector.Text.Trim();
            textbox_valoriVector.Text = s2;
            //-----------------------------------------------------------------------------------------------

            //verificam daca utilizatorul a completat datele necesare------------------------------------------
            if(string.IsNullOrEmpty(textbox_marimeVector.Text) || string.IsNullOrEmpty(textbox_valoriVector.Text))
            {
                MessageBox.Show("Nu ai completat datele!");
            }
            else
            {
                //stocam inputul din textbox-uri in variabilele globale--------------
                Variables.marimeVector = textbox_marimeVector.Text;
                Variables.n = Convert.ToInt32(Variables.marimeVector);
                Variables.valoriVector = textbox_valoriVector.Text;
                //-------------------------------------------------------------------

                //stocam valorile si maximul vectorului cu care vom lucra------------
                cuv = Variables.valoriVector.Split(' ');
                for(int i = 0; i < Variables.n; i++)
                {
                    Variables.v[i] = Convert.ToInt32(cuv[i]);
                    if (Variables.v[i] < 0)
                        Variables.v[i] = Math.Abs(Variables.v[i]);
                }

                Variables.maxi = Variables.v.Max();
                //--------------------------------------------------------------------

                //setam marimile necesare in caz ca valorile sunt prea mari-----------
                if (Variables.maxi > 10)
                {
                    Variables.lat = 20;
                }
                //--------------------------------------------------------------------

                //trecem in urmatoarea fereastra--------------------------------------
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
                //--------------------------------------------------------------------

            }
            //---------------------------------------------------------------------------------------------------
        }

        //daca utilizatorul inchide aplicatia, ne asiguram ca toate ferestrele se inchid-------------------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //-------------------------------------------------------------------------------------------------------

        //ne asiguram ca sunt tastate doar numere in textbox-uri-------------------------------------------------
        private void textbox_marimeVector_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_valoriVector_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //--------------------------------------------------------------------------------------------------------
    }
}
