using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDemo_JessicaWeiss
{
    public partial class Form1 : Form
    {

        // Grundfarbe definieren
        private Color devaultcolor;

        // Name definieren
        public Form1()
        {
            InitializeComponent();
            devaultcolor = BackColor;
            string firstName = "Jessica ";
            string lastName = "Weiss";
            string fullName = firstName + lastName;
            label1.Text = fullName;
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }

        // Mit Maus über Textfeld
        private void txtInfo_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.DarkOliveGreen;
        }

        // Mit Maus von Textfeld weg
        private void txtInfo_MouseLeave(object sender, EventArgs e)
        {
            BackColor = devaultcolor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Operationen definieren
        private void button1_Click(object sender, EventArgs e)
        {
            // definierung V1 und V2 
            int v1, v2;
            txt_value1.BackColor = Color.White;
            txt_value2.BackColor = Color.White;


            // Addieren
            // Text zu Zahl umwandeln (.Parse)
            if (Int32.TryParse(txt_value1.Text,out v1) ==false) 
            {
                txt_result.Text = "Falscher Eingabewert in Feld 1";
                txt_value1.Focus();
                txt_value1.BackColor=Color.Red;
                return;

            }
            
            if (Int32.TryParse(txt_value2.Text,out v2) == false)
            {
                txt_result.Text = "Falscher Eingabewert in Feld 2";
                txt_value2.Focus();
                txt_value2.BackColor = Color.Red;
                return;

            }

            clsRechnen rechnen = new clsRechnen();
            txt_result.Text = rechnen.rechnen(cmb_operator.SelectedItem.ToString(), v1, v2);

            //if (cmb_operator.SelectedItem == "+")
            //{

            //    // Addition
            //    txt_result.Text = (v1 + v2).ToString();
            //}else if(cmb_operator.SelectedItem == "-")
            //{
            //    // Subtraktion
            //    txt_result.Text = (v1 - v2).ToString();
            //}

            // // Multiplikation
            //else if (cmb_operator.SelectedItem == "x")
            //{
            //    txt_result.Text = (v1 * v2).ToString();
            //}

            //// Division
            //else if (cmb_operator.SelectedItem == ":")
            //{
            //    txt_result.Text = (v1 / v2).ToString();
            //}
        }


    }
}
