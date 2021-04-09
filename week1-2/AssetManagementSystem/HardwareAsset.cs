using System;
using System.Collections.Generic;

namespace AssetManagementSystem{
    public class HardwareAsset : Asset {
        private int HardwarePrice{get; set;}
        private int HardwareQuantity{get; set;}
        private string HardwareType{ get; set;}
        private string HardwareNumber{ get; set;}
        public HardwareAsset(int choice,ref Admin newAdmin){
            
            switch(choice){

                    case 1 : AddAsset();
                    break;

                    case 2 : SearchAsset(ref newAdmin.listOfHardwareAsset);
                    break;
  
                    case 3 : UpdateAsset(ref newAdmin.listOfHardwareAsset);
                    break;

                    case 4 : DeleteAsset(ref newAdmin.listOfHardwareAsset);
                    break;

                    default : ListAsset( ref newAdmin.listOfHardwareAsset );
                    break;
                }
             
        }
               
        public override void AddAsset(){

            try {
            Console.WriteLine("Enter  Hardware Type:");
            this.HardwareType=Console.ReadLine();

            Console.WriteLine("Enter Hardware Number:");
            this.HardwareNumber=Console.ReadLine();

            Console.WriteLine("Enter Hardware Price:");
            this.HardwarePrice=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Hardware Quantity:");
            this.HardwareQuantity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Asset Added!!");
            }
            catch(Exception){
                Console.WriteLine("Wrong Input");
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
        public void SearchAsset(ref List<HardwareAsset>  listOfHardwares){
            //"Search Function of Hardware Asset is called"
            int flag=0;
            Console.WriteLine("Enter Hardware Number");
            string tempHardwareNumber = Console.ReadLine();
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
        }
        public  void DeleteAsset(ref List<HardwareAsset> listOfHardware){
            //Delete Function of Hardware Asset is called
            int flag=0;
            Console.WriteLine("Enter the Hardware Number");
            string tempHardwareNumber = Console.ReadLine();
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
        }
        public  void ListAsset( ref List<HardwareAsset>  listOfHardwares ){
            //ListAsset Function of Hardware Asset is called"
            if(listOfHardwares.Count == 0)
                Console.WriteLine("Empty List!");
            else{
                Console.WriteLine("Assets of Type HARDWARE:");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Hardware Type\t Hardware Number\t Hardware Price\t Hardware Quantity \t Hardware Additional Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------") ;           
                for(int i = 0; i < listOfHardwares.Count; i++){
                    Console.WriteLine($"{listOfHardwares[i].HardwareType.ToUpper()}\t\t{listOfHardwares[i].HardwareNumber.ToUpper()}\t\t{listOfHardwares[i].HardwarePrice}\t\t{listOfHardwares[i].HardwareQuantity}");
                }  
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
        }
    }
}