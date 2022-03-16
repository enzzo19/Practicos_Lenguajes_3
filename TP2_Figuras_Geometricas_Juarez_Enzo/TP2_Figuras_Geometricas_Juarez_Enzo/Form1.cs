using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Figuras_Geometricas_Juarez_Enzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_ladoA.Text = "";
            txt_ladoB.Text = "";
            txt_area.Text = "";
            txt_perimetro.Text = "";
            pnl_cuadrado.Visible = false;
            pnl_rectangulo.Visible = false;

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double area = 0.0;
            double perimetro = 0.0;
            double lado_A = Convert.ToDouble(txt_ladoA.Text);
            double lado_B = Convert.ToDouble(txt_ladoB.Text);

            if (lado_A == lado_B)
            {
                pnl_cuadrado.Visible = true;
                area = lado_A * lado_B;
                perimetro = 4 * lado_A;
            }
            else
            {
                pnl_rectangulo.Visible = true;
                area = lado_A * lado_B;
                perimetro = 2 * lado_A + 2 * lado_B;
            }
            txt_area.Text = Convert.ToString(area);
            txt_perimetro.Text = Convert.ToString(perimetro);
        }
    }
}
