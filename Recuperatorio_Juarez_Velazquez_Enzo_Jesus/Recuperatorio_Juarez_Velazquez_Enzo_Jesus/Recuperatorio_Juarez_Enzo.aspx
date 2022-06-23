<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Recuperatorio_Juarez_Enzo.aspx.cs" Inherits="Recuperatorio_Juarez_Enzo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblDetalle" runat="server" Text="Detalle"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDetalle" runat="server" OnTextChanged="txtDetalle_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DpFarmacias" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Precio por unidad"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPxU" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1">
                        <asp:Label ID="label4" runat="server" Text="Cantidad"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="listProductos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="listProductos_SelectedIndexChanged"></asp:ListBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Total"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Laboratorio"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLaboratorio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label7" runat="server" Text="Tipo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>