namespace SampleDesignPattern.FactoryMethodPattern
{
    public class AndroidProduct : Product
    {
        public readonly int _id;
        public string _name;
        public readonly string _category;
        public int _quantity;
        public AndroidProduct(int id,  string name, int quantity)
        {
            _id = id;
            _name = name;
            _category = "Android";
            _quantity = quantity;
        }

        public override int Id => _id;
        public override string Name { get => _name; set => _name = value;  }
        public override string Category { get => _category; }
        public override int Quantity {get => _quantity; set => _quantity = value;}
    }
}