using System;

namespace AssetManagementSystem{
    class HomePage{
        static Admin newAdmin = new Admin();
        public static void Main(string[] args){

            FrontPage frontPageObject = new FrontPage();
            frontPageObject.MakeChoice();

        }
         public static Admin ReturnRefOfAdmin(){
            return newAdmin;
        }

       
    }
}