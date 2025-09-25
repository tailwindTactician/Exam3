public abstract class Animal
{
    private string name;
    public Animal(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    public abstract void Greeds();
}



    
