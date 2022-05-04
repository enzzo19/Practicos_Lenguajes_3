using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConsumeClases : System.Web.UI.Page
{

    CalculosVarios obj = new CalculosVarios();
    Aritmetica calcular = new Aritmetica();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.lbl_error.Text = "";
        if (!Page.IsPostBack)
        {
            this.txt_salario.Text = obj.Salariohora.ToString();
        }

    }

    protected void btn_calc_salario_Click(object sender, EventArgs e)
    {
        obj.Edad = Convert.ToInt32(this.txt_edad.Text);
        if (obj.Edad == 0)
        {
            this.lbl_error.Text = "Edad incorrecta";
        }
        obj.diastrabajados = Convert.ToInt32(this.txt_dias_laborales.Text);
        this.txt_sueldo.Text =
       obj.calcular_salario(obj.diastrabajados).ToString();
    }

    protected void btn_sumar_Click(object sender, EventArgs e)
    {
        lbl_resultado.Text = "El valor de la suma es : " + calcular.suma(Convert.ToInt32(this.txt_numero.Text),
       Convert.ToInt32(this.txt_numero2.Text)).ToString();
    }

    protected void txt_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btn_nuevo_Click(object sender, EventArgs e)
    {
        txt_nombre.Text = "";
        txt_edad.Text = "";
        txt_dias_laborales.Text = "";
        txt_sueldo.Text = "";
        txt_numero.Text = "";
        txt_numero2.Text = "";
        lbl_resultado.Text = "";
        
    }
}