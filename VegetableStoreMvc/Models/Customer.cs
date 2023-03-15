namespace VegetableStoreMvc.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Vegetable> VegetableList { get; set;}
    }
}
