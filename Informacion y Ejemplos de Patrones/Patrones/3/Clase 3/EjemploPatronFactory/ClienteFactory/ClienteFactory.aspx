<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClienteFactory.aspx.vb" Inherits="ClienteFactory.ClienteFactory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function btnConectar2_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblConexionInfo" runat="server">
        </asp:Label>
        <br />
        <asp:Button ID="btnConectar" runat="server" 
        Text="Conectar" />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:ListBox ID="lstConexiones" runat="server">
        </asp:ListBox>
    </div>
    
    </form>
</body>
</html>
