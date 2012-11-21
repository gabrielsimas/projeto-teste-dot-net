<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site02.Pages.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        body { font-family: Trebuchet MS; font-size: 10pt; padding: 30px;}
    </style>

</head>
<body>
    <form id="formulario" runat="server">
    <div>
        <h3>Manter Estoque</h3>

        <p>
            Utilize o Formul&aacute;rio abaixo para cadastrar um novo produto no Estoque
        </p>
        <p><label>Nome do Produto: </label></p>
        <p><asp:TextBox ID="txtNome" runat="server"/></p>
        <p><label>Pre&ccedil;o: </label></p>
        <p><asp:TextBox ID="txtPreco" runat="server" /></p>

        <p><label>Fornecedor: </label></p>
        <p><asp:DropDownList ID="ddlFornecedor" runat="server" /></p>

        <asp:Button ID="btnCadastro" Text="Cadastrar Produto" OnClick="CadastrarProduto"  runat="server"/>

        <p>
            <asp:Label ID="lblMensagem" runat="server" />
        </p>

    </div>
    </form>
</body>
</html>
