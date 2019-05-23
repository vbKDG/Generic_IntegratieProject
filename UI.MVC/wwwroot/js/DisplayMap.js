var LocationIndex = 0;
var locationTracker = [];

var latitude = 0;
var longitude = 0;
var LocationIndex =0;

$(document).ready(function() {
    console.log('test');
    var locationCount = (document.getElementsByClassName('location')).length;
    console.log('locationcount: ' + locationCount);

    // locationTracker = [locationCount];
    for (var i = 0; i < locationCount; i++) {
        locationTracker[i] = true;
    }
     latitude = (document.getElementById('location_latitude_0').innerText).replace(',', '.');
     longitude = (document.getElementById('location_longitude_0').innerText).replace(',', '.');
     
   
    
});

function initAutocomplete() {
    latitude = Number( (document.getElementById('location_latitude_0').innerText).replace(',', '.'));
    longitude = Number((document.getElementById('location_longitude_0').innerText).replace(',', '.'));
    console.log('lat: ' + latitude);
    console.log('lng: ' + longitude );
    var location = {lat: latitude, lng: longitude};    
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 13,
        center: location,
        mapTypeControl: false,
        fullscreenControl : false
    });
    var marker = new google.maps.Marker({position: location, map: map});

    var geocoder = new google.maps.Geocoder;
    var infowindow = new google.maps.InfoWindow;

   // geocodeLatLng(geocoder, map, infowindow, marker);

   

    var latlng = {lat:latitude, lng:longitude};
    geocoder.geocode({'location': latlng}, function(results, status) {
        if (status === 'OK') {
            if (results[0]) {
                map.setZoom(13);

                infowindow.setContent(results[0].formatted_address);
                infowindow.open(map, marker);
            } else {
                window.alert('No results found');
            }
        } else {
            window.alert('Geocoder failed due to: ' + status);
        }
    });

    marker.addListener('click', function() {
        infowindow.open(map, marker);


    });
    
    document.getElementById("NextLocation").addEventListener("click", function() {
      var lats = document.getElementsByClassName('latitude');
      var lngs = document.getElementsByClassName('longitude');
      if(LocationIndex == (lats.length -1)){
          LocationIndex=0;
      }else{
          LocationIndex++;
      }   
      
        latitude = Number( lats[LocationIndex].innerText.replace(',', '.'));
        longitude = Number( lngs[LocationIndex].innerText.replace(',', '.'));
        var latlng = new google.maps.LatLng(latitude, longitude);

        map.setCenter(latlng );
        marker.setPosition(latlng);

        geocoder.geocode({'location': latlng}, function(results, status) {
            if (status === 'OK') {
                if (results[0]) {
                    map.setZoom(13);

                    infowindow.setContent(results[0].formatted_address);
                    infowindow.open(map, marker);
                } else {
                    window.alert('No results found');
                }
            } else {
                window.alert('Geocoder failed due to: ' + status);
            }
        });
        
    });
}

function geocodeLatLng(geocoder, map, infowindow,marker) {
    
    var latlng = {lat:latitude, lng:longitude};
    geocoder.geocode({'location': latlng}, function(results, status) {
        if (status === 'OK') {
            if (results[0]) {
                map.setZoom(13);
              
                infowindow.setContent(results[0].formatted_address);
                infowindow.open(map, marker);
            } else {
                window.alert('No results found');
            }
        } else {
            window.alert('Geocoder failed due to: ' + status);
        }
    });
}

