

using Pitomnik;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        List<Animals> Animals = new();
        string input = " ";
        while(!input.Equals("1") && !input.Equals("2") && !input.Equals("3") 
            && !input.Equals("4") && !input.Equals("5") && !input.Equals("6"))
        {
            input = read1();
        }

        if (input == "1") Animals.Add(Dog.AddDog());
        if (input == "2") Animals.Add(Cat.AddCat());
        if (input == "3") Animals.Add(Hamster.AddHamster());
        if (input == "4") Animals.Add(Horse.AddHorse());
        if (input == "5") Animals.Add(Camel.AddCamel());
        if (input == "6") Animals.Add(Donkey.AddDonkey());
    }

    static public string read1()
    {
        Console.Clear();
        Console.WriteLine("Добавление животного.");
        Console.WriteLine("1 - Собака.");
        Console.WriteLine("2 - Кошка.");
        Console.WriteLine("3 - Хомяк.");
        Console.WriteLine("4 - Лошадь.");
        Console.WriteLine("5 - Верблюд.");
        Console.WriteLine("6 - Осёл.");
        string read = "";
        read =  Console.ReadLine();
        return read;
    }
}



