<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsumeServicios.aspx.vb" Inherits="Cliente.ConsumeServicios" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnConsumeServicio" runat="server" 
        Text="Consume Servicio" />
        <asp:Label ID="lblTransporte" runat="server" ></asp:Label>

        <asp:Button ID="btnAvion" runat="server" Text="Soy Avion" />
        <asp:Label ID="lblAvion" runat="server" ></asp:Label>

        <asp:Button ID="btnCarro" runat="server" Text="Soy Carro" />
        <asp:Label ID="lblCarro" runat="server" ></asp:Label>

        <asp:Button ID="btnFerrari" runat="server" Text="Soy Ferrari" />
        <asp:Label ID="lblFerrari" runat="server" ></asp:Label>

        <asp:Button ID="btnBus" runat="server" Text="Button" />

        </div>
    </form>
</body>
</html>
