<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TP7_Envio_Mails.aspx.cs" Inherits="TP7_Envio_Mails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_message0" runat="server" ForeColor="Red">TP7_Envio de Mails_ Juarez Velazquez Enzo Jesus</asp:Label>
            <br />
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_message1" runat="server" ForeColor="Red">Casilla de Correos</asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="De: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_emisor" runat="server" Width="197px">cp421695@gmail.com</asp:TextBox>
&nbsp;
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Para: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_receptor" runat="server" Width="201px" TextMode="Email"></asp:TextBox>
&nbsp;
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator1" 
            runat="server" 
            ErrorMessage="Escribe un Correo Valido !" 
            ForeColor="#FF3300"
            ValidationExpression= "^[^@]+@[^@]+\.[a-zA-Z]{2,}$"
            ControlToValidate="txt_receptor"
            ></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Asunto: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_asunto" runat="server" Width="185px"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ErrorMessage="Escribe un asunto !" 
            ForeColor="Red" 
            ControlToValidate ="txt_asunto"
            ></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Mensaje: "></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_message" runat="server" Height="75px" TextMode="MultiLine" Width="193px"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" 
            runat="server" 
            ErrorMessage="Escribe un mensaje !" 
            ForeColor="Red" 
            ControlToValidate ="txt_message"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btn_email" runat="server" OnClick="btn_email_Click" Text="Enviar" />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_message" runat="server" ForeColor="#00CC00"></asp:Label>
    </form>
</body>
</html>
