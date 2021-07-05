using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryManager
    {   //Rice List
        public List<InventoryUtility.Rice>AddToInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter the rice name : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter the rice name : ");
            utility.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice name : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            riceList.Add(utility);
            return riceList;
        }
        //Wheat List
        public List<InventoryUtility.Wheat> AddToInventory(List<InventoryUtility.Wheat> wheat)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter the rice name : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight in Kg : ");
            utility.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of rice : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            wheat.Add(utility);
            return wheat;
        }
        // Pulse List
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter the rice name : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter the rice name : ");
            utility.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice name : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            pulse.Add(utility);
            return pulse;
        }
        // Display and calculate the rice total
        public void DisplayInventory(List<InventoryUtility.Rice> rice)
        {
            
            string ricestring = string.Empty;
            int riceTotal = 0;
            foreach (InventoryUtility.Rice value in rice)
            {
                ricestring= "\n name = " + value.Name +"\n weight = " +value.Weight+ "\n Price = "+value.Price;
                riceTotal +=ManageInventory(value.Weight, value.Price);
            }
            Console.WriteLine("\nTotal rice price: " +" "+riceTotal);

        }
        // Display and calculate the wheat total
        public void DisplayInventory(List<InventoryUtility.Wheat> wheat)
        {

            string wheatstring = string.Empty;
            int wheatTotal = 0;
            foreach (InventoryUtility.Wheat value in wheat)
            {
                wheatstring = "\n name = " + value.Name + "\n weight = " + value.Weight + "\n Price = " + value.Price;
                wheatTotal += ManageInventory(value.Weight, value.Price);
            }
            Console.WriteLine("\nTotal rice price: " + " " + wheatTotal);

        }
       // Display and calculate the pulse total
        public void DisplayInventory(List<InventoryUtility.Pulse> pulse)
        {

            string pulsestring = string.Empty;
            int pulseTotal = 0;
            foreach (InventoryUtility.Pulse value in pulse)
            {
                pulsestring = "\n name = " + value.Name + "\n weight = " + value.Weight + "\n Price = " + value.Price;
                pulseTotal += ManageInventory(value.Weight, value.Price);
            }
            Console.WriteLine("\nTotal rice price: " + " " + pulseTotal);

        }
        //calculate total
        public int ManageInventory(int weight, int price)
        {
            return weight * price;
        }

    }
}
