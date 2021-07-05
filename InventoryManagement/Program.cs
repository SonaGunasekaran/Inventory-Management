using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.JsonDeserialize();
            Console.Read();
        }
    }
}
