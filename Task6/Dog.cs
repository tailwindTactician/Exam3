public abstract class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void Greeds()
    {
        Console.WriteLine("Woof");
    }
    public virtual void Greeds(BigDog another)
    {
        Console.WriteLine("Woooof");
    }
}
