using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Coloquio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        double capital = Convert.ToDouble(txt_capital.Text);
        double razon = Convert.ToDouble(txt_razon.Text);
        double tiempo =Convert.ToDouble(txt_tiempo.Text);
        double monto_final = capital * (Math.Pow((1 + razon), tiempo));
        txt_monto_final.Text = monto_final.ToString();
        txt_interes.Text = (monto_final - capital).ToString();
    }

    protected void txt_capital_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        txt_capital.Text = "";
        txt_razon.Text = "";
        txt_tiempo.Text = "";
        txt_interes.Text = "";
        txt_monto_final.Text = "";
    }
}