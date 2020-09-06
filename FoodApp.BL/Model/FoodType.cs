
namespace FoodApp.BL.Model
{
    public class FoodType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
