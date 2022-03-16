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
            int dia_numero = Convert.ToInt32(txt_numero.Text);
            string dia_letras = "";

            switch (dia_numero)
            {
                case 1:
                    txt_dia.Text = "Lunes";
                    break;
                case 2:
                    txt_dia.Text = "Martes";
                    break;
                case 3:
                    txt_dia.Text = "Miercoles";
                    break;
                case 4:
                    txt_dia.Text = "Jueves";
                    break;
                case 5:
                    txt_dia.Text = "Viernes";
                    break;
                case 6:
                    txt_dia.Text = "Sabado";
                    break;
                case 7:
                    txt_dia.Text = "Domingo";
                    break;
                default:
                    MessageBox.Show("Coloca un numero entre 1-7");
                    txt_numero.Text = "";
                break;
            }
        }
    }
}
