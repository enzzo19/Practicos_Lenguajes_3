using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Threading.Tasks;



public partial class TP8_Juarez_Velaquez_Enzo_Jesus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txt_read_Click(object sender, EventArgs e)
    {
        
        string text = System.IO.File.ReadAllText(@"C:\Users\enzzo\OneDrive\Escritorio\Datos.txt");
        txtbox_read.Text = text;
    }

    protected void txt_write_Click(object sender, EventArgs e)
    {
        try
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter(@"C:\Users\enzzo\OneDrive\Escritorio\Datos2.txt");
            String valor = txtbox_write.Text;
            //Write text in file
            sw.WriteLine(valor);
            //Write a second line of text
            //Close the file
            sw.Close();
        }
        finally
        {
            lbl_write.Text = "Se ha escrito en el archivo";
        }
        
    }

    protected void btn_nuevo_Click(object sender, EventArgs e)
    {
        txtbox_read.Text = "";
        txtbox_write.Text = "";
        lbl_write.Text = "";
    }
}