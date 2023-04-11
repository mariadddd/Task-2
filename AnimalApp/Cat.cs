using AnimalApp;

namespace AnimalApp
{
    internal class Cat : IPredator
    {
        public int Speed { get; set; } = 20;
        public void Attack(IPrey prey)
        {
            prey.Speed += prey.isNatural ? 10 : -10;
            if (Speed < prey.Speed || prey.Speed < 0) Console.WriteLine("Attack was not succesfull");
            else Console.WriteLine("Attack was succesfull");
        }
    }
}

