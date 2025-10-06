
internal class Animal
{
    public string Name { get; set; }

    protected string BaseClassName { get; } = nameof(Animal);
    public virtual void MakeSound()
    {
        Console.WriteLine("Звук не определен");   
    }
}

internal class Dog : Animal
{
    public new string Name { get; set; } = "Спаниэль";
    public override void MakeSound()
    {
        Console.WriteLine("Woof");  
    }
    public void PrintBaseClassName()
    {
        Console.WriteLine("Базовый класс не определен");
    }
}

internal class Cat : Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("Meow"); 
        
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        Animal animal = dog;
        dog.MakeSound();
        animal.MakeSound();

        Cat cat = new Cat();
        Animal animal2 = cat;
        cat.MakeSound();
        animal2.MakeSound();
        
        
    }
    
}