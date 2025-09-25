public abstract class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void Greeds()
    {
        Console.WriteLine("Meow");
    }
}