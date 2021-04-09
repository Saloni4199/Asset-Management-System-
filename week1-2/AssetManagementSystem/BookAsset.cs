using System.Runtime;
using System;
using System.Collections.Generic;

namespace AssetManagementSystem
{
    
    public class BookAsset : Asset
    {
        private int BookPrice { get; set; }
        private int BookQuantity { get; set; }
        private string BookName { get; set; }
        private string BookAuthor { get; set; }

        public BookAsset(int choice, ref Admin newAdmin)
        {
             switch(choice){

                    case 1 : AddAsset();
                    break;

                    case 2 : SearchAsset(ref newAdmin.listOfBookAsset);
                    break;
  
                    case 3 : UpdateAsset(ref newAdmin.listOfBookAsset);
                    break;

                    case 4 : DeleteAsset(ref newAdmin.listOfBookAsset);
                    break;

                    default : ListAsset( ref newAdmin.listOfBookAsset );
                    break;
                }
        }
        public override void AddAsset()
        {

            try {
            Console.WriteLine("Enter Book Name:");
            this.BookName = Console.ReadLine();

            Console.WriteLine("Enter Book Author:");
            this.BookAuthor = Console.ReadLine();

            Console.WriteLine("Enter Book Price:");
            this.BookPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Quantity:");
            this.BookQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Asset Added!!");

            }
            catch(Exception){
                Console.WriteLine("wRONG INPUT");
            }
        }
        public void UpdateAsset(ref List<BookAsset> listOfBooks)
        {
            //Update Function of Book Asset is called
            int flag = 0;
            Console.WriteLine("Enter Book Name");
            string tempBookName = Console.ReadLine();
            for (int i = 0; i < listOfBooks.Count; i++)
            {

                if (listOfBooks[i].BookName.ToUpper() == tempBookName.ToUpper())
                {

                    Console.WriteLine("Asset Found!\n");

                    Console.WriteLine("Enter updated Book Author:");
                    listOfBooks[i].BookAuthor = Console.ReadLine();

                    Console.WriteLine("Enter updated Book Price:");
                    listOfBooks[i].BookPrice = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter updated Book Quantity:");
                    listOfBooks[i].BookQuantity = Convert.ToInt32(Console.ReadLine());

                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Sorry! Record not Found");


        }
        public void SearchAsset(ref List<BookAsset> listOfBooks)
        {
            //Search Function of Book Asset is called
            int flag = 0;
            Console.WriteLine("Enter Book Name");
            string tempBookName = Console.ReadLine();
            for (int i = 0; i < listOfBooks.Count; i++)
            {

                if (listOfBooks[i].BookName.ToUpper() == tempBookName.ToUpper())
                {

                    Console.WriteLine("Asset Found!");
                    Console.WriteLine(" Book Name\t Book Author\t Book Price\t Book Quantity ");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine($"{listOfBooks[i].BookName.ToUpper()}\t\t{listOfBooks[i].BookAuthor.ToUpper()}\t\t{listOfBooks[i].BookPrice}\t\t{listOfBooks[i].BookQuantity}");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.WriteLine("SORRY! Asset Not Found!");

        }
        public void DeleteAsset(ref List<BookAsset> listOfBooks)
        {
            //Delete Function of Book Asset is called"
            int flag = 0;
            Console.WriteLine("Enter the Book Name");
            string tempBookName = Console.ReadLine();
            for (int i = 0; i < listOfBooks.Count; i++)
            {
                if (tempBookName.ToUpper() == listOfBooks[i].BookName.ToUpper())
                {
                    listOfBooks.Remove(listOfBooks[i]);
                    flag = 1;
                    Console.WriteLine("ASSET DELETED");
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Sorry! Record Not Found");
        }
        public void ListAsset(ref List<BookAsset> listOfBooks)
        {
            //List Function of Book Asset is called
            if (listOfBooks.Count == 0)
                Console.WriteLine("Empty List");
            else
            {
                Console.WriteLine("Assets of Type:BOOK");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine(" Book Name\t Book Author\t Book Price\t Book Quantity");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                for (int i = 0; i < listOfBooks.Count; i++)
                {
                    Console.WriteLine($"{listOfBooks[i].BookName.ToUpper()}\t\t{listOfBooks[i].BookAuthor.ToUpper()}\t\t{listOfBooks[i].BookPrice}\t\t{listOfBooks[i].BookQuantity}");
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }

        }
    }
}