/**
 * @Description 
 * @@author: Đinh Huy Khánh 
 * @Create : 3/4/2021
 * @class : 1910A05
 * @modifier : 
 * @modifier_date :
 * */

var dsHang = [];

function displayThem() {
    document.getElementById("text-1").value = "";
    if (document.getElementById("them-moi-hang").style.display == "block") {
        document.getElementById("them-moi-hang").style.display = "none";
        // document.getElementById("sp").innerHTML = "";
        document.getElementById("them-hang").innerHTML = "Thêm";
    } else {
        document.getElementById("them-moi-hang").style.display = "block";
        //document.getElementById("sp").innerHTML = "";
        document.getElementById("them-hang").innerHTML = "Lưu";
    }
}

function addHang() {
    var name = document.getElementById("text-1").value;
    if (name == "" || name == null) {
        alert("Mời bạn nhập dữ liệu")
        return;
    }
    for (let i = 0; i < dsHang.length; i++) {
        if (dsHang[i] == name) {
            displayThem();
            return;
        }
    }
    dsHang.push(name);
    document.getElementById("ds-hang").innerHTML += '<option value ="' + name + '">' + name + '</option>';
    displayThem();
}

function Huy() {
    if (document.getElementById("them-moi-hang").style.display == "block") {
        displayThem();
    }
}

function openThem() {
    if (document.getElementById("them-moi-hang").style.display == "block") {
        addHang();
        return;
    }
    displayThem();
}