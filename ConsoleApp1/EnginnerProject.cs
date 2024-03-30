using Enginnier;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EnginnerProject : Engineer
    {
        public string projectName { get; set; }
        public string projectDescription { get; set; }
        public ArrayList engineers { get; set; }

        public void readProject()
        {
            Console.WriteLine("------- ENGINEER PROJECT -------");
            Console.WriteLine("Insert project: ");
            projectName = Console.ReadLine();
            Console.WriteLine("Insert description to the project?");
            projectDescription = Console.ReadLine();
        }
        public void showProject()
        {
            Console.WriteLine("Enginner personal projects...");
            Console.WriteLine($"Project: {projectName}");
            Console.WriteLine($"Description: {projectDescription}");
            Console.WriteLine();
        }
        public void addEnginner(Engineer engineer)
        {
            engineers.Add(engineer);
        }
        public void removeEngineer(Engineer X)
        {
            engineers.Remove(X);
        }


    }
}
