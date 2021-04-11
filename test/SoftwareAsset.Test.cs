using System;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
 using NUnit.Framework;
 using System.Collections.Generic;


namespace AssetManagementSystem
{
    [TestFixture]
    public class SoftwareAssetTests
    {
        Admin newAdmin =new Admin();
        ClassForTest tempObj = new ClassForTest();
        
              
        [TestCase(1,"SOFTWARE")]
        public void SoftwareAsset_TestAdditionAsset_ReturnTrue(int v1,string v2){
            
            tempObj.type="dsfd";
            tempObj.name= "fgsf";
            tempObj.price =432;
           

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

            Assert.True(res);
        

        }
        [TestCase(4,"SOFTWARE")]
        public void SoftwareAsset_TestDeletionAsset_ReturnTrue(int v1,string v2){

            tempObj.type="dsfd";
            tempObj.name= "fgsf";
            tempObj.price =432;
           
          

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

           
                Assert.That(res,Is.EqualTo(true));

           
                      
        }
         [TestCase(2,"SOFTWARE")]
        public void SoftwareAsset_TestSearchAsset_ReturnTrue(int v1,string v2){
            
            
             tempObj.type="dsfd";
            tempObj.name= "fgsf";
            tempObj.price =432;
           
          
                

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

            Assert.That(res,Is.EqualTo(true));
          
            
            
        }
       
    }
} 