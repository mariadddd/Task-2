namespace AnimalApp
{
    internal interface IPredator:IAnimal
    {
        public void Attack(IPrey prey);
    }
}