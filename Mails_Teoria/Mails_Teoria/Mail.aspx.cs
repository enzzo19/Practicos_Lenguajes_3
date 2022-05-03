using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class Mail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_email_Click(object sender, EventArgs e)
    {
        MailMessage args = new MailMessage();
        args.From = new MailAddress("enzzo.juarez.19@gmail.com");
        List<string> Correos = new List<string>();
        Correos.Add("enzzo.juarez.19@mail.com");
        Correos.Add("cp421695@gmail.com");

      

        for (var c = 0; c < Correos.Count(); c++)
        {
            args.To.Add(Correos[c]);
        }
            
        
        args.Subject = "Probando los mensajes";
        args.Body = "Este es un Mensaje de prueba";
        args.IsBodyHtml = true;

        
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        System.Net.NetworkCredential Credentials = new System.Net.NetworkCredential();
        Credentials.UserName = "cp421695@gmail.com";
        Credentials.Password = "123123123aA#";
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = Credentials;
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.Send(args);

        lbl_message.Text = "Correo Enviado";


    }
}