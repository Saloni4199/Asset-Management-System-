using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace AssetManagementSystem
{

    public class Admin
    {


        public List<BookAsset> listOfBookAsset = new List<BookAsset>() { };
        public List<HardwareAsset> listOfHardwareAsset = new List<HardwareAsset>() { };
        public List<SoftwareAsset> listOfSoftwareAsset = new List<SoftwareAsset>() { };
        public Admin()
        {
             BookAsset obj1 = new BookAsset();
                obj1.BookName="fgsf";
                obj1.BookAuthor="fdgs";
                obj1.BookPrice=123;
                obj1.BookQuantity=453;

                listOfBookAsset.Add(obj1);

                BookAsset obj2 = new BookAsset();
                obj1.BookName="fgffgsf";
                obj1.BookAuthor="fdgfghs";
                obj1.BookPrice=1253;
                obj1.BookQuantity=44553;

                listOfBookAsset.Add(obj2);

                HardwareAsset obj3 = new HardwareAsset();

                obj3.HardwareNumber="fgsf";
                obj3.HardwareType="fdgs";
                obj3.HardwareQuantity=123;
                obj3.HardwarePrice=453;

                listOfHardwareAsset.Add(obj3);

                HardwareAsset obj4 = new HardwareAsset();
                obj4.HardwareNumber="fgffgsf";
                obj4.HardwareType="fdgfghs";
                obj4.HardwarePrice=1253;
                obj4.HardwareQuantity=44553;

                listOfHardwareAsset.Add(obj4);

                SoftwareAsset obj5 = new SoftwareAsset();

                obj5.SoftwareName= "dfgfd";
                obj5.SoftwarePrice = 2132;
                obj5.SoftwareType = "gr";

                listOfSoftwareAsset.Add(obj5);

                SoftwareAsset obj6 = new SoftwareAsset();

                obj6.SoftwareName= "dfggfdgfd";
                obj6.SoftwarePrice = 25132;
                obj6.SoftwareType = "grgsg";

                listOfSoftwareAsset.Add(obj6);

        }
    }
}