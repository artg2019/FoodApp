using System.Collections.Generic;

namespace FoodApp.BL.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

        public int FoodValueId { get; set; }
        public virtual FoodValue FoodValues { get; set; }
        
        public int ProductTypeId { get; set; }
        public virtual FoodType FoodTypes { get; set; }

        public virtual List<Recipte> Reciptes { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
