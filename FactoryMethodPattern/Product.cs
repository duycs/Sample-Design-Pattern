namespace Sample_Design_Pattern.FactoryMethodPattern
{
    public abstract class Product
    {
        public abstract int Id {get;}
        public abstract string Name {get;set;}
        public abstract string Category{get;}
        public abstract int Quantity{get;set;}
    }
}