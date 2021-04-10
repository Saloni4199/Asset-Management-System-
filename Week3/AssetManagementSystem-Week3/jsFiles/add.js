
/* var assetCollectionBook = new Array();
let assetCollectionHW = new Array();
let assetCollectionSW = new Array(); */
var keyB = "book1";
var keyH = "hw1";
var keyS = "sw1";

let addBookAsset = function () {
    if (typeof (Storage) != "undefined") {
        var assetOfBook = JSON.parse(localStorage.getItem(keyB)) || [];
        var book = {
            bid: document.getElementById("bid").value.trim(),
            bName: document.getElementById("name").value.trim(),
            bAuthor: document.getElementById("author").value.trim(),
            bPrice: document.getElementById("price").value.trim(),
            bQuantity: document.getElementById("quantity").value.trim(),
            bType: document.getElementById("type").value.trim(),
            bEdition: document.getElementById("edition").value.trim()
        }
        assetOfBook.push(book);
        localStorage.setItem(keyB, JSON.stringify(assetOfBook));
        alert("Asset Added");
        // console.log(assetOfBook);
    }
    else {
        alert("Sorry! no able add");
    }

    document.getElementById("bid").value = "";
    document.getElementById("name").value = "";
    document.getElementById("author").value = "";
    document.getElementById("price").value = "";
    document.getElementById("quantity").value = "";
    document.getElementById("type").value = "";
    document.getElementById("edition").value = "";

}

let addHardwareAsset = function () {
    if (typeof (Storage) != "undefined") {
        var assetOfHardware = JSON.parse(localStorage.getItem(keyH)) || [];
        var hardware = {
            hname: document.getElementById("name").value.trim(),
            hid: document.getElementById("id").value.trim(),
            hnumber: document.getElementById("number").value.trim(),
            htype: document.getElementById("type").value.trim(),
            hQuantity: document.getElementById("quantity").value.trim(),
            hprice: document.getElementById("price").value.trim()
        }
        assetOfHardware.push(hardware);
        localStorage.setItem(keyH, JSON.stringify(assetOfHardware));
        alert("Asset Added");
        console.log(assetOfHardware);
    }
    else {
        alert("Sorry");
    }
    document.getElementById("name").value = "";
    document.getElementById("id").value = "";
    document.getElementById("number").value = "";
    document.getElementById("type").value = "";
    document.getElementById("quantity").value = "";
    document.getElementById("price").value = "";
}

let addSoftwareAsset = function () {

    if (typeof (Storage) != "undefined") {
        var assetOfSoftware = JSON.parse(localStorage.getItem(keyS)) || [];
        var software = {
            sname: document.getElementById("name").value.trim(),
            sid: document.getElementById("id").value.trim(),

            stype: document.getElementById("type").value.trim(),
            sQuantity: document.getElementById("quantity").value.trim(),
            sprice: document.getElementById("price").value.trim()
        }
        assetOfSoftware.push(software);
        localStorage.setItem(keyS, JSON.stringify(assetOfSoftware));
        alert("Asset Added");
        console.log(assetOfSoftware);
    }
    else {
        alert("Sorry");
    }
    document.getElementById("name").value = "";
    document.getElementById("id").value = "";
    document.getElementById("type").value = "";
    document.getElementById("quantity").value = "";
    document.getElementById("price").value = "";
}

function returnToFirst() {
    window.location.href = "../index.html";
}