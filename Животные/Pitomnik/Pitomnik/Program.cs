

using Pitomnik;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        List<Animals> animals = new();
        string input = " ";

        while (!input.Equals("q"))
        {
            Console.Clear();
            Console.WriteLine("q - выход из программы");
            Console.WriteLine("");
            Console.WriteLine("1 - добавить животное");
            Console.WriteLine("2 - обучить новым командам");
            Console.WriteLine("3 - вывести список животных по дате рождения");
            Console.WriteLine("");
            Console.WriteLine("Всего животных: " + animals.Count);
            foreach (Animals animal in animals)
            {
                animal.print();
            }
            input = Console.ReadLine();
            if (input.Equals("q")) return;  //выход
            if (input.Equals("1")) addAnimal(animals);  //добавляем в список новое животное
            if (input.Equals("2")) addCommand(animals);  //обучаем новым командам
            if (input.Equals("3")) sortOfBirthData(animals);  //выводим список животных по дате рождения
        }
    }

    static void sortOfBirthData(List<Animals> animals)
    {
        foreach (Animals animal in animals.OrderBy(x => x.birthDate))
        {
            animal.print();
        }
        Console.Read();
    }

    static void addCommand(List<Animals> animals) 
    {
        string input = " ";
        int inputInt = 0;
        while (!input.Equals("q"))
        {
            Console.Clear();
            Console.WriteLine("q - выход в главное меню");
            Console.WriteLine("");
            Console.WriteLine("Введи число соответствующее требуемому животному:");
            int counter = 1;
            foreach (var animal in animals)
            {
                Console.Write(counter.ToString() + " ");
                animal.print();
                counter++;
            }
            input = Console.ReadLine();
            try
            {
                inputInt = Convert.ToInt32(input);
                animals[inputInt - 1].print();
                Console.WriteLine("Введи список новых команд:");
                animals[inputInt - 1].commands += ", " + Console.ReadLine();
            }
            catch { }
        }
    }

    static void addAnimal(List<Animals> animals)
    {
        string input = " ";
        while (!input.Equals("1") && !input.Equals("2") && !input.Equals("3")
            && !input.Equals("4") && !input.Equals("5") && !input.Equals("6"))
        {
            input = read1();
        }

        if (input == "1") animals.Add(Dog.AddDog());
        if (input == "2") animals.Add(Cat.AddCat());
        if (input == "3") animals.Add(Hamster.AddHamster());
        if (input == "4") animals.Add(Horse.AddHorse());
        if (input == "5") animals.Add(Camel.AddCamel());
        if (input == "6") animals.Add(Donkey.AddDonkey());
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



