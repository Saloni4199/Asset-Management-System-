var keyB="book1";
var keyH="hw1";
var keyS="sw1";


let deleteBook =function()
{   flag=0;
    var temp=document.getElementById("name").value;
    var bookArray = JSON.parse(localStorage.getItem(keyB)) || [];
    // console.log(bookArray);
    var newArray =[] ;
   for (let i=0;i<bookArray.length;i++){
            let temp3=bookArray[i];
            let temp2=temp3["bName"];
            if((temp.trim()).toUpperCase() == temp2.toUpperCase())
            {
                flag=1;
                alert("Deleted!");
            }
        else{
                newArray.push(temp3);
        }
    }
    if(flag == 0)
    {alert("Unable to delete ! Asset not found");}
    // console.log(newArray);
    localStorage.removeItem(keyB);
    localStorage.setItem(keyB,JSON.stringify(newArray));
    // console.log(JSON.parse(localStorage.getItem(keyB)));

}

let deleteHardware =function()
{   flag=0;
    var temp=document.getElementById("id").value;
    var HwArray = JSON.parse(localStorage.getItem(keyH)) || [];
    // console.log(Array);
    var newArray =[] ;
   for (let i=0;i<HwArray.length;i++){
            let temp3=HwArray[i];
            let temp2=temp3["hid"];
            if((temp.trim()).toUpperCase() == temp2.toUpperCase())
            {
                flag=1;
                alert("Deleted!");
            }
        else{
                newArray.push(temp3);
        }
    }
    if(flag == 0)
    {alert("not found");}
    // console.log(newArray);
    localStorage.removeItem(keyH);
    localStorage.setItem(keyH,JSON.stringify(newArray));
    // console.log(JSON.parse(localStorage.getItem(keyB)));
   
}

let deleteSoftware =function()
{   flag=0;
    var temp=document.getElementById("id").value;
    var SwArray = JSON.parse(localStorage.getItem(keyS)) || [];
    //  console.log(Array);
    var newArray =[] ;
   for (let i=0;i<SwArray.length;i++){
            let temp3=SwArray[i];
            let temp2=temp3["sid"];
            if((temp.trim()).toUpperCase() == temp2.toUpperCase())
            {
                flag=1;
                alert("Deleted!");
            }
        else{
                newArray.push(temp3);
        }
    }
    if(flag == 0)
    {alert("not found");}
    //  console.log(newArray);
    localStorage.removeItem(keyS);
    localStorage.setItem(keyS,JSON.stringify(newArray));
    // console.log(JSON.parse(localStorage.getItem(keyS)));
}
function returnToFirst(){
    window.location.href = "../index.html";
}