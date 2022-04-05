using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Funciones_Procedimientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        public int MultiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public int DivideNumberS(int num1, int num2)
        {
            int resultado;
            try
            {
                resultado = num1 / num2;
                return resultado;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
                return 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            int resultado = AddNumbers(int.Parse(txt_num1.Text), int.Parse(txt_num2.Text));
            txt_resultado.Text = resultado.ToString();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            int resultado = SubtractNumbers(int.Parse(txt_num1.Text), int.Parse(txt_num2.Text));
            txt_resultado.Text = resultado.ToString();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            int resultado = MultiplyNumbers(int.Parse(txt_num1.Text), int.Parse(txt_num2.Text));
            txt_resultado.Text = resultado.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int resultado = DivideNumberS(int.Parse(txt_num1.Text), int.Parse(txt_num2.Text));
            if (resultado == 0)
            {
                txt_resultado.Text = "";
            }
            else
            {
                txt_resultado.Text = resultado.ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_num1.Text = "";
            txt_num2.Text = "";
            txt_resultado.Text = "";
        }
    }
}
