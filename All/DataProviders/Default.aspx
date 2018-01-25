<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataProviders._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>List of Data Providers on my system</title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td>
                    <h3 style="font-family: Verdana;">List of Data Providers Installed</h3>
                </td>
            </tr>
            <tr>
                <td align="center" style="font-family: Verdana;">
                    <asp:GridView ID="GVDataProviders" runat="server" CellSpacing="10" GridLines="None">
                        <HeaderStyle HorizontalAlign="Left" />
                        <RowStyle HorizontalAlign="Left" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
