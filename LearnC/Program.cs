
internal sealed class Cat
{
    private readonly string _breed;
    private readonly string _name;
    private readonly int _age;

    public Cat(string breed, string name, int age)
    {
        _breed = breed;
        _name = name;
        _age = age;
    }

    public void Deconstruct(out string breed, out string name, out int age)
    {
        breed = _breed;
        name = _name;
        age = _age;
    }

    public void Deconstruct(out string name, out int age)
    {
        name = _name;
        age = _age;
    }
}
class Program()
{
    static void Main()
    {
        Cat cat = new Cat("Line", "Stepan", 4);
        var (breed, name, age) = cat;
        var (_, catAge) = cat;
        Console.WriteLine(catAge);

    }
}
