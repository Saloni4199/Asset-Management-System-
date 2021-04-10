var keyB="book1";
var keyH="hw1";
var keyS="sw1";

function searchBook(){
    flag=0;
    var temp=document.getElementById("name").value;
    
    var bookArray = JSON.parse(localStorage.getItem(keyB)) || [];
    // console.log(bookArray);
   for (let i=0;i<bookArray.length;i++){
            let temp3=bookArray[i];
            let temp2=temp3["bName"];
            if((temp.trim()).toUpperCase() == temp2.toUpperCase())
            {
                flag=1;
                alert("Book Found");
                localStorage.removeItem("temp");
                localStorage.setItem("temp",JSON.stringify(temp3));
                changeVisi(temp3);
                break;
            }
        
    }
    if(flag == 0)
    {alert("Book not found");
        
    }
    
}

function searchHardware(){
    flag=0;
    var temp=document.getElementById("id").value;
    var HwArray = JSON.parse(localStorage.getItem(keyH)) || [];
    // console.log(bookArray);
   for (let i=0;i<HwArray.length;i++){
            let temp3=HwArray[i];
            let temp2=temp3["hid"];
            if((temp.trim()).toUpperCase() == temp2.toUpperCase())
            {
                flag=1;
                localStorage.removeItem("temp1");
                localStorage.setItem("temp1",JSON.stringify(temp3));
                changeVisi(temp3);
                alert("Hardware Found");
                break;
            }
        
    }
    if(flag == 0)
    {alert("not found");}
    
}

function searchSoftware(){
    flag=0;
    var temp=document.getElementById("id").value;
    var SwArray = JSON.parse(localStorage.getItem(keyS)) || [];
    // console.log(bookArray);
   for (let i=0;i<SwArray.length;i++){
            let temp3=SwArray[i];
            let temp2=temp3["sid"];
            if((temp.trim()).toUpperCase() == temp2.toUpperCase())
            {
                flag=1;
                localStorage.removeItem("temp2");
                localStorage.setItem("temp2",JSON.stringify(temp3));
                changeVisi(temp3);
                alert("Software Found");
                
                break;
            }
        
    }
    if(flag == 0)
    {alert("not found");}
    
}
function returnToFirst(){
    window.location.href = "../index.html";
}
function changeVisi(temp3){
    document.getElementById("tableClass").style.visibility = "visible";

}