var LocationIndex = 0;
var locationTracker = [];
$(document).ready(function() {
    console.log('test');
    var locationCount = (document.getElementsByClassName('location')).length;
    console.log('locationcount: ' + locationCount);

    // locationTracker = [locationCount];
    for (var i = 0; i < locationCount; i++) {
        locationTracker[i] = true;
    }
    console.log(locationTracker)
});

function initAutocomplete() {
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 13,
        center: {lat: 51.2171918, lng: 4.4212529},
        mapTypeControl: false,
        fullscreenControl : false
    });
    var geocoder = new google.maps.Geocoder();
    // Create the search box and link it to the UI element.
    var input = document.getElementById('pac-input');
    var button = document.getElementById('search-Button');
    var searchBox = new google.maps.places.SearchBox(input);
    map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);
    map.controls[google.maps.ControlPosition.TOP_LEFT].push(button);


    // Bias the SearchBox results towards current map's viewport.
    map.addListener('bounds_changed', function() {
        searchBox.setBounds(map.getBounds());
    });

    var markers = [];
    // Listen for the event fired when the user selects a prediction and retrieve
    // more details for that place.
    button.addEventListener("click", function() {
        var places = searchBox.getPlaces();
        console.log(locationTracker);
        var x = true;
        var teller = 0;
        while (x) {
            if (locationTracker[teller]) {
                LocationIndex = teller;
                x = false;
            } else {
                teller++;

            }
            if ( teller > document.getElementsByClassName('location').length) {
                x = false;
            }
        }
        LocationIndex = teller;
        //  console.log(teller);
        //  console.log(LocationIndex);
        //  console.log(document.getElementsByClassName('location').length);
        if (LocationIndex < document.getElementsByClassName('location').length) {

            var address = document.getElementById('pac-input').value;
            geocoder.geocode({ 'address': address },
                function(results, status) {
                    if (status === 'OK') {


                        var lat = results[0].geometry.location.lat().toString().replace('.', ',');
                        var lng = results[0].geometry.location.lng().toString().replace('.', ',');

                        var latitude = '#MapFieldVms_' + LocationIndex + '__Latitude';
                        var longitude = '#MapFieldVms_' + LocationIndex + '__Longitude';
                        $(latitude).attr('value', lat);
                        $(longitude).attr('value', lng);
                        locationTracker[teller] = false;

                        AddLocation(results[0].formatted_address, LocationIndex);


                        console.log(latitude);
                        console.log(longitude);

                        $('#pac-input').val('');
                    }

                });
            if (places.length == 0) {
                return;
            }

            // Clear out the old markers.
            markers.forEach(function(marker) {
                marker.setMap(null);
            });
            markers = [];

            // For each place, get the icon, name and location.
            var bounds = new google.maps.LatLngBounds();
            places.forEach(function(place) {
                if (!place.geometry) {
                    console.log("Returned place contains no geometry");
                    return;
                }
                var icon = {
                    url: place.icon,
                    size: new google.maps.Size(71, 71),
                    origin: new google.maps.Point(0, 0),
                    anchor: new google.maps.Point(17, 34),
                    scaledSize: new google.maps.Size(25, 25)
                };

                // Create a marker for each place.
                markers.push(new google.maps.Marker({
                    map: map,
                    icon: icon,
                    title: place.name,
                    position: place.geometry.location
                }));

                if (place.geometry.viewport) {
                    // Only geocodes have viewport.
                    bounds.union(place.geometry.viewport);
                } else {
                    bounds.extend(place.geometry.location);
                }
            });
            map.fitBounds(bounds);

        } else {
            alert("Max Locations");
        }
    });
}


function AddLocation (input,index) {

    var rowCount = $('.locationRow').length;
    var inputString = "";

    inputString += '<p class="locationText" >Location '+ index  + '</p>';
    inputString += '<p>' + input +' <a href="javascript:void(0);" class="remRow">Remove</a> </p>';
    $("#locationRows").append('<div id="locationRow'+ index  +'" class="locationRow">' + inputString + '</div>');

    var locationtexts = document.getElementsByClassName('locationText');
    for (var i = 0; i < locationtexts.length; i++) {
        locationtexts[i].innerText = 'Location ' + (i + 1);
    }
};


$("#locationRows").on('click', '.remRow', function () {


    // var max = document.getElementsByClassName('location');
    // var max = max.length;
    var rowIndex = (this).closest(".locationRow").id;
    rowIndex = rowIndex.charAt(rowIndex.length - 1) ;

    var latitude = '#MapFieldVms_' + rowIndex + '__Latitude';
    var longitude = '#MapFieldVms_' + rowIndex + '__Longitude';
    $(latitude).attr('value',0);
    $(longitude).attr('value',0);
    locationTracker[rowIndex] = true;

    (this).closest(".locationRow").remove();

    var locationtexts = document.getElementsByClassName('locationText');
    for (var i = 0; i < locationtexts.length; i++) {
        locationtexts[i].innerText = 'Location ' + (i + 1);
    }




});