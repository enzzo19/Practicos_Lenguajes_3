using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Juarez_Enzo
{
    public partial class TP4_Juarez_Enzo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_horas_normales.Text = "";
            txt_pago_normal.Text = "";
            txt_horas_extras.Text = "";
            txt_pago_extra.Text = "";
            txt_bonificacion.Text = "";
            txt_sueldo_bruto.Text = "";
            txt_sueldo_neto.Text = "";
            num_hijos.ClearSelection();
            chk_bonificacion.Checked = false;
        }

        protected void btn_calcular_Click(object sender, EventArgs e)
        {
            // declaro y asigno valor a sueldo bruto
            double sueldo_bruto = Convert.ToDouble(txt_horas_normales.Text) * Convert.ToDouble(txt_pago_normal.Text) + Convert.ToDouble(txt_horas_extras.Text) * Convert.ToDouble(txt_pago_extra.Text);
            txt_sueldo_bruto.Text = Convert.ToString(sueldo_bruto);
            // declaro y luego con la condicion asigno valor a sueldo neto
            double sueldo_neto = 0.0;
            // declaro bonificacion
            double cant_hijos = Convert.ToDouble(num_hijos.SelectedValue);
            double bonificacion = cant_hijos * 20.0;

            if (chk_bonificacion.Checked == true)
            {
                sueldo_neto = sueldo_bruto + bonificacion;
                txt_sueldo_neto.Text = Convert.ToString(sueldo_neto);
            }
            else
            {
                sueldo_neto = sueldo_bruto;
                txt_sueldo_neto.Text = Convert.ToString(sueldo_neto);
                bonificacion = 0.0;
            }

            txt_bonificacion.Text = Convert.ToString(bonificacion);
        }

        protected void btn_salir_Click(object sender, EventArgs e)
        {
            
        }
    }
}