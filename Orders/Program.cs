using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ItemInfo> items = new Dictionary<string, ItemInfo>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] itemInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string itemName = itemInput[0];
                double itemPrice = double.Parse(itemInput[1]);
                int itemQuantity = int.Parse(itemInput[2]);

                if (!items.ContainsKey(itemName))
                {
                    ItemInfo itemInfo = new ItemInfo(itemPrice, itemQuantity);
                    items.Add(itemName, itemInfo);
                }
                else
                {
                    if (items[itemName].Price != itemPrice)
                    {
                        items[itemName].Price = itemPrice;
                    }
                    items[itemName].Quantity += itemQuantity;
                }
            }
            foreach (var kvp in items)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.TotalValue():f2}");
            }
        }
    }
    public class ItemInfo
    {
        public double Price{get;set;}
        public int Quantity { get; set; }

        public ItemInfo(double price, int quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }

        public double TotalValue()
        {
            return this.Price * this.Quantity;
        }
    }
}
