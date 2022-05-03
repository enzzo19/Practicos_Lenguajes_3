<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TP6_Juarez_Enzo.aspx.cs" Inherits="TP6_Juarez_Enzo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
        .auto-style2 {
            width: 204px;
        }
        .auto-style3 {
            width: 169px;
            height: 178px;
        }
        .auto-style4 {
            width: 204px;
            height: 178px;
        }
        .auto-style5 {
            height: 178px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="TP6_Maquetacion_Juarez_Enzo"></asp:Label>
        </div>
    &nbsp;&nbsp;&nbsp;
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:ListBox ID="listbox_left" runat="server" Height="151px" SelectionMode="Multiple" Width="162px">
                        <asp:ListItem>Cepillo de Dientes</asp:ListItem>
                        <asp:ListItem>Pasta Dental</asp:ListItem>
                        <asp:ListItem>Shampoo</asp:ListItem>
                        <asp:ListItem>Acondicionador</asp:ListItem>
                        <asp:ListItem>Maquina de Afeitar</asp:ListItem>
                        <asp:ListItem>Espuma</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_right" runat="server" Height="23px" Text="&gt;&gt;&gt;" Width="156px" OnClick="btn_right_Click" />
                    <br />
                    <br />
&nbsp;&nbsp;
                    <asp:Button ID="btn_left" runat="server" Text="&lt;&lt;&lt;" Width="155px" OnClick="btn_left_Click" />
                    <br />
                    <br />
&nbsp;&nbsp;
                    <asp:Button ID="btn_nuevo" runat="server" OnClick="Button8_Click" Text="Nuevo Item" Width="153px" />
                    <br />
                    <br />
&nbsp;&nbsp;
                    <asp:Button ID="btn_limpiar" runat="server" OnClick="btn_limpiar_Click" Text="Limpiar Lista" Width="153px" />
                    <br />
                </td>
                <td class="auto-style5">
                    <asp:ListBox ID="listbox_right" runat="server" Height="151px" SelectionMode="Multiple" Width="162px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_nuevo" runat="server" ForeColor="Red" Text="Nuevo Item" Visible="False"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_nuevo" runat="server" Visible="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_insertar" runat="server" OnClick="btn_insertar_Click" Text="Insertar Item" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btn_ver" runat="server" Height="23px" OnClick="btn_ver_Click" Text="Ver Seleccionado" Width="145px" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lbl_ver" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
