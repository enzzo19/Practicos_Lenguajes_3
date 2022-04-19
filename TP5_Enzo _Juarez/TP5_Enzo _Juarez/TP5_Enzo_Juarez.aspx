<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TP5_Enzo_Juarez.aspx.cs" Inherits="TP5_Enzo_Juarez" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    
        function alerta(numero) {
            alert('Se ha presionado el boton: ' + numero);
        }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        TP5_Enzo_Juarez<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Escuela: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_escuela" 
                     runat="server" 
                     OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator1" 
            ValidationExpression= "^[A-Za-z0-9\s]+$"
            runat="server" 
            ErrorMessage="Ingrese Escuela !" 
            ForeColor="Red" 
            ControlToValidate="txt_escuela"  
            ValidateRequestMode="Enabled">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label 
            ID="Label2" 
            runat="server" 
            Text="Cantidad Docentes: ">
        </asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox 
            ID="txt_docentes" 
            runat="server" 
            OnTextChanged="TextBox1_TextChanged">
        </asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator3" 
            runat="server" 
            ErrorMessage="Ingrese Cantidad Correcta !" 
            ForeColor="Red" 
            ControlToValidate="txt_docentes" 
            ValidationExpression="^[0-9]+$">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label 
            ID="Label3" 
            runat="server" 
            Text="Fecha Apertura: ">
        </asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox 
            ID="txt_fecha" 
            runat="server" 
            OnTextChanged="TextBox1_TextChanged">
        </asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator4" 
            runat="server" 
            ErrorMessage="Ingrese Fecha Correcta !" 
            ForeColor="Red" 
            ControlToValidate="txt_fecha" 
            ValidationExpression="^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label 
            ID="Label4" 
            runat="server" 
            Text="E-mail: ">
        </asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox 
            ID="txt_email" 
            runat="server" 
            OnTextChanged="TextBox1_TextChanged">
        </asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator2" 
            runat="server" 
            controltovalidate="txt_email" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ErrorMessage="Ingrese correo valido !" 
            ForeColor="Red">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btn_enviar" runat="server" Text="Enviar" OnClick="Button1_Click" />
    </form>
</body></html>
