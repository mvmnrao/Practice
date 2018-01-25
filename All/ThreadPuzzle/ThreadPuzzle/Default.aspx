<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ThreadPuzzle._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    No.of Threads <asp:TextBox ID="txtBoxNoOfThreads" runat="server" Text="0"></asp:TextBox>
    <asp:Button ID="btnStartThreads" runat="server" Text="Run Threads" 
        onclick="btnStartThreads_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
</asp:Content>
