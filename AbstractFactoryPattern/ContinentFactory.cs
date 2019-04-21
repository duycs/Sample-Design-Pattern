namespace Sample_Design_Pattern.AbstractFactoryPattern{

abstract class ContinentFactory{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}
}