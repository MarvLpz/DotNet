<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DBOTry.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">Firstname</asp:Label>
            <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Label">Lastname</asp:Label>
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
            <asp:Button ID="add" runat="server" Text="Add" OnClick="add_Click" />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
