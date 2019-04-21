using System;

namespace Sample_Design_Pattern.AbstractFactoryPattern{

class Wolf : Carnivore
  {
        public override void Eat(Herbivore h) =>
          // Eat Bison

          Console.WriteLine(this.GetType().Name +
            " eats " + h.GetType().Name);
    }
 
}