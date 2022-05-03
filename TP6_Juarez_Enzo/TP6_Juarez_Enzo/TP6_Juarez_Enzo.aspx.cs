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
        String eleccion = "Your chose is: <br />";
        foreach (ListItem item in listbox_left.Items)
        {
            if (item.Selected)
            {
                eleccion += item.Text + "<br />";
            }
         
        }
        lbl_ver.Text = eleccion.ToString();
    }

    protected void btn_limpiar_Click(object sender, EventArgs e)
    {
        listbox_right.Items.Clear();
    }

    protected void btn_right_Click(object sender, EventArgs e)
    {
        String eleccion = "";
        foreach (ListItem item in listbox_left.Items)
        {
            if (item.Selected)
            {
                eleccion = item.Text;
                listbox_right.Items.Add(eleccion);
            }
        }
    
    }

    protected void btn_left_Click(object sender, EventArgs e)
    {
        List<string> no_seleccionado = new List<string>();

        foreach (ListItem item in listbox_right.Items)
        {

            if (!item.Selected)
            {
                no_seleccionado.Add(item.Text);
            }
        }
        listbox_right.Items.Clear();

        foreach (string item2 in no_seleccionado)
        {
            listbox_right.Items.Add(item2);
        }

        

    }
}