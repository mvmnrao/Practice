<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SampleMvcApplication.Models.SampleModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Sample View
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% using (Html.BeginForm()){ %>
    <%: Html.ValidationSummary(true, "Below are the errors. Please correct the errors and try again.") %>

        <%: Html.TextBoxFor(m => m.SomeString)%>
        <input type="submit" value="Show Text" />
        <%: Html.LabelFor(m => m.ReturnString) %>
    <%} %>

</asp:Content>
