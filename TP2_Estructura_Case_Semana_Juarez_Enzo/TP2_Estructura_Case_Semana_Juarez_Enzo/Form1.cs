using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Estructura_Case_Semana_Juarez_Enzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_numero.Text = "";
            txt_dia.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dictionary<int, string> dias = new Dictionary<int, string>()
            {
                { 1, "Lunes" },
                { 2, "Martes" },
                { 3, "Miercoles" },
                { 4, "Jueves" },
                { 5, "Viernes" },
                { 6, "Sabado" },
                { 7, "Domingo" },

             };


            int dia_numero = 0;

            bool canConvert = int.TryParse(txt_numero.Text, out dia_numero);

            if (canConvert)
            {
                if (dias.ContainsKey(dia_numero))
                {
                    txt_dia.Text = dias[dia_numero];
                }
                else
                {
                    txt_dia.Text = "";
                    txt_numero.Text = "";
                    MessageBox.Show("Coloca un Numero entre 1-7");

                }
            }
            else
            {
                txt_dia.Text = "";
                txt_numero.Text = "";
                MessageBox.Show("Coloca un NUMERO entre 1-7");
            }
        }
    }
}