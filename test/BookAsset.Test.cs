using NUnit.Framework;


namespace AssetManagementSystem
{
    [TestFixture]
    public class BookAssetTests
    {
        Admin newAdmin =new Admin();
        ClassForTest tempObj = new ClassForTest();
        
              
        [TestCase(1,"BOOK")]
        public void BookAsset_TestAdditionAsset_ReturnTrue(int v1,string v2){
            
            tempObj.author="dsfd";
            tempObj.name= "fgsf";
            tempObj.price =432;
            tempObj.quantity=43324;

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

            Assert.True(res);
        

        }
        [TestCase(4,"BOOK")]
        public void BookAsset_TestDeletionAsset_ReturnTrue(int v1,string v2){

            tempObj.author="dsfd";
            tempObj.name= "fgsf";
            tempObj.price =432;
            tempObj.quantity=43324;
          

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

           
                Assert.That(res,Is.EqualTo(true));

           
                      
        }
         [TestCase(2,"BOOK")]
        public void BookAsset_TestSearchAsset_ReturnTrue(int v1,string v2){
            
            
             tempObj.author="dsfd";
            tempObj.name= "fgsf";
            tempObj.price =432;
            tempObj.quantity=43324;
          
                

            FrontPage frontPage = new FrontPage();
            bool res =frontPage.ChoosingAsset(v1,v2,tempObj);

            Assert.That(res,Is.EqualTo(true));
          
            
            
        }
       
    }
} 