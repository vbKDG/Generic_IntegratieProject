function fileupload(filename) {
    var inputfile = document.getElementById(filename);
    var files = inputfile.files;
    var fdata = new FormData();
    for (var i = 0; i !== files.length  ; i++) {
        fdata.append("files",files[i]);
    }

    $.ajax(
        {
            url:"/Upload/Display",
            data: fdata,
            processData: false,
            contentType: false,
            type: "POST",
            succes: function(){
                console.log("xxx");
                alert("File upload succesfully ")

            },
            error: function () {
                alert("File upload failed!")
            }
        }
    );

    $.ajax(
        {
            url:"/Upload",
            data: fdata,
            processData: false,
            contentType: false,
            type: "POST",
            succes: function(){
                console.log("xxx");
                alert("File upload succesfully ")

            },
            error: function () {
                alert("File upload failed!")
            }
        }
    );
    
 
    
    
    
}