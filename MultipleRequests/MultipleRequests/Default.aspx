<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MultipleRequests._Default"%>

<%@ OutputCache Duration="10" VaryByParam="none" Location="Server" %>

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
    <h1><asp:Label ID="lblOne" runat="server" Text=""></asp:Label></h1>
    <asp:Button ID="BtnOne" runat="server" Text="Button One" OnClick="BtnOne_Click"/>
    <asp:Button ID="BtnTwo" runat="server" Text="Button Two"  OnClick="BtnTwo_Click"/>

    <h1><asp:Label ID="lblTwo" runat="server" Text=""></asp:Label></h1>


    <asp:Substitution ID="Substitution1" runat="server" MethodName="getSubstitutionContent"/>
</asp:Content>
