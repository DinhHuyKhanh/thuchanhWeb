var txtChuoi = [];
var chuoi;

function parseData(chuoi) {
    // employees = data;

    chuoi.forEach(function(item) {
        txtChuoi.push(item);
    });
}

function thucHien() {
    chuoi = document.getElementById("chuoi").value.split(",");

    txtChuoi = [];

    if (chuoi == "") {
        alert("Mời bạn nhập chuỗi !");
        return;
    }
    parseData(chuoi);
    reset();
    txtChuoi.forEach(function(item) {
        document.getElementById('list').innerHTML += '<option value ="' + item + '" title="Bạn đã chọn mục ' + item + '">' + item + '</option>'
    })
}

function reset() {
    // $('#list')
    //     .find('option')
    //     .remove()
    //     .end()
    txtChuoi.forEach(function(item) {
        document.getElementById('list').innerHTML = ""
    })
}

function Huy() {
    document.getElementById('chuoi').value = "";
    reset();
}