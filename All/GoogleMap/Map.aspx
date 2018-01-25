<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Map" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Google Map</title>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" /> 
    <style type="text/css">   
        html { height: 100% }   
        body { height: 100%; margin: 0px; padding: 0px }   
        #map_canvas { height: 100% } 
    </style>
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"> </script>
    <script type="text/javascript">
        function initialize() 
        {
            var latlng = new google.maps.LatLng(17.385044,78.486671);
            var myOptions = { zoom: 11, center: latlng, mapTypeId: google.maps.MapTypeId.ROADMAP };
            var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions); 
            
            var marker = new google.maps.Marker({
                                position: latlng, map: map, title:""
                            });            
        }
            
        function gotoLocation(lat, lang)
        {
            var latlng = new google.maps.LatLng(lat, lang);
            var myOptions = { zoom: 11, center: latlng, mapTypeId: google.maps.MapTypeId.ROADMAP };
            var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);            
            
            var myLatlng = new google.maps.LatLng(lat, lang);             
            
            var marker = new google.maps.Marker({
                                position: myLatlng, map: map, title:""
                            });
        }
        
        function getRoot()
        {
//            var myLatLng = new google.maps.LatLng(17.385044,78.486671);
//            var myOptions = { zoom: 8, center: myLatLng, mapTypeId: google.maps.MapTypeId.ROADMAP};
//            var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
//            var flightPlanCoordinates = [ new google.maps.LatLng(17.385044,78.486671), new google.maps.LatLng(17.686816, 83.218482)];
//            var flightPath = new google.maps.Polyline({ path: flightPlanCoordinates, strokeColor: "#FF0000", strokeOpacity: 0.5, strokeWeight: 5 }); 
//            flightPath.setMap(map);            
//            
//            var triangleCoords = [new google.maps.LatLng(17.385044,78.486671), new google.maps.LatLng(17.686816, 83.218482)];    
//            bermudaTriangle = new google.maps.Polygon({ paths: triangleCoords, strokeColor: "#FF0000", strokeOpacity: 0.8, strokeWeight: 3, fillColor: "#FF0000", fillOpacity: 0.35});
//            bermudaTriangle.setMap(map);
        }

        function calcRoute() 
        {
            var directionDisplay; 
            var directionsService = new google.maps.DirectionsService(); 
            var map; 
            
            directionsDisplay = new google.maps.DirectionsRenderer();   
            var chicago = new google.maps.LatLng(41.850033, -87.6500523);   
            var myOptions = {zoom:7, mapTypeId: google.maps.MapTypeId.ROADMAP, center: chicago}   
            map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
            directionsDisplay.setMap(map);                    
        
            var start = "Hyderabad, Andhra Pradesh";
            var end = "Visakhapatnam, Andhra Pradesh";
            var request = {origin:start, destination:end, travelMode: google.maps.DirectionsTravelMode.DRIVING};   
            
            directionsService.route(request, function(result, status) 
                                             {
                                                if (status == google.maps.DirectionsStatus.OK) 
                                                {
                                                    directionsDisplay.setDirections(result);
                                                }
                                             });
        }        
    </script>     
</head>
<body onload="initialize()">
    <form id="form1" runat="server">
        <table border="1" cellpadding="0" cellspacing="40" width="100%">
            <tr>
                <td style="width: 50%;">
                    <input type="button" value="Go To" id="BtnGoTo" onclick="gotoLocation(17.686816, 83.218482)" />
                    <input type="button" value="Get Root" id="Button1" onclick="calcRoute()" />
                </td>
                <td align="right" style="width: 500px;"><div id="map_canvas" style="width:500px; height:500px"></div></td>
            </tr>
        </table>        
        <div id="divPointer"><img src="images/pointer.jpg" alt=""/></div>
    </form>
</body>
</html>
