<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Teoria1_WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Programe sus Vacaciones<br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Destino: "></asp:Label>
&nbsp;<asp:TextBox ID="txt_destino" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Itinerario: "></asp:Label>
&nbsp;<asp:TextBox ID="txt_itinerario" runat="server" Height="38px" TextMode="MultiLine" Width="175px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chk_reserva" runat="server" AutoPostBack="True" OnCheckedChanged="chk_reserva_CheckedChanged" Text="¿Desea reservar el Hotel ?" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Hotel: "></asp:Label>
&nbsp;<asp:TextBox ID="txt_hotel" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reservar" />
        <br />
        <br />
        <asp:Label ID="lbl_message" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
