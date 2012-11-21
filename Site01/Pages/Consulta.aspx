<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site01.Pages.Consulta" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formconsulta" runat="server">
    <div>
        
        <h3>Consulta ao Cadastro de Clientes</h3>

        <asp:GridView ID="gridClientes"  Width="60%" runat="server"  />

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
