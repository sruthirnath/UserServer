<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="UserServer.WebUserControl1" %>
 <div>
    
        <asp:Label ID="Label1" runat="server" Text="DOB"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" OnClick="ImageButton1_Click" />
     <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender"></asp:Calendar>
    </div>