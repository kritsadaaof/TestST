$(document).ready(function () {
    $.post(baseUrl + "Home/GetDATASO", {
       // BASE: "P1"
    }).done(function (data) {
        var pr = $.parseJSON(data);
        $.each(JSON.parse(data), function (i, obj) {
            $('#data-table-basic').dataTable().fnAddData([

                (i + 1), 
                pr[i]["SONUM"],
                pr[i]["SODAT"],
                pr[i]["cusnam"]

            ]);
        });
    }); 
});
function dateFormat() { 
    var d = new Date(); 
    month = '' + (d.getMonth() + 1), day = '' + d.getDate(), year = d.getFullYear();
    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;
    var val = day + "/" + month + "/" + year;
    return val;
}