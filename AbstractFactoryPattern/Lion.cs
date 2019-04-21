using System;

namespace Sample_Design_Pattern.AbstractFactoryPattern{
class Lion : Carnivore
  {
    public override void Eat(Herbivore h)
    {
      // Eat Wildebeest

      Console.WriteLine(this.GetType().Name +
        " eats " + h.GetType().Name);
    }
  }
}