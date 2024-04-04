using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace Enginnier
{
    public class Engineer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public DateTime Birthday { get; set; }


        // Lista de projetos associados ao engenheiro
        public List<Project> Projects { get; set; }

        public Engineer()
        {
            ID = Guid.NewGuid().ToString().Substring(5, 9).ToUpper();
            Projects = new List<Project>();
        }

        public void ReadEngineerData(bool showID = true)
        {
            if (showID)
            {
                Console.WriteLine($"ID is {ID}");
            }
            Console.WriteLine("Insert name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Insert age: ");
            Age = Console.ReadLine();

            Console.WriteLine("Insert role: ");
            Role = Console.ReadLine();

            Console.WriteLine("Insert department: ");
            Department = Console.ReadLine();

            Console.WriteLine("Insert birthdate in the international model... (dd/MM/yy)");
            string inputBirthdate = Console.ReadLine();
            bool format = false;
            while (!format)
            {
                if (DateTime.TryParseExact(inputBirthdate, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime birthday))
                {
                    Birthday = birthday; // Atribuir o valor convertido à propriedade Birthday
                    format = true;
                }
                else
                {
                    Console.WriteLine("----Invalid format... please try again... -----");
                    inputBirthdate = Console.ReadLine();
                }
            }
        }

        public void ShowEngineerData()
        {
            Console.WriteLine("Engineer personal data...");
            Console.WriteLine("----------------------");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Birthdate: " + Birthday.ToString("dd/MM/yy"));
            Console.WriteLine("----------------------");


        }
    }
}
