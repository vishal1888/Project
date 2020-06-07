// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function GetCity(id) {

    console.log("State name : " + id);
    var stateid = 0;
    var x = document.getElementById("state").selectedIndex;
    var y = document.getElementById("state").options;
    stateid = y[x].index; //gets the index value when onchange everytime
    var count = document.getElementById("city").length;
    console.log("length is :" + count); //gets count of no. of options tags in city select tag
    $("#city").empty();
    //if (count !== 0) { another logic for removing previous options after onchange
    //    for (i = 0; i < count; i++) {
    //        var remove = document.getElementById("city");
    //        remove.remove(0);
    //        remove.remove(i);
    //    }
    //}
    $.getJSON("https://localhost:44358/Employees/GetCity/" + stateid, function (d) {
        for (i = 0; i < d.length; i++) {
            $("<option>" + d[i] + "</option>").appendTo(".getcity")
            // $("<tr scope='row'><td>" + d.EmpName + "</td><td>" + d.EmpDob + "</td><td>" + d.EmpPhone + "</td><td>" + d.EmpEmail + "</td><td>" + d.EmpDepartment + "</td><td>" + d.EmpAddress + "</td><td>" + d.EmpState + "</td><td>" + d.EmpCity + "</td><td>" + d.EmpZip + "</td><td>" + d.EmpJoiningDate + "</td><td><a href='AjaxFormEdit.html?EmployeeId="+d.EmployeeId+"' class='btn btn-danger'>Edit</a></td><tr>").appendTo("#tbl");
        }
    });

}

function EditGetCity(id) {

    console.log("State name : " + id);
    var stateid = 0;
    var x = document.getElementById("state").selectedIndex;
    var y = document.getElementById("state").options;
    stateid = y[x].index; //gets the index value when onchange everytime
    var count = document.getElementById("city").length;
    console.log("length is :" + count); //gets count of no. of options tags in city select tag
    $("#city").empty();
    //if (count !== 0) { another logic for removing previous options after onchange
    //    for (i = 0; i < count; i++) {
    //        var remove = document.getElementById("city");
    //        remove.remove(0);
    //        remove.remove(i);
    //    }
    //}
    $.getJSON("https://localhost:44358/Employees/GetCity/" + stateid, function (d) {
        for (i = 0; i < d.length; i++) {
            $("<option>" + d[i] + "</option>").appendTo(".getcity")
            // $("<tr scope='row'><td>" + d.EmpName + "</td><td>" + d.EmpDob + "</td><td>" + d.EmpPhone + "</td><td>" + d.EmpEmail + "</td><td>" + d.EmpDepartment + "</td><td>" + d.EmpAddress + "</td><td>" + d.EmpState + "</td><td>" + d.EmpCity + "</td><td>" + d.EmpZip + "</td><td>" + d.EmpJoiningDate + "</td><td><a href='AjaxFormEdit.html?EmployeeId="+d.EmployeeId+"' class='btn btn-danger'>Edit</a></td><tr>").appendTo("#tbl");
        }
    });

}
