using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class Recuperatorio_Juarez_Enzo : System.Web.UI.Page
{
    string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/enzzo/OneDrive/Escritorio/Farmacia.accdb";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OleDbConnection conexion = new OleDbConnection(cadena);
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            string consulta = "Select COD_PRODUCTO, DETALLE from PRODUCTOS";

            conexion.Open();
            cmd = new OleDbCommand(consulta, conexion);
            dr = cmd.ExecuteReader();

            this.listProductos.DataValueField = "COD_PRODUCTO";
            this.listProductos.DataTextField = "DETALLE";
            this.listProductos.DataSource = dr;
            this.listProductos.DataBind();



            dr.Close();
            conexion.Close();

        }
    }

    protected void listProductos_SelectedIndexChanged(object sender, EventArgs e)
    {

        OleDbConnection conn = new OleDbConnection(cadena);
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataReader dr1;
        string consul1 = "select IdFarmacia, denominacion from FARMACIAS";
        conn.Open();
        cmd1 = new OleDbCommand(consul1, conn);
        dr1 = cmd1.ExecuteReader();
        this.DpFarmacias.DataSource = dr1;
        this.DpFarmacias.DataValueField = "IdFarmacia";
        this.DpFarmacias.DataTextField = "denominacion";
        this.DpFarmacias.DataBind();

        string item = listProductos.SelectedItem.Value;
        consul1 = "Select DETALLE,PRECIO,CANTIDAD, LABORATORIO, TIPO from PRODUCTOS where COD_PRODUCTO=" + item;


        cmd1 = new OleDbCommand(consul1, conn);
        dr1 = cmd1.ExecuteReader();

        if (dr1.Read())
        {
            try
            {
                this.txtDetalle.Text = dr1["DETALLE"].ToString();
                this.txtDetalle.DataBind();
                this.txtCantidad.Text = dr1["CANTIDAD"].ToString() + " unidades";
                this.txtCantidad.DataBind();
                this.txtPrecio.Text = "$" + dr1["PRECIO"].ToString();
                this.txtPrecio.DataBind();


                this.txtLaboratorio.Text = dr1["LABORATORIO"].ToString();
                this.txtLaboratorio.DataBind();
                this.txtTipo.Text = dr1["TIPO"].ToString();
                this.txtTipo.DataBind();

            }
            catch (System.FormatException)
            {
            }
        }

        dr1.Close();
        conn.Close();
    }

    protected void txtDetalle_TextChanged(object sender, EventArgs e)
    {
    }

    protected void btnCalcular_Click(object sender, EventArgs e)
    {
        double total = 0;
        String cantidad = txtCantidad.Text.Replace(" unidades", "");
        int cantidad_int = Convert.ToInt32(cantidad);
        String precio = txtPrecio.Text.Replace("$", "");
        total = cantidad_int * (Convert.ToInt32(precio));
        
        txtTotal.Text = total.ToString();
        txtTotal.Text = string.Format("${0}", total.ToString());
    }
}