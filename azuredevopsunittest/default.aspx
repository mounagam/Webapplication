<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="azuredevopsunittest._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    number1: <asp:TextBox ID="number1" runat="server"> </asp:TextBox>   
    </div>
        <div>
             number2: <asp:TextBox ID="number2" runat="server"> </asp:TextBox>
        </div>
        <div>
            <br />
            <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
            <asp:Button ID="Minus" runat="server" Text="Minus" OnClick="Minus_Click" />
            <asp:Button ID="Multi" runat="server" Text="Multi" OnClick="Multi_Click" />
        </div>

        <div>
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
