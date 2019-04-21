namespace Sample_Design_Pattern.FacadePattern{
    public class Customer{
        public int Id{get;set;}
        public string Name{get;set;}

        public Customer(int id, string name){
            Id = id;
            Name = name;
        }
    }
}