<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="assignment_1.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            Select an item :
            <asp:DropDownList ID="DropDownList" runat="server" Width="119px" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="Select" Value=" " />
                <asp:ListItem Text="Dairy Milk" Value="dairy milk.jpg" />
                <asp:ListItem Text="Kit kat" Value="kit kat.jpg" />
                <asp:ListItem Text="Ferrero rocher" Value="ferrero rocher.jpg" />
                <asp:ListItem Text="Toblerone" Value="toblerone.jpg" />
                <asp:ListItem Text="Snickers" Value="snickers.jpg" />
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="Images" runat="server" Height="194px" Width="275px" />
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonCost" runat="server" Text="Cost" Width="60px" OnClick="Button_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label" runat="server" Text=" "></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
