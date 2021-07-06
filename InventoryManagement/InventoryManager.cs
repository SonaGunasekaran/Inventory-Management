using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class InventoryManager
    {   //Add Rice List
        public List<InventoryUtility.Rice>AddToInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter the rice name : ");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter the rice name : ");
            utility.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice name : ");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            rice.Add(utility);
            return rice;
        }
        //Add Wheat List
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
        //Add Pulse List
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
        //Update the Rice List
        public List<InventoryUtility.Rice> UpdateToInventory(List<InventoryUtility.Rice> rice)
        {
            Console.WriteLine("Enter the rice name update:");
            string name = Console.ReadLine();
            rice.Remove(rice.Find(utl => utl.Name.Equals(name)));
            return rice;
        }
        //Update the Wheat List
        public List<InventoryUtility.Wheat> UpdateToInventory(List<InventoryUtility.Wheat> wheat)
        {
            Console.WriteLine("Enter the Wheat name update:");
            string name = Console.ReadLine();
            wheat.Remove(wheat.Find(utl => utl.Name.Equals(name)));
            return wheat;
        }
        //Update the Pulse List
        public List<InventoryUtility.Pulse> UpdateToInventory(List<InventoryUtility.Pulse> pulses)
        {
            Console.WriteLine("Enter the rice name update:");
            string name = Console.ReadLine();
            pulses.Remove(pulses.Find(utl => utl.Name.Equals(name)));
            return pulses;
        }
        //Remove Rice From Inventory 
        public List<InventoryUtility.Rice> RemoveFromInventory(List<InventoryUtility.Rice> rice)
        {
            Console.WriteLine("Enter the name of Pulse to be Removed:");
            string name = Console.ReadLine();
            rice.Remove(rice.Find(utl => utl.Name.Equals(name)));
            return rice;
        }
        //Remove Wheat From Inventory 
        public List<InventoryUtility.Wheat> RemoveFromInventory(List<InventoryUtility.Wheat> wheat)
        {
            Console.WriteLine("Enter the name of Pulse to be Removed:");
            string name = Console.ReadLine();
            wheat.Remove(wheat.Find(utl => utl.Name.Equals(name)));
            return wheat;
        }
        //Remove Pulse From Inventory 
        public List<InventoryUtility.Pulse> RemoveFromInventory(List<InventoryUtility.Pulse> pulse)
        {
            Console.WriteLine("Enter the name of Pulse to be Removed:");
            string name = Console.ReadLine();
            pulse.Remove(pulse.Find(utl => utl.Name.Equals(name)));
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
