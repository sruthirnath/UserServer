<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UserServer.WebForm1" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<%@ Register assembly="ser" namespace="ser" tagprefix="cc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:WebUserControl1 runat="server" ID="WebUserControl1" DisableFutureDates="true" />
    </div>
    </form>
</body>
</html>
