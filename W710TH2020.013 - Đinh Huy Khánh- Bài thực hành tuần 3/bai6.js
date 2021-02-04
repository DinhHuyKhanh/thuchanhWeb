/*
@Description
@author: Đinh Huy Khánh
@class: 1910A05
@create_date: 4-02-2021
@modifier: 
@modifier_date:  
*/


function xem() {
    var txtNgaySinh = document.getElementById('date').value.split("/");

    var date = new String(txtNgaySinh[1] + txtNgaySinh[0]);
    console.log(date);
    var cungHoangDao = [
        [11, 119, "Ma Kết"],
        [120, 218, "Bảo Bình"],
        [219, 320, "Song"],
        [321, 420, "Bạch Dương"],
        [421, 520, "Kim Ngưu"],
        [521, 621, "Song Tử"],
        [622, 722, "Cự Giải"],
        [723, 822, "Sư Tử"],
        [823, 922, "Xử Nữ"],
        [923, 1023, "Thiên Bình"],
        [1024, 1122, "Bọ Cạp"],
        [1123, 1221, "Nhân Mã"],
        [1222, 1230, 'Ma Kết'],
    ]

    for (let i = 0; i < cungHoangDao.length; i++) {
        if (cungHoangDao[i][0] <= date && cungHoangDao[i][1] >= date) {
            document.getElementById("cung").value = cungHoangDao[i][2];
            return;
        }
    }
}

function remove() {
    document.getElementById('date').value = "";
    document.getElementById('cung').value = "";
}