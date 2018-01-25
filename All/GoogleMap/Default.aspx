<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <script src="http://maps.google.com/maps?file=api&ampv=2&amp;sensor=true_or_false&amp;key=ABQIAAAAsLgNRxGiRzgwuubwxKScSRS0tnBKdbAzxYLMxHKE2h0S9sfpEBRfSNRP41g3P70OpNr-avA7Ja_s6A&sensor=false" type="text/javascript"></script>
    <script type="text/javascript">
    var map;
    var geocoder;
    function initialize() {
        if (GBrowserIsCompatible()) {  // does browser support  Google Maps APIMaps API
            map = new GMap2(document.getElementById("map"));   // create map in  DIV element called map. It works like container 
            map.setCenter(new GLatLng(17, 83), 5);  // start with Visakhapatnam  with its Latitude and Longitude  and  zoom is 5
            map.setUIToDefault();
        }
    }

    function showAddress(addresess)
        geocoder = new GClientGeocoder();
        // get GLatLng point for the given address 
        geocoder.getLatLng( 
                address,   // address to look for 
                function (point) {  // call back function to process the result 
                    if (!point) {  // if address not found
                        alert("Sorry the given address ["  +   address +  "] was not found!");
                    }
                    else {
                        //  point contains the required Latitude and Longitude
                        map.setCenter(point, 15);  // point map to the given 
                        var marker = new GMarker(point);  
                        map.addOverlay(marker);   // display a marker at the point in the map
                        marker.openInfoWindow(address);  // show address in a window
                    }
                }
            );
     }
                
     function findAddress() {
                var ddl = document.getElementById("ddlCompanies");  
                var address = ddl.options[ddl.selectedIndex].value;  // get selected address from dropdownlist
                showAddress(address); 
                return false;   // avoid postback
     }
    </script>
</head>
<body  onload="initialize()" onunload="GUnload()">
    <form id="form1" runat="server">
    Select Person : 
    <asp:DropDownList ID="ddlCompanies" runat="server">
        <asp:ListItem Value="Microsoft Corporation, One Microsoft Way, Redmond, WA 98052-7329,USA">Microsoft Corporation</asp:ListItem> 
        <asp:ListItem Value="1600 Amphitheatre Parkway, Mountain View, CA 94043">Google Inc.</asp:ListItem> 
        <asp:ListItem Value="500 Oracle Parkway,Redwood Shores, CA 94065">Oracle Corporation</asp:ListItem> 
        <asp:ListItem Value="One Dell Way,Round Rock, Texas 78682,United States">Dell Inc.</asp:ListItem> 
    </asp:DropDownList>
    <asp:Button ID="btnGetAddress" runat="server" Text="Get Address"  OnClientClick="return findAddress()"/>
    <p />
    <div id="map"  style="width:800px;height:600px">
    </div>
    </form>
</body>
</html>
