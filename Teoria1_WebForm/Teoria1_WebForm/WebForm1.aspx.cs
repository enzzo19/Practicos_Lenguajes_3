using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teoria1_WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void chk_reserva_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_reserva.Checked == true)
            {
                txt_hotel.Visible = true;
            }
            else
            {
                txt_hotel.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string message = "";
            message += txt_destino.Text + "<BR>" + txt_itinerario.Text + "<BR>" + txt_hotel.Text + "<BR>";

            lbl_message.Visible = true;
            lbl_message.Text = message;
        }
    }
}