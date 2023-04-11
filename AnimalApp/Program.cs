namespace AnimalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new() { isNatural = true };
            Mouse mouse2 = new() { Speed = 5 };
            Mouse mouse3 = new();
            Cat cat = new();
            
            cat.Attack(mouse);
            cat.Attack(mouse2);
            cat.Attack(mouse3);
        }
    }
}