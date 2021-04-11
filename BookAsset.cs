using System.Runtime.CompilerServices;
using System.Runtime;
using System;
using System.Collections.Generic;

namespace AssetManagementSystem
{

    public class BookAsset : Asset
    {
        bool value;

        public int BookPrice { get; set; }
        public int BookQuantity { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }



        public BookAsset()
        {

        }

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


        public override bool AddAsset(ClassForTest tempObj)
        {

            try
            {

                this.BookAuthor = tempObj.author;
                this.BookName = tempObj.name;
                this.BookPrice = tempObj.price;
                this.BookQuantity = tempObj.quantity;
                if(tempObj.author.Trim()=="" || tempObj.name.Trim() == "")
                return false;

                return true;


            }
            catch (Exception)
            {
                Console.WriteLine("wRONG INPUT");
                return false;
            }
        }
        public override void UpdateAsset()
        {
            Admin newAdmin = HomePage.ReturnRefOfAdmin();
            List<BookAsset> listOfBooks = newAdmin.listOfBookAsset;
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
        public bool SearchAsset(ClassForTest tempObj)
        {
            try
            {
                Admin newAdmin = HomePage.ReturnRefOfAdmin();
                List<BookAsset> listOfBooks = newAdmin.listOfBookAsset;
                //Search Function of Book Asset is called
                int flag = 0;

                string tempBookName = tempObj.name;
                if(tempObj.name.Trim() == "")
                return false;
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
                {
                    Console.WriteLine("SORRY! Asset Not Found!");

                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public bool DeleteAsset(ClassForTest tempObj)
        {

           
            try
            {
                 Admin newAdmin = HomePage.ReturnRefOfAdmin();
            List<BookAsset> listOfBooks = newAdmin.listOfBookAsset;
                //Delete Function of Book Asset is called"
                int flag = 0;

                string tempBookName = tempObj.name;
                if(tempObj.name.Trim() == "")
                return false;
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
                {
                    Console.WriteLine("Sorry! Record Not Found");

                }
                else { }

                return false;

            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
                // return false;
                return true;
            }
        }
        public override void ListAsset()
        {
            Admin newAdmin = HomePage.ReturnRefOfAdmin();
            List<BookAsset> listOfBooks = newAdmin.listOfBookAsset;
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