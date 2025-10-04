namespace homework1.homework7;

public class Cat
{
    public string Name { get; set; }
    public string Breed { get; set; }
    string gender { get; set; } // maybe we could use bool but in the example we had input as male 
    int age { get; set; }
    private int biteCapacity = 10;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }

    public string Gender
    {
        get
        {
            return gender;
        }
        set
        {
            gender = value;
        }
    }

    public void meow()
    {
        Console.WriteLine("Meowing ...");
    }

    public void eat(int grams)
    {
        int numOfBites = grams % biteCapacity == 0 ? grams / biteCapacity : grams / biteCapacity + 1;
        for (int i = 0; i < numOfBites; i++)
        {
            Console.WriteLine("Eating ...");
        }
    }

    public static void main()
    {
        Console.WriteLine("Creating cat object...");
        Cat cat = new Cat();
        Console.Write("Enter cat name: ");
        string name = Console.ReadLine();
        cat.Name = name;
        Console.Write("Enter breed: ");
        string breed = Console.ReadLine();
        cat.Breed = breed;
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        cat.Age = age;
        Console.Write("Enter sex: ");
        string biteCapacity = Console.ReadLine();
        cat.Gender = biteCapacity;
        Console.WriteLine("Cat object created.");
        Console.Write("Enter food weight in grams: ");
        int foodWeight = int.Parse(Console.ReadLine());
        Console.WriteLine($"{cat.Name} starts eating");
        cat.eat(foodWeight);
        Console.WriteLine($"{cat.Name} finished eating");
        Console.Write("Enter meowing count: ");
        int meowingCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < meowingCount; i++)
        {
            cat.meow();
        }
    }
}