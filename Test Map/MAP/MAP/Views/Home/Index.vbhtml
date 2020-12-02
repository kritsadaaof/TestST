﻿ 
<title>@ViewBag.Title</title>

<h2 style="background-color: Yellow;color: Blue; text-align: center; font-style: oblique">Satyaprakash's Bhubaneswar Google Map Using MVC and BOOTSTRAP</h2>
<fieldset>
    <legend style="font-family: Arial Black; color: blue; font-size: large;">Check Bhubaneswar City</legend>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <div id="googleMap" style="height:400px;width:100%;"></div>
    <script>
        function myMap() {
            var myCenter = new google.maps.LatLng(13.7434584, 100.5428397);
            var mapProp = { center: myCenter, zoom: 12, scrollwheel: false, draggable: false, mapTypeId: google.maps.MapTypeId.ROADMAP };
            var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
            var marker = new google.maps.Marker({ position: myCenter });
            marker.setMap(map);
        }
    </script>


    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCaVcDyEuGMgcc-GP3IhvNQdR5Lk2iZbqc&callback=myMap"></script>
</fieldset>
<footer>
    <p style="background-color: Yellow; font-weight: bold; color:blue; text-align: center; font-style: oblique">© @DateTime.Now.ToLocalTime()</p> @*Add Date Time*@
</footer>  