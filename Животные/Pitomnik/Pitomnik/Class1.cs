﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitomnik
{
    public class Animals
    {
        public string name = "";
        public string birthDate = "";
        public string commands = "";
    }

    public class Pets : Animals
    {
        public string coatColor = "";
    }

    public class Dog : Pets 
    {
        public Dog(string name, string birthDate, string commands, string coatColor) 
        {
            this.name = name;
            this.birthDate = birthDate;
            this.commands = commands;
            this.coatColor = coatColor;
        }

        public static Dog AddDog()
        {
            Console.WriteLine("Введи кличку собаки");
            string name = Console.ReadLine();
            Console.WriteLine("Введи дату рождения собаки");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Введи исполняемые собакой команды");
            string commands = Console.ReadLine();
            Console.WriteLine("Введи цвет шерсти собаки");
            string coatColor = Console.ReadLine();

            Dog dog = new(name, birthDate, commands, coatColor);
            return dog;
        }
    }

    public class Cat : Pets
    {
        public Cat(string name, string birthDate, string commands, string coatColor)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.commands = commands;
            this.coatColor = coatColor;
        }

        public static Cat AddCat()
        {
            Console.WriteLine("Введи кличку кошки");
            string name = Console.ReadLine();
            Console.WriteLine("Введи дату рождения кошки");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Введи исполняемые кошкой команды");
            string commands = Console.ReadLine();
            Console.WriteLine("Введи цвет шерсти кошки");
            string coatColor = Console.ReadLine();

            Cat cat = new(name, birthDate, commands, coatColor);
            return cat;
        }
    }

    public class Hamster : Pets
    {
        public Hamster(string name, string birthDate, string commands, string coatColor)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.commands = commands;
            this.coatColor = coatColor;
        }

        public static Hamster AddHamster()
        {
            Console.WriteLine("Введи кличку хомячка");
            string name = Console.ReadLine();
            Console.WriteLine("Введи дату рождения хомячка");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Введи исполняемые хомячком команды");
            string commands = Console.ReadLine();
            Console.WriteLine("Введи цвет шерсти хомячка");
            string coatColor = Console.ReadLine();

            Hamster hamster = new(name, birthDate, commands, coatColor);
            return hamster;
        }
    }

    public class PackAnimals : Animals
    {
        public string works = "";
    }

    public class Horse : PackAnimals 
    {
        public Horse(string name, string birthDate, string commands, string works)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.commands = commands;
            this.works = works;
        }

        public static Horse AddHorse()
        {
            Console.WriteLine("Введи кличку лошади");
            string name = Console.ReadLine();
            Console.WriteLine("Введи дату рождения лошади");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Введи исполняемые лошадью команды");
            string commands = Console.ReadLine();
            Console.WriteLine("Введи выполняемые лошадью работы");
            string works = Console.ReadLine();

            Horse horse = new(name, birthDate, commands, works);
            return horse;
        }
    }

    public class Camel : PackAnimals
    {
        public Camel(string name, string birthDate, string commands, string works)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.commands = commands;
            this.works = works;
        }

        public static Camel AddCamel()
        {
            Console.WriteLine("Введи кличку верблюда");
            string name = Console.ReadLine();
            Console.WriteLine("Введи дату рождения верблюда");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Введи исполняемые верблюдом команды");
            string commands = Console.ReadLine();
            Console.WriteLine("Введи выполняемые верблюдом работы");
            string works = Console.ReadLine();

            Camel camel = new(name, birthDate, commands, works);
            return camel;
        }
    }

    public class Donkey : PackAnimals
    {
        public Donkey(string name, string birthDate, string commands, string works)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.commands = commands;
            this.works = works;
        }

        public static Donkey AddDonkey()
        {
            Console.WriteLine("Введи кличку осла");
            string name = Console.ReadLine();
            Console.WriteLine("Введи дату рождения осла");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Введи исполняемые ослом команды");
            string commands = Console.ReadLine();
            Console.WriteLine("Введи выполняемые ослом работы");
            string works = Console.ReadLine();

            Donkey donkey = new(name, birthDate, commands, works);
            return donkey;
        }
    }
}
