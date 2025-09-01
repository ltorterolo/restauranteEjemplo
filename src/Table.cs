using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        public int TableNumber { get; set; }
        public bool IsOccupied { get; set; }
        public Table(int tableNumber, bool isOccupied)
        {
            TableNumber = tableNumber;
            IsOccupied = isOccupied;
        }
        
        private List<Dish> order = new List<Dish>();

        public void Occupy()
        {
            if (IsOccupied)
            {
                Console.WriteLine($"La mesa {TableNumber} está ocupada.");
            }
            else
            {
                Console.WriteLine("Mesa libre.");
            }
        }

        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        
        public void Free()
        {
            order.Clear();
            IsOccupied = false;
        }
        
        public bool HasOrders()
        {
            return order.Count > 0;
        }
    }
}