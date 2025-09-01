using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        public string Name { get; set; }
        private List<Table> assignedTables = new List<Table>();

        public Waiter(string name)
        {
            Name = name;
        }
        public void AssignTable(Table mesa)
        {
            assignedTables.Add(mesa);
        }

        public void TakeOrder(Table mesa, Dish plato)
        {
            if (assignedTables.Contains(mesa))
                mesa.AddDish(plato);
        }
    }
}