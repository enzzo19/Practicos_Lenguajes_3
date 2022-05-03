<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mail.aspx.cs" Inherits="Mail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 240px">
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red" Text="Envio de Gmail"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="De: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_emisor" runat="server" Width="197px">enzzo.juarez.19@gmail.com</asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Para: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_receptor" runat="server" Width="201px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Asunto: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_asunto" runat="server" Width="185px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Mensaje: "></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_message" runat="server" Height="75px" TextMode="MultiLine" Width="193px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_email" runat="server" OnClick="btn_email_Click" Text="Email" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_message" runat="server" ForeColor="#00CC00"></asp:Label>
    </form>
</body>
</html>
