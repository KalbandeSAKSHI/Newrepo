using Practice_C_;

class Program
{
    

    static void Main(string[] args)
    {
        Animal animal = new Animal();
       

        IFoodprovider meatprovider = new Meatprovider();
        IFoodprovider fruitprovider = new Fruitprovider();

        Dog meatEatingDog = new Dog(meatprovider);
        Dog fruitEatingDog = new Dog(fruitprovider);
       
        animal.MakeSound(); 
        meatEatingDog.Eating();
        fruitEatingDog.Eating();
        fruitEatingDog.MakeSound();
        
    }
}