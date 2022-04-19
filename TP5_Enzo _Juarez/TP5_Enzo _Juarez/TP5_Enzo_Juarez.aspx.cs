using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TP5_Enzo_Juarez : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btn_enviar.Attributes["onclick"] = "alert('Se ha presionado el boton: ENVIAR'); return false;";
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string script = @"<script type='text/javascript'>
                            alerta(6);
                        </script>";

        ScriptManager.RegisterStartupScript(this, typeof(Page), "Se Registro", script, false);
    }
}