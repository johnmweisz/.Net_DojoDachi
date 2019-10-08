// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Feed()
{
    jQuery.ajax({
        url: 'Feed',
        type: 'get',
     })
    .then( data =>{
        document.getElementById("message").innerHTML = data;
        jQuery.ajax({
            url: 'GetStatus',
            type: 'get',
         })
        .then( data =>{
            console.log(data);
            document.getElementById("status").innerHTML = data;
        });
    });
}