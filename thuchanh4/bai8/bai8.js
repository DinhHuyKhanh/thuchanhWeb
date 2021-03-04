// function Product(tenXVL, hangSX, ngayRaMat, gia) {
//     this.tenXVL = tenXVL;
//     this.hangSX = hangSX;
//     this.ngayRaMat = ngayRaMat;
//     this.gia = gia;
// }

/**
 * @Description
 * @@author:Đinh Huy Khánh 
 * @Create : 3/4/2021
 * @class : 1910A05
 * @modifier : 
 * @modifier_date :
 * */


var stt = 0;
//var products = [];

function addNew() {

    var tenXVL = document.getElementById("vxl").value;
    var hangSX = document.getElementById("hang").value;
    var ngayRaMat = document.getElementById("ngayRaMat").value;
    var gia = document.getElementById("gia").value;

    if (tenXVL == "" || hangSX == "" || ngayRaMat == "" || gia == "") {
        alert("Dữ liệu không được để trống! ");
        return;
    }
    if (checkDate() == 1) {
        //products.push(new Product(tenXVL, hangSX, ngayRaMat, gia));
        document.getElementById("tb-sx").innerHTML += '<tr> <td>' + ++stt + '</td> <td>' + tenXVL + '</td> <td>' + hangSX + '</td> <td>' + ngayRaMat + '</td> <td>' + gia + '</td> </tr>';
        reset();
    } else {
        alert("ngày ra mắt không thể lớn hơn ngày hiện tại! ");
    }
}

function reset() {
    document.getElementById("vxl").value = "";
    document.getElementById("hang").value = "";
    document.getElementById("ngayRaMat").value = "";
    document.getElementById("gia").value = "";
}

function checkDate() {
    var today = new Date();

    var parts = document.getElementById("ngayRaMat").value.split("/");
    var myDate = new Date(parts[2], parts[1] - 1, parts[0]);

    if (myDate <= today) {
        return 1;
    }
    return 0;
}