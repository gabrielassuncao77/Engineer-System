using Enginnier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProjectEngineer
    {
        public List<ProjectEngineer> EngineerToProject { get; set; }
        public string project { get; set; }
        public string engineer { get; set; }
        


        public ProjectEngineer()
        {
            EngineerToProject = new List<ProjectEngineer>();
        }

        public void addResponsability() 
        {
            Console.WriteLine("Insert the project ID to add a person: ");
            project = Console.ReadLine();

            Console.WriteLine("Insert the engineer ID to add to the project...");
            engineer = Console.ReadLine();
        }

        public void showResponsables() 
        {
            Console.WriteLine($"{project} and responsables are: ");        
        }
    }

    
}
