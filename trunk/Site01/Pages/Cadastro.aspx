<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site01.Pages.Cadastro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formcadastro" runat="server">
    <div>
        <h3>Cadastro de Clientes</h3>
        Nome do Cliente: <br />
        <asp:TextBox ID="txtNome" runat="server" />
        <asp:RequiredFieldValidator
            ID="reqNome"
            ControlToValidate="txtNome"
            ErrorMessage="Informe o Nome."
            ForeColor="Red"
            runat="server"
        />
        <asp:RegularExpressionValidator 
            ID="regexNome"
            ValidationExpression="^[A-Za-zÀ-Üà-ü0-9\\s]{3,30}$"
            ControlToValidate="txtNome"
            ErrorMessage="Informe o Nome corretamente."
            ForeColor="Red"
            runat="server"
        />
        <br /><br />
        Email: <br />
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RequiredFieldValidator 
            ID="reqEmail"
            ControlToValidate="txtEmail"
            ErrorMessage="Informe o E-mail"
            ForeColor="Red"
            runat="server"
        />
        <asp:RegularExpressionValidator 
            ID="regexEmail"
            ControlToValidate="txtEmail"
            ValidationExpression="^[a-z0-9.-_]+[@]+[a-z0-9]+[.]+[a-z.]{3,30}$"
            ErrorMessage="Informe o E-mail corretamente."
            ForeColor="Red"
            runat="server"
        />
        <br /><br />
        <asp:Button ID="btnCadastro" runat="server"
        Text="Cadastrar Cliente"
        OnClick="CadastrarCliente"
         />
        <p>
        <asp:Label ID="lblMensagem" runat="server" />
        </p>
        <p>
        <a href="Default.aspx">Voltar</a>  para a página inicial.
        </p>
    </div>
    </form>
</body>
</html>
