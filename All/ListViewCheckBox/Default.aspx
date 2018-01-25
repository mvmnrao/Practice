<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
    <table id="tbl" border="1" cellpadding="0" cellspacing="10" width="100%" style="border: 1px Solid Green;">
        <tr>
            <td>ONE: 
                <table id="tblOne" onmouseover="javascript:saveParent(this)" border="0" cellpadding="0" cellspacing="0" width="100%">                
                <asp:ListView ID="LV1" runat="server" onitemdatabound="LV1_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <input id='<%# Eval("ItemId")%>' type="checkbox" value='1' /><%# Eval("Text")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
                </table>
            </td>
            <td>TWO: 
                <table id="tblTwo" onmouseover="javascript:saveParent(this)" border="0" cellpadding="0" cellspacing="0" width="100%">                
                <asp:ListView ID="LV2" runat="server" onitemdatabound="LV2_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <input id='<%# Eval("ItemId")%>' type="checkbox" value='2' /><%# Eval("Text")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
                </table>            
            </td>
        </tr>
        <tr>
            <td>THREE: 
                <table id="tblThree" border="0" onmouseover="javascript:saveParent(this)" cellpadding="0" cellspacing="0" width="100%">                
                <asp:ListView ID="LV3" runat="server" onitemdatabound="LV3_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <input id='<%# Eval("ItemId")%>' type="checkbox" value='3' /><%# Eval("Text")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            <br />    
            FOUR: 
                <asp:ListView ID="LV4" runat="server" onitemdatabound="LV4_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <input id='<%# Eval("ItemId")%>' type="checkbox" value='4' /><%# Eval("Text")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
                </table>            
            </td>
        </tr>
    </table>

<script type="text/javascript" language="javascript">
    var parentId;
    function saveParent(parent) {
        parentid = $(parent).attr("id");
        //alert("on click: " + parentid);
    }


    $('#' + parentId + ' input:checkbox').change(function () {
        id = $(this).attr('id');
        value = $(this).attr('Value');
        checked = $(this).attr('checked');

        //alert("on checked: " + parentid);

        $("#" + parentId + " input:checkbox[id=" + id + "]").each(function () {

            if (value != $(this).attr('Value')) {
                if (checked == 'checked') {
                    $(this).attr("disabled", true);
                }
                else {
                    $(this).attr("disabled", false);
                }
            }
        });
    });

</script>
</asp:Content>
