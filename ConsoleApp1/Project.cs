using Enginnier;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Project
    {
        public string projectName { get; set; }
        public string projectDescription { get; set; }
        public string ProjectID { get; set; }
        public string EngineerID { get; set; } 

        public List<Engineer> Engineers { get; set; }

        public Project()
        {
            ProjectID = Guid.NewGuid().ToString().Substring(5, 9).ToUpper();
            Engineers = new List<Engineer>();
        }
        public void readProject(bool showID = true)
        {
            if (showID) 
            {
                Console.WriteLine($"New ID is... {ProjectID}");  
            }
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
            Console.WriteLine($"ID: {ProjectID}");
            Console.WriteLine();
        }




    }
}
