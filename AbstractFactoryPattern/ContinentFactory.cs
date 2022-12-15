namespace SampleDesignPattern.AbstractFactoryPattern{

abstract class ContinentFactory{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}
}