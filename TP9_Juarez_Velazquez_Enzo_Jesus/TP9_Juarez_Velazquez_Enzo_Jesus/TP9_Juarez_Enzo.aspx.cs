using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class TP9_Juarez_Enzo : System.Web.UI.Page
{
    string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\enzzo\\OneDrive\\Escritorio\\Farmacia.mdb";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OleDbConnection conn = new OleDbConnection(cadena);
            OleDbCommand cmd = new OleDbCommand();
            string sql = "select * from PRODUCTOS";
            OleDbDataReader dr;
            try
            {
                conn.Open();
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
                this.ckCategoriasLista.DataSource = dr;
                this.ckCategoriasLista.DataTextField = "COD_PRODUCTO";
                this.ckCategoriasLista.DataValueField = "DETALLE";
                this.ckCategoriasLista.DataBind();
            }
            catch (OleDbException errB)
            {
                this.lbl_error.Text = errB.Message;
            }
            catch (Exception errA)
            {
                this.lbl_error.Text = errA.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }

    protected void txt_detalle_TextChanged(object sender, EventArgs e)
    {

    }
}