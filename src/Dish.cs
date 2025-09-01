namespace Ucu.Poo.Restaurant
// clase Dish, no depende de ninguna otra
{
    public class Dish
    {
        public Dish(string name, double price, bool isVegetarian)
        { 
            this.Name = name;
            this.Price = price; 
            this.IsVegetarian = isVegetarian;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegetarian { get; set; }
    }
}


