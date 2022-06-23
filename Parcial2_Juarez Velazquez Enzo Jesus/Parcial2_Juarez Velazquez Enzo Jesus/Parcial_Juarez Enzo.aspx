<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Parcial_Juarez Enzo.aspx.cs" Inherits="Parcial_Juarez_Enzo" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="54px" ImageUrl="~/logo.png" Width="132px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Noticias"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Servicios"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="La Ciudad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Gobierno"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/lupa.png" />
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:ImageButton ID="ImageButton2" runat="server" Height="90px" ImageUrl="~/ventanilla virtual.png" Width="95px" />
            <asp:ImageButton ID="ImageButton3" runat="server" Height="90px" ImageUrl="~/guia tramite.png" Width="95px" />
            <asp:ImageButton ID="img_btn_print_boleta" runat="server" Height="90px" ImageUrl="~/imprimi boleta.png" OnClick="img_btn_print_boleta_Click" Width="95px" />
            <asp:ImageButton ID="ImageButton5" runat="server" Height="90px" ImageUrl="~/consulta expediente.png" Width="95px" />
            <asp:ImageButton ID="ImageButton6" runat="server" Height="90px" ImageUrl="~/pago electronico.png" Width="95px" />
            <asp:ImageButton ID="ImageButton7" runat="server" Height="90px" ImageUrl="~/licencia conducir.png" Width="95px" />
            <asp:ImageButton ID="ImageButton8" runat="server" Height="90px" ImageUrl="~/habilitacion comercial.png" Width="95px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:ImageButton ID="img_btn_automotor" runat="server" CssClass="auto-style1" ImageUrl="~/automotor.png" />
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="img_btn_pago_boleta" runat="server" ImageUrl="~/emision_boletas.png" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="img_btn_impuesto_boleta" runat="server" ImageUrl="~/imp_automotor.png" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="AUTOMOTOR" ForeColor="Red"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="IMPUESTO AUTOMOTOR"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Dominio:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_dominio" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="img_btn_consultar" runat="server" ImageUrl="~/consuta_gral.png" OnClick="img_btn_consultar_Click" />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            </asp:CheckBoxList>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="lbl_error" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbl_muestra_datos" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
