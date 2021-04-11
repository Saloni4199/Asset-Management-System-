using System;
using System.Collections.Generic;

namespace AssetManagementSystem{
    public class HardwareAsset : Asset {
        public int HardwarePrice{get; set;}
        public int HardwareQuantity{get; set;}
        public string HardwareType{ get; set;}
        public string HardwareNumber{ get; set;}

        bool value;
        public HardwareAsset(){}

        public bool ChooseBookOperation(int choice, ClassForTest tempObj)
        {



            switch (choice)
            {

                case 1:
                    value = AddAsset(tempObj);

                    break;

                case 2:
                    value = SearchAsset(tempObj);
                    break;

                case 3:
                    UpdateAsset();
                    break;

                case 4:
                    value = DeleteAsset(tempObj);
                    break;

                default:
                    ListAsset();
                    break;
            }

            return value;
        }

        public override  bool AddAsset(ClassForTest tempObj){

            try {
           
           this.HardwareNumber=tempObj.number;
           this.HardwarePrice=tempObj.price;
           this.HardwareQuantity=tempObj.quantity;
           this.HardwareType=tempObj.type;
           if(tempObj.number.Trim() == "" || tempObj.type== "" )
                return false;

            Console.WriteLine("Asset Added!!");
            return true;
            }
            catch(Exception){
                Console.WriteLine("Wrong Input");
                return false;
            }
            } 
        public  void UpdateAsset(ref List<HardwareAsset>  listOfHardwares){
            //Update Function of Hardware Asset is called
            int flag=0;
            Console.WriteLine("Enter Hardware Number");
            string tempHardwareNumber = Console.ReadLine();
            for(int i =0; i < listOfHardwares.Count ;i++){

                if(listOfHardwares[i].HardwareNumber.ToUpper()==tempHardwareNumber.ToUpper()){
                    Console.WriteLine("Asset Found!");

                Console.WriteLine("Enter updated Hardware Type:");
                listOfHardwares[i].HardwareType=Console.ReadLine();

                Console.WriteLine("Enter updated Hardware Price:");
                listOfHardwares[i].HardwarePrice=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter updated Hardware Quantity:");
                listOfHardwares[i].HardwareQuantity=Convert.ToInt32(Console.ReadLine());

                flag=1;
                break;
            }
        }
        if(flag == 0)
            Console.WriteLine("Asset not Found");

        }
        public  bool SearchAsset(ClassForTest tempObj){
            //"Search Function of Hardware Asset is called"
           try{ int flag=0;
            // Console.WriteLine("Enter Hardware Number");
            Admin newAdmin = HomePage.ReturnRefOfAdmin();
                List<HardwareAsset> listOfHardwares= newAdmin.listOfHardwareAsset;
            string tempHardwareNumber = tempObj.number;
            for(int i =0; i < listOfHardwares.Count ;i++){

                if(listOfHardwares[i].HardwareNumber.ToUpper()==tempHardwareNumber.ToUpper()){

                    Console.WriteLine("Asset Found!");
                    Console.WriteLine("Hardware Type\t Hardware Number\t Hardware Price\t Hardware Quantity");
                    Console.WriteLine("---------------------------------------------------------------------------------------") ;    
                    Console.WriteLine($"{listOfHardwares[i].HardwareType.ToUpper()}\t\t{listOfHardwares[i].HardwareNumber.ToUpper()}\t\t{listOfHardwares[i].HardwarePrice}\t\t{listOfHardwares[i].HardwareQuantity}");
                    Console.WriteLine("---------------------------------------------------------------------------------------") ;    
                    flag=1;
                    break;
                }
            }

            if(flag == 0)
            Console.WriteLine("SORRY! Asset Not Found!");
            return true;
           }
           catch(Exception){
               Console.WriteLine("Wrong");
               return false;
           }

        }
        public  bool DeleteAsset(ClassForTest tempObj){

          try{  //Delete Function of Hardware Asset is called
            int flag=0;
             Admin newAdmin = HomePage.ReturnRefOfAdmin();
                List<HardwareAsset> listOfHardware= newAdmin.listOfHardwareAsset;
            // Console.WriteLine("Enter the Hardware Number");
            string tempHardwareNumber = tempObj.number;
            for(int i  = 0; i < listOfHardware.Count ; i++){
                if(tempHardwareNumber.ToUpper() == listOfHardware[i].HardwareNumber.ToUpper()){
                    listOfHardware.Remove(listOfHardware[i]);
                    flag=1;
                    Console.WriteLine("ASSET DELETED");
                    break;
                }
            }
                if(flag == 0)
                Console.WriteLine("Sorry! Record Not Found");

                return true;
                }
            catch (Exception){
                    Console.WriteLine("Wrong");
                    return false;
                }
        }
        public  void ListAsset( ref List<HardwareAsset>  listOfHardwares ){
            //ListAsset Function of Hardware Asset is called"
            if(listOfHardwares.Count == 0)
                Console.WriteLine("Empty List!");
            else{
                Console.WriteLine("Assets of Type HARDWARE:");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Hardware Type\t Hardware Number\t Hardware Price\t Hardware Quantity ");
                Console.WriteLine("------------------------------------------------------------------------------------------------") ;           
                for(int i = 0; i < listOfHardwares.Count; i++){
                    Console.WriteLine($"{listOfHardwares[i].HardwareType.ToUpper()}\t\t{listOfHardwares[i].HardwareNumber.ToUpper()}\t\t\t{listOfHardwares[i].HardwarePrice}\t\t\t{listOfHardwares[i].HardwareQuantity}");
                    
                }  
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
        }
    }
}