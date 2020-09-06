
namespace FoodApp.BL.Model
{
    public class FoodValue
    {
        public int Id { get; set; }
        public int Calories { get; set; }
        public float Proteins { get; set; }
        public float Fats { get; set; }
        public float Carbohydraties { get; set; }
        public int ProductId { get; set; }
        public override string ToString()
        {
            return $"Пищевая ценность {ProductId} на 100 гр. составляет:" +
                $"\n Углеводов - {Carbohydraties} гр.;" +
                $"\n Белков - {Proteins} гр.;" +
                $"\n Жиров - {Fats} гр. ;" +
                $"\n Энергитическая ценность - {Calories} ккал.";
        }
    }
}
