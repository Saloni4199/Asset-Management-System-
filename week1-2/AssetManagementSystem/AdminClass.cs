using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace AssetManagementSystem{

    public class Admin {
        private string AdminPassWord { get; set; }
        public string AdminName { get; set ;}    

        public List<BookAsset> listOfBookAsset=new List<BookAsset>(); 
        public List<HardwareAsset> listOfHardwareAsset=new List<HardwareAsset>(){};
        public List<SoftwareAsset> listOfSoftwareAsset=new List<SoftwareAsset>(){};
        public Admin(string adminName , string adminPassWord){ 


            this.AdminName=adminName;
            this.AdminPassWord=adminPassWord;
            
        }
    }
}