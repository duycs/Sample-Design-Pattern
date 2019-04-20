namespace Sample_Design_Pattern.FactoryMethodPattern
{
    public class IosFactory : ProductFactory
    {
        public IosFactory(int id, string name, int quantity)
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
            return new IosProduct(Id, Name, Quantity);
        }
    }
}