using System;
using System.Collections.Generic;

namespace AssetManagementSystem{
    public class SoftwareAsset : Asset{
        private int SoftwarePrice{get; set;}
        private string SoftwareName{ get; set;}
        private string SoftwareType{ get; set;}
        public SoftwareAsset(int choice,ref Admin newAdmin){
           
            switch(choice){

                    case 1 : AddAsset();
                    break;

                    case 2 : SearchAsset(ref newAdmin.listOfSoftwareAsset);
                    break;
  
                    case 3 : UpdateAsset(ref newAdmin.listOfSoftwareAsset);
                    break;

                    case 4 : DeleteAsset(ref newAdmin.listOfSoftwareAsset);
                    break;

                    default : ListAsset( ref newAdmin.listOfSoftwareAsset );
                    break;
                }
             
        }
               
        public  override void AddAsset(){

            try{
            Console.WriteLine("Enter  Software Name:");
            this.SoftwareName=Console.ReadLine();

            Console.WriteLine("Enter Software Type:");
            this.SoftwareType=Console.ReadLine();

            Console.WriteLine("Enter Software Price:");
            this.SoftwarePrice=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Asset Added!!");
            }
            catch(Exception){
                Console.WriteLine("Wrong Input");
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
        public  void SearchAsset(ref List<SoftwareAsset> listOfSoftware){
            //Search Function of software Asset is called
            int flag=0;
            Console.WriteLine("Enter Software Name");
            string tempSoftwareName = Console.ReadLine();
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
        }
        public  void DeleteAsset(ref List<SoftwareAsset> listOfSoftware){
            //Delete Function of Software Asset is called
            int flag = 0;
            Console.WriteLine("Enter the Software Name");
            string tempSoftwareName = Console.ReadLine();
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