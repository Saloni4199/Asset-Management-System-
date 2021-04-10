var keyB="book1";
var keyH="hw1";
var keyS="sw1";

function updateBook()
{   flag=0;
    var temp=document.getElementById("name").value;
    var bookArray = JSON.parse(localStorage.getItem(keyB));
    var newArray =[] ;
   for (let i=0;i<bookArray.length;i++){
            let temp3=bookArray[i];
            var temp2=temp3["bName"];
            if(temp.trim() == temp2)
            {
                flag=1;
                alert("Book Found");
               

            }
        else{
                newArray.push(temp3);
        }
    }
    if(flag == 0)
    {alert("not found");}
    localStorage.removeItem(keyB);
    localStorage.setItem(keyB,JSON.stringify(newArray));
    if(flag==1){
        window.location.href = "../Book/AddBook.html";
    }
    document.getElementById("name").value="";
}
function updateHardware()
{   flag=0;
    var temp=document.getElementById("id").value;
    var hwArray = JSON.parse(localStorage.getItem(keyH));
    console.log(hwArray);
    var newArray =[] ;
   for (let i=0;i<hwArray.length;i++){
            let temp3=hwArray[i];
            let temp2=hwArray[i]["hid"];
            if(temp.trim() == temp2)
            {
                flag=1;
                alert("Hardware Found");
              
            }
        else{
                newArray.push(temp3);
                }
    }
    if(flag == 0)
    {alert("Hardware not found");}
    localStorage.removeItem(keyH);
    localStorage.setItem(keyH,JSON.stringify(newArray));
   if(flag==1){
        window.location.href = "../Hardware/AddHardware.html";
    }
    document.getElementById("id").value=""; 
}

function updateSoftware()
{   flag=0;
    var temp=document.getElementById("id").value;
    var swArray = JSON.parse(localStorage.getItem(keyS));
    console.log(swArray);
    var newArray =[] ;
   for (let i=0;i<swArray.length;i++){
            let temp3=swArray[i];
            let temp2=swArray[i]["sid"];
            if(temp.trim() == temp2)
            {
                flag=1;           
                alert("Softwareware Found");
            }
        else{
                newArray.push(temp3);
               }
    }
    if(flag == 0)
    {alert("SOftware not found");}
    
    localStorage.removeItem(keyS);
    localStorage.setItem(keyS,JSON.stringify(newArray));
   
    if(flag==1){
        window.location.href = "../Software/AddSoftware.html";
    }
    document.getElementById("id").value="";
}