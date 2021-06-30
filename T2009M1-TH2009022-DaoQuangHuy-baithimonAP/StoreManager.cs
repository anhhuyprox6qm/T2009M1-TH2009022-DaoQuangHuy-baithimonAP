using System;
using System.Collections.Generic;

namespace T2009M1_TH2009022_DaoQuangHuy_baithimonAP
{
    public class StoreManager
    {
        private Dictionary<string, Store> _stores = new Dictionary<string, Store>();

        public void AddProductRecords()
        {
            Console.WriteLine("Enter product ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Enter product name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            var price = double.Parse(Console.ReadLine());
            _stores.Add(id, new Store()
            {
                Name = name,
                Price = price
            });
        }
        public void DisplayProductRecords ()
        {
            foreach (var list in _stores)
            {
                Console.WriteLine($"ID: {list.Key},{list.Value}");
            }
        }
        public void DeleteProduct()
        {
            Console.WriteLine("Enter product ID: ");
            var id = Console.ReadLine();
            if (_stores.ContainsKey(id))
            {
                _stores.Remove(id);
            }
            else
            {
                Console.WriteLine("You must enter the product ID!");
            }
        }
    }
}