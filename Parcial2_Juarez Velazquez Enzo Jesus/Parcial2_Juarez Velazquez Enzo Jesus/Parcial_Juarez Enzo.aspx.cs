using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Parcial_Juarez_Enzo : System.Web.UI.Page
{
    string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\enzzo\\source\\repos\\Lenguajes_3\\Parcial2_Juarez Velazquez Enzo Jesus\\Parcial2_Juarez Velazquez Enzo Jesus\\Municipalidad.accdb";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OleDbConnection conn = new OleDbConnection(cadena);
            OleDbCommand cmd = new OleDbCommand();
            string sql = "select * from PagoPatente";
            OleDbDataReader dr;
            try
            {
                conn.Open();
                cmd = new OleDbCommand(sql, conn);
                dr = cmd.ExecuteReader();
               
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

    protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
    {

    }

    protected void img_btn_consultar_Click(object sender, ImageClickEventArgs e)
    {
        String patente = txt_dominio.Text;
        OleDbConnection conn = new OleDbConnection(cadena);
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        string sql = "select Año, Cuota, Impuesto from PagoPatente where Patente = " + patente;
        conn.Open();
        cmd = new OleDbCommand(sql, conn);
        dr = cmd.ExecuteReader();
        this.GridView1.DataSource = dr;
        this.GridView1.DataBind();
        conn.Close();
        dr.Close();

    }

    protected void img_btn_print_boleta_Click(object sender, ImageClickEventArgs e)
    {

    }
}