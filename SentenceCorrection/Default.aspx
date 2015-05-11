<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox TextMode="MultiLine" ID="t1" runat="server"></asp:TextBox>
        <br />
    <asp:TextBox TextMode="MultiLine" ID="t2" runat="server"></asp:TextBox>
        <br />
        <asp:Button Text="click" runat="server" ID="btn" OnClick="btn_Click" />
    </div>
    </form>
</body>
</html>
