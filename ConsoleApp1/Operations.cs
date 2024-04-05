using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using ConsoleApp1;

namespace Enginnier
{
    class Operations
    {
        public void Insert(Engineer x, Data EngineerData)
        {
            x.ReadEngineerData();

            EngineerData.InsertEngineer(x);
        }
        public void insertProject(Project X, Data EngineerData) 
        {
            X.readProject();

            EngineerData.InsertProject(X);
        }
        public void List(Data EngineerData)
        {
            List<Engineer> List;

            List = EngineerData.ListEngineers();

            foreach (Engineer x in List)
            {
                x.ShowEngineerData();
            }
            Console.ReadKey();
        }
        public void ListProject(Data Project)
        {
            List<Project> List;

            List = Project.ListProjects();
            foreach (Project x in List)
            {
                x.showProject();
            }
            Console.ReadKey();
        }

    
        public void Alter(string SearchID, Engineer EnginnerSearched, Engineer EnginnerChanged, Data EngineerData)
        {
            EnginnerSearched = EngineerData.SearchEngineer(SearchID);

            if (EnginnerSearched != null)
            {
                EnginnerSearched.ShowEngineerData();

                Console.WriteLine("Data to be updated:  \n");

                EnginnerChanged.ReadEngineerData(false);

                EnginnerChanged.ID = EnginnerSearched.ID;

                EngineerData.AlterEngineer(EnginnerSearched, EnginnerChanged);

                Console.Write("\nData updated");

                Console.ReadKey();
            }
            else
            {
                Console.Write("\nEngineer not found");
            }
        }

        public void Remove(string SearchID, Engineer X, Data data)
        {
            X = data.SearchEngineer(SearchID);

            if (X != null)
            {
                X.ShowEngineerData();

                data.RemoveEngineer(X);

                Console.WriteLine("Engineer removed...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\nEngineer not found");
            }
        }

        public void EngineerSearcher(string ID, Engineer X, Data EngineerData)
        {
            X = EngineerData.SearchEngineer(ID);

            if (X != null)
            {
                X.ShowEngineerData();
            }
            else
            {
                Console.Write("\nEngineer not found");
            }

            Console.ReadKey();
        }

        public void ProjectSearcher(string ID, Project Y, Data ProjectData) 
        {
            Y = ProjectData.SearchProject(ID);

            if (Y != null)
            {
                Y.showProject();
            }
            else 
            {
                Console.Write("\nProject not found...");
            }
            Console.ReadKey();
        }
        
        public void AddEngineerToProject(string IdEngineer, string IdProject, Data data, Engineer X, Project Y) 
        {
            Y = data.SearchProject(IdProject);
            X = data.SearchEngineer(IdEngineer);

            if (X!=null || Y!=null) 
            {
                data.addResponsability(X, Y);
                Console.WriteLine($"Project {Y.projectName} added to enginner {X.Name}");
            }
            else
            {
                Console.WriteLine("Something went wrong..");
            }
            Console.ReadKey();
        }

        public void ListEngineerByProject()
        {
            
        }

        public void Order(Data EnginnerData)
        {
            int Registers;

            Registers = EnginnerData.OrderingEngineer();

            Console.Write($"Total registers: {Registers}");

            Console.ReadKey();
        }


    }
}