using System.IO;
using System;

namespace AssetManagementSystem{
    class HomePage{
        public static void Main(string[] args){

            Admin newAdmin = new Admin("Saloni","1234");
            string filename="project.assets.json";
            
            // Console.WriteLine($"WELCOME !{newAdmin.AdminName} to ASSET MANAGEMNT SYSTEM");
            // Console.WriteLine("-----------------------------------------------------------------------------------");
            // Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine(Path.GetFullPath(filename));
            // FrontPage frontPageObject = new FrontPage();
            // frontPageObject.MakeChoice(ref newAdmin);

        }
    }
}