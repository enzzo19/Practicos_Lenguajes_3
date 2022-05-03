using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TP6_Juarez_Enzo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        lbl_nuevo.Visible = true;
        txt_nuevo.Visible = true;
        btn_insertar.Visible = true;
    }

    protected void btn_insertar_Click(object sender, EventArgs e)
    {
        String contenido;
        contenido = txt_nuevo.Text;
        listbox_left.Items.Add(contenido);
        txt_nuevo.Text = "";
    }

    protected void btn_ver_Click(object sender, EventArgs e)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        foreach (object item in listbox_left.)
        {
            sb.Append(item.ToString());
            sb.Append(" ");
        }
        lbl_ver.Text = sb.ToString();
    }

    protected void btn_limpiar_Click(object sender, EventArgs e)
    {
        listbox_right.Items.Clear();
    }
}