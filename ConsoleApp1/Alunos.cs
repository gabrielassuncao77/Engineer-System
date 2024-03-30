using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginnier
{
    public class Engineer
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string role { get; set; }
        public string department { get; set; }
        public DateTime birthday { get; set; }

        public Engineer()
        {
            ID = Guid.NewGuid().ToString().Substring(1, 9).ToUpper();

        }

        public void readEnginnerData(bool showID = true)
        {
            if (showID)
            {
                Console.WriteLine($"ID is {ID}");
            }
            Console.WriteLine("Insert name: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert age: ");
            age = Console.ReadLine();

            Console.WriteLine("Insert role: ");
            role = Console.ReadLine();

            Console.WriteLine("Insert deparment: ");
            department = Console.ReadLine();

            Console.WriteLine("Insert birthdate in the internacional model... (dd/MM/yy");
            string inputBirthdate = Console.ReadLine();
            bool format = false;
            while (!format)
            {
                if (DateTime.TryParseExact(inputBirthdate, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime birthday))
                {
                    format = true;
                }
                else
                {
                    Console.WriteLine("----Invalid format... please try again... -----");
                    inputBirthdate = Console.ReadLine();
                }
            }
        }

        public void showEnginnerData()
        {
            Console.WriteLine("Enginner personal data...");
            Console.WriteLine("----------------------");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"role: {role}");
            Console.WriteLine($"department: {department}");
            Console.WriteLine($"Birthdate: " + birthday.ToString("dd/MM/yy"));
            Console.WriteLine("----------------------");

         }
    }
}