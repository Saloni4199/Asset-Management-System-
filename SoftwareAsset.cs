using System;
using System.Collections.Generic;

namespace AssetManagementSystem{
    public class SoftwareAsset : Asset{
        public int SoftwarePrice{get; set;}
        public string SoftwareName{ get; set;}
        public string SoftwareType{ get; set;}

        bool value;
        public SoftwareAsset(){}
             
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

               
        public override bool AddAsset(ClassForTest tempObj){

            try{
           
                    this.SoftwareName=tempObj.name;
                    this.SoftwarePrice=tempObj.price;
                    this.SoftwareType = tempObj.type;
                    if(tempObj.name.Trim()=="" || tempObj.type.Trim() == "")
                    return false;
                Console.WriteLine("Asset Added!!");
                return true;
            }
            catch(Exception){
                Console.WriteLine("Wrong Input");
                return false;
            }
    }

        public  void UpdateAsset(ref List<SoftwareAsset> listOfSoftware){
            //Update Function of Software Asset is called
            int flag=0;
            Console.WriteLine("Enter Software Name");
            string tempSoftwareName = Console.ReadLine();
            for(int i =0; i < listOfSoftware.Count ;i++){

                if(listOfSoftware[i].SoftwareName.ToUpper()==tempSoftwareName.ToUpper()){
                    
                    Console.WriteLine("Asset Found!");

                    Console.WriteLine("Enter updated Software Type:");
                    listOfSoftware[i].SoftwareType=Console.ReadLine();

                    Console.WriteLine("Enter updated Software Price:");
                    listOfSoftware[i].SoftwarePrice=Convert.ToInt32(Console.ReadLine());

                     flag=1;
                    break;
                }
        }
        if(flag == 0)
            Console.WriteLine("Asset not Found");

        }
        public  bool SearchAsset(ClassForTest tempObj){
           try{ //Search Function of software Asset is called
            int flag=0;
            // Console.WriteLine("Enter Software Name");
            Admin newAdmin = HomePage.ReturnRefOfAdmin();
                List<SoftwareAsset> listOfSoftware= newAdmin.listOfSoftwareAsset;
            string tempSoftwareName = tempObj.name;
            for(int i =0; i < listOfSoftware.Count ;i++){

                if(listOfSoftware[i].SoftwareName.ToUpper()==tempSoftwareName.ToUpper()){

                    Console.WriteLine("Asset Found!");
                    Console.WriteLine("Software Type\t Software Name\t Software Price");
                    Console.WriteLine("---------------------------------------------------------------------------------------") ;    
                    Console.WriteLine($"{listOfSoftware[i].SoftwareType.ToUpper()}\t\t{listOfSoftware[i].SoftwareName.ToUpper()}\t\t{listOfSoftware[i].SoftwarePrice}");
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
               return false;
           }
        }
        public bool DeleteAsset(ClassForTest tempObj){
            //Delete Function of Software Asset is called
          try{
 Admin newAdmin = HomePage.ReturnRefOfAdmin();
                List<SoftwareAsset> listOfSoftware= newAdmin.listOfSoftwareAsset;
          int flag = 0;
            // Console.WriteLine("Enter the Software Name");
            string tempSoftwareName = tempObj.name;
            for (int i = 0; i < listOfSoftware.Count; i++)
            {
                if (tempSoftwareName.ToUpper() == listOfSoftware[i].SoftwareName.ToUpper())
                {
                    listOfSoftware.Remove(listOfSoftware[i]);
                    flag = 1;
                    Console.WriteLine("ASSET DELETED");
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Sorry! Record Not Found");
                return true;
          }
          catch(Exception){
              return false;
          }
        }
        public void ListAsset(ref List<SoftwareAsset> listOfSoftware){
            //ListAsset Function of Software Asset is called
            if(listOfSoftware.Count == 0)
                Console.WriteLine("Empty List");
            else{
                Console.WriteLine("Assets of Type SOFTWARE:");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Software Type\t Software Name\t Software Price");
                Console.WriteLine("----------------------------------------------------------------------------") ;           
                for(int i = 0; i< listOfSoftware.Count; i++){
                    Console.WriteLine($"{listOfSoftware[i].SoftwareType.ToUpper()}\t\t{listOfSoftware[i].SoftwareName.ToUpper()}\t\t{listOfSoftware[i].SoftwarePrice}");
                }     
                Console.WriteLine("------------------------------------------------------------------------------");
            }
        }
    }
}