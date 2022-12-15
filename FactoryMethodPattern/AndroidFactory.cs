namespace SampleDesignPattern.FactoryMethodPattern
{
    public class AndroidFactory : ProductFactory
    {
        public AndroidFactory(int id, string name, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;

        }
        public int Id { get; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override Product GetProductDetails()
        {
           return new AndroidProduct(Id, Name, Quantity);
        }
    }
}