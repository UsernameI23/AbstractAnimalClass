abstract class Animal
{
    // Property
    public abstract string Name { get; set; }
    // Methods
    public abstract string Describe();
    public string whatAmI()
    {
        return "I am an animal";
    }
}
class Program
{
    class Cat : Animal
    {
        
        public override string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Cat()
        {
            Name = string.Empty;
            Type = string.Empty;
            Color = string.Empty;
        }
        public Cat(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
        
        public override string Describe()
        {
            return "I am a " + Type + "\nMy name is " + Name;
        }

    }
    static void Main(string[] args)
    {
        
        Cat whiskers = new Cat();
        whiskers.Name = "Whiskers";
        whiskers.Type = "Cat";
        whiskers.Color = "White";

        Console.WriteLine(whiskers.whatAmI());
        Console.WriteLine(whiskers.Describe());
    }
}