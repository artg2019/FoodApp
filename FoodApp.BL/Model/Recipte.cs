using System.Collections.Generic;

namespace FoodApp.BL.Model
{
    public class Recipte
    {
        public int RecipteId { get; set; }
        public string Name { get; set; }
        public int Portion { get; set; }


        public virtual Product Products{ get; set; }

        public virtual RecipteManual Manual { get; set; }

        public FoodType FoodTypes { get; set; }


        public override string ToString()
        {
            return $"Из данных продуктов можно приготовить:" +
                $"{Name} на {Portion}";
        }

    }
}
