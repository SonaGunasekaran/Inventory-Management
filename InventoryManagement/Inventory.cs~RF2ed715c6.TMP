using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace InventoryManagement
{
    class Inventory
    {
        public static void JsonDeserialize()
        {
            InventoryManager manager = new InventoryManager();
            string filePath = @"C:\Users\Sona G\source\repos\InventoryManagement\InventoryManagement\JSon.json";
            //deserialize objects
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(filePath));


            Console.WriteLine("1.Display Rice \n2.Display Wheat\n3.Display Pulse");

             Console.WriteLine("Enter Your Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.DisplayInventory(utility.RiceList);
                    break;

                case 2:
                    manager.DisplayInventory(utility.WheatList);
                    break;

                case 3:
                    manager.DisplayInventory(utility.PulseList);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }
    }
}
