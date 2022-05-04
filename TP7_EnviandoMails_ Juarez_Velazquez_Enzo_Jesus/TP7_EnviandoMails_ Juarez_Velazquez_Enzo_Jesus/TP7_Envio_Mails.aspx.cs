using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class TP7_Envio_Mails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_email_Click(object sender, EventArgs e)
    {
        MailMessage args = new MailMessage();
        args.From = new MailAddress("cp421695@gmail.com");
        List<string> Correos = new List<string>();

        args.To.Add(txt_receptor.Text);

        args.Subject = txt_asunto.Text;
        args.Body = txt_message.Text;
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