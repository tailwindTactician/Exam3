public abstract class BigDog : Dog
{
    public BigDog(string name) : base(name)
    {
    }

    public override void Greeds()
    {
        Console.WriteLine("Wooow");

    }
    public void Greeds(Dog another)
    {
        Console.WriteLine("Woooow");
    }
    public override void Greeds(BigDog another)
    {
        Console.WriteLine("Woooooow");
    }
}

    
