using System;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
 using NUnit.Framework;
 using System.Collections.Generic;


namespace AssetManagementSystem
{
    [TestFixture]
    public class HardwareAssetTests
    {
        Admin newAdmin =new Admin();
        ClassForTest tempObj = new ClassForTest();
        
              
        [TestCase(1,"HARDWARE")]
        public void HardwareAsset_TestAdditionAsset_ReturnTrue(int v1,string v2){
            
            tempObj.number="rgse";
            tempObj.name= "fgv";
            tempObj.price =4575;
            tempObj.quantity=43324;

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

            Assert.True(res);
        

        }
        [TestCase(4,"HARDWARE")]
        public void HardwareAsset_TestDeletionAsset_ReturnTrue(int v1,string v2){

            tempObj.number="hdth";
            tempObj.name= "fgsf";
            tempObj.price =432;
            tempObj.quantity=56464;
          

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

           
                Assert.That(res,Is.EqualTo(true));

           
                      
        }
         [TestCase(2,"HARDWARE")]
        public void HardwareAsset_TestSearchAsset_ReturnTrue(int v1,string v2){
            
            
             tempObj.number="dsfd";
            tempObj.name= "fgsf";
            tempObj.price =432;
            tempObj.quantity=43324;
          
                

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

            Assert.That(res,Is.EqualTo(true));
          
            
            
        }
       
    }
} 