<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="UserServer.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="DOB"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" OnClick="ImageButton1_Click" />
     <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender" OnPreRender="Calendar1_PreRender"></asp:Calendar>
    </div>
       
    </form>
</body>
</html>
