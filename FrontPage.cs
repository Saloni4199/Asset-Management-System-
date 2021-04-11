using System.Collections.Generic;
using System.Linq;
using System;

namespace AssetManagementSystem{
    class FrontPage : Asset{
        private static int choice = 1;
        bool returnValue;
        enum Operations{

            AddAsset = 1,
            SearchAsset ,
            UpdateAsset ,
            DeleteAsset ,
            ListAsset,
            Exit
        }

       /*  public static int ReturnChoice(){
            return choice;
        } */
        public FrontPage(){} 

        public void AddCategory(){

            Console.WriteLine("Enter the Category of Asset (BOOK/HARDWARE/SOFTWARE)");
            this.AssetCategory=Console.ReadLine();
        }  
        public void MakeChoice(){
                Admin newAdmin=HomePage.ReturnRefOfAdmin();
            do{
                Console.WriteLine("Make any Choice:");
                Console.WriteLine(".................");
                Console.WriteLine(" 1>Adding an Asset \n 2>Searching an Asset\n 3>Updating an Asset \n 4>Deleting an Asset \n 5>List of all available Asset \n 6>Exit");
                Console.WriteLine("-----------------------------");
                choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 6){;}

                else if( choice == Convert.ToInt32(Operations.AddAsset) || choice == Convert.ToInt32(Operations.SearchAsset) || choice == Convert.ToInt32(Operations.UpdateAsset)  || choice == Convert.ToInt32(Operations.DeleteAsset) || choice == Convert.ToInt32(Operations.ListAsset)){
                    // ChoosingAsset(choice);
                }
                else {
                    Console.WriteLine("Wrong Choice Made ! EXIT");
                }

            }while(choice != Convert.ToInt32(Operations.Exit));
        }

      
        public bool ChoosingAsset(int choice,string category, ClassForTest tempObj){
            // int choice = ReturnChoice();
             Admin newAdmin=HomePage.ReturnRefOfAdmin();
            // AddCategory();
            
            
            switch(category){
                
                case "BOOK":
                        
                    BookAsset bookClassObject = new BookAsset();
                    returnValue = bookClassObject.ChooseBookOperation(choice,tempObj);
                    if(choice == Convert.ToInt32(Operations.AddAsset)){
                        bookClassObject.AssetCategory = "BOOK";
                        newAdmin.listOfBookAsset.Add(bookClassObject);}

                break;

                case "HARDWARE" :
                    HardwareAsset hardwareClassObject = new HardwareAsset();
                    returnValue = hardwareClassObject.ChooseBookOperation(choice,tempObj);
                    if(choice == Convert.ToInt32(Operations.AddAsset)){
                        hardwareClassObject.AssetCategory = "HARDWARE";
                        newAdmin.listOfHardwareAsset.Add(hardwareClassObject);}
                break;

                case "SOFTWARE":
                    SoftwareAsset softwareClassObject = new SoftwareAsset();
                     returnValue = softwareClassObject.ChooseBookOperation(choice,tempObj);
                    if(choice == Convert.ToInt32(Operations.AddAsset)){
                        softwareClassObject.AssetCategory = "SOFTWARE LICENSE";
                        newAdmin.listOfSoftwareAsset.Add(softwareClassObject);}
                break;

                default :Console.WriteLine("Sorry! No such Category");
                break;

            }
            return returnValue;
               
        }
    }    
}
