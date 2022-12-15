namespace SampleDesignPattern.FactoryMethodPattern
{
    public class IosProduct : Product
    {
        public IosProduct(int _id, string name, int _quantity)
        {
            this._id = _id;
            this._name = name;
            this._category = "IOS";
            this._quantity = _quantity;

        }
        public int _id;
        public string _name;
        public readonly string _category;
        public int _quantity;

        public override int Id => _id;

        public override string Name { get => _name; set => _name = value; }
        public override string Category { get => _category; }
        public override int Quantity { get => _quantity; set => _quantity = value; }
    }
}