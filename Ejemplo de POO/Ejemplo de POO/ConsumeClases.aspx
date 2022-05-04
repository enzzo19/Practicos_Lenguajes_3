<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsumeClases.aspx.cs" Inherits="ConsumeClases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Ingrese Datos"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_error" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <br />
        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Salario x Dia"></asp:Label>
        <br />
        <asp:TextBox ID="txt_salario" runat="server">1800</asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Edad"></asp:Label>
        <br />
        <asp:TextBox ID="txt_edad" runat="server" OnTextChanged="txt_TextChanged"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Dias Laborales"></asp:Label>
        <br />
        <asp:TextBox ID="txt_dias_laborales" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Sueldo Total"></asp:Label>
        <br />
        <asp:TextBox ID="txt_sueldo" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Button ID="btn_calc_salario" runat="server" OnClick="btn_calc_salario_Click" Text="Calcular Salario" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_nuevo" runat="server" OnClick="btn_nuevo_Click" Text="Nuevo" />
        <br />
        <br />
&nbsp;a =
        <asp:TextBox ID="txt_numero" runat="server" Width="75px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; b =
        <asp:TextBox ID="txt_numero2" runat="server" Width="75px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_resultado" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_sumar" runat="server" OnClick="btn_sumar_Click" Text="Sumar" />
    </form>
</body>
</html>
