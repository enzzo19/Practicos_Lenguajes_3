using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Enzo_Juarez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            bool  error = false;
            foreach (char caracter in this.txt_name.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txt_name, "NO se permiten numeros! Coloque su nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_edad_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (char caracter in this.txt_edad.Text)
            {
                if (char.IsNumber(caracter) == false) { 
                    error = true;
                    break;
                }
                
            }
            if (error)
            {
                errorProvider1.SetError(txt_edad, "Solo se permiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txt_edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_salario_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (char caracter in this.txt_salario.Text)
            {
                if (char.IsNumber(caracter) == false)
                {
                    error = true;
                    break;
                }

            }
            if (error)
            {
                errorProvider1.SetError(txt_salario, "Solo se permiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool error = false;
           if (txt_name.Text == "")
            {
                
                error = true;
            }
            if (error)
            {
                errorProvider1.SetError(txt_name, "Ingrese un nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_edad.Text = "";
            txt_salario.Text = "";
            errorProvider1.Clear();
        }
    }
}
