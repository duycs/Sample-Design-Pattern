namespace Sample_Design_Pattern.AbstractFactoryPattern{

 class AnimalWorld{
        private Herbivore herbivore;
        private Carnivore carnivore;
        public AnimalWorld(ContinentFactory factory){
            herbivore = factory.CreateHerbivore();
            carnivore = factory.CreateCarnivore();
        }
        public void RunFoodChain(){
            carnivore.Eat(herbivore);
        }
    }
}