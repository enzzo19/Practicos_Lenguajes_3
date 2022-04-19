<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Coloquio.aspx.cs" Inherits="Coloquio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="margin-left: 240px">
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="COLOQUIO"></asp:Label>
        </p>
        
        
        <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator1" 
                runat="server" 
                ErrorMessage="Coloca un Nombre !!" 
                ForeColor="Red"
                ValidationExpression= "^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$"
                ControlToValidate="txt_name">
            </asp:RegularExpressionValidator>
        </p>
        <p style="margin-left: 80px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_edad" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:RangeValidator 
                ID="RangeValidator1" 
                runat="server" 
                ErrorMessage="Coloque una Edad !!" 
                ForeColor="Red" 
                MaximumValue="99" 
                MinimumValue="1"
                ControlToValidate ="txt_edad"
                type ="Integer"></asp:RangeValidator>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Fecha Nacimiento"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator3" 
                runat="server" 
                ErrorMessage="Coloca una Fecha Valida !!" 
                ForeColor="Red"
                ControlToValidate="txt_fecha" 
                ValidationExpression="^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$">
            </asp:RegularExpressionValidator>
        </p>
        <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator4" 
                runat="server" 
                ErrorMessage="Contraseña Debil !!" 
                ForeColor="Red"
                ControlToValidate ="txt_password"
                ValidationExpression ="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&#.$($)$-$_])[A-Za-z\d$@$!%*?&#.$($)$-$_]{8,15}$">  
            </asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Confirmar Contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_new_password" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:CompareValidator 
                ID="CompareValidator1" 
                runat="server" 
                ErrorMessage="No son iguales !!" 
                ForeColor="Red"
                ControlToCompare="txt_password"   
                ControlToValidate="txt_new_password"
                operator ="Equal">
            </asp:CompareValidator>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Enviar" />
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="CALCULAR MONTO Y TOTAL DE INTERES"></asp:Label>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Capital: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_capital" runat="server" OnTextChanged="txt_capital_TextChanged"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" Text="Razon: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_razon" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_calcular" runat="server" Text="CALCULAR" OnClick="Button2_Click" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="Tiempo: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_tiempo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_nuevo" runat="server" OnClick="Button2_Click1" Text="LIMPIAR" />
        </p>
        <p>
            <asp:Label ID="Label11" runat="server" Text="Total Interes: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_interes" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label12" runat="server" Text="Monto Final: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_monto_final" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
