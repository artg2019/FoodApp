
namespace FoodApp.BL.Model
{
    public class RecipteManual
    {
        public int Id { get; set; }
        public int CoockingTime { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Время приготовления составит {CoockingTime} мин." +
                $"Способ приготовления:\n {Description}";
        }
    }
}
