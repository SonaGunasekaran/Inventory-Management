using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;

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

            Console.WriteLine("\n 1)Display Inventory \n 2)Add to Inventory \n 3)Update To Inventory \n 4)Delete From Inventory");
            int inventory = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Display Rice \n2.Display Wheat\n3.Display Pulse");

            Console.WriteLine("Enter Your Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (inventory)
            {
                case 1:

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
                    break;



                case 2:
                    // Adding Inventory
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Add Rice Inventory");
                            utility.RiceList = manager.AddToInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.RiceList));
                            break;

                        case 2:
                            Console.WriteLine("Add Wheat Inventory");
                            utility.WheatList = manager.AddToInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.WheatList));
                            break;

                        case 3:
                            Console.WriteLine("Add Pulse Inventory");
                            utility.PulseList = manager.AddToInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.PulseList));
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                    Console.WriteLine("Inventory is updated");
                    break;

                case 3:
                    // Updating Inventory
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Add Rice Inventory");
                            utility.RiceList = manager.UpdateToInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.RiceList));
                            break;

                        case 2:
                            Console.WriteLine("Add Wheat Inventory");
                            utility.WheatList = manager.UpdateToInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.WheatList));
                            break;

                        case 3:
                            Console.WriteLine("Add Pulse Inventory");
                            utility.PulseList = manager.UpdateToInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.PulseList));
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                    Console.WriteLine("Inventory is updated");
                    break;
                case 4:
                    // Delete From Inventory
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Add Rice Inventory");
                            utility.RiceList = manager.RemoveFromInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.RiceList));
                            break;

                        case 2:
                            Console.WriteLine("Add Wheat Inventory");
                            utility.WheatList = manager.RemoveFromInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.WheatList));
                            break;

                        case 3:
                            Console.WriteLine("Add Pulse Inventory");
                            utility.PulseList = manager.RemoveFromInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility.PulseList));
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                    Console.WriteLine("Inventory is updated");
                         break;
                   default:
                       break;


            }
        }
    }
}
