using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_
{
  
   public interface ISoundMaker
    {
        void MakeSound();
    }

    public interface IEat
    {
        void Eating();
    }

    public interface IFoodprovider
    {
        string Providefood();
    }

   
    public class Animal : ISoundMaker
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
       
    }

    
    public class Dog : Animal, IEat
    {
        private readonly IFoodprovider _foodprovider;
        public Dog(IFoodprovider foodprovider)
        {
            _foodprovider = foodprovider;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog makes a bark");
        }

        public void Eating()
        {
            string food = _foodprovider.Providefood();
          Console.WriteLine($"Dog eat {food}");
        }
    }

    
}

