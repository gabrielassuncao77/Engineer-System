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
    class Operacoes
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
            ArrayList List;

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

                Console.WriteLine("Dados de Atualização: \n");

                EnginnerChanged.ReadEngineerData(false);

                EnginnerChanged.ID = EnginnerSearched.ID;

                EngineerData.AlterEngineer(EnginnerSearched, EnginnerChanged);

                Console.Write("\nDados Atualizados...");

                Console.ReadKey();
            }
            else
            {
                Console.Write("\nEngenheiro não encontrado...");
            }
        }

        public void Remove(string SearchID, Engineer X, Data data)
        {
            X = data.SearchEngineer(SearchID);

            if (X != null)
            {
                X.ShowEngineerData();

                data.RemoveEngineer(X);

                Console.WriteLine("Engenheiro Excluído do Cadastro...");
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

            if (X!=null && Y!=null) 
            {
                
            }
        }

        public void Order(Data EnginnerData)
        {
            int Registers;

            Registers = EnginnerData.OrderingEngineer();

            Console.Write($"Total de Registros: {Registers}");

            Console.ReadKey();
        }

        public void SaveXML(Data EngineerData)
        {
            int TotReg;

            TotReg = EngineerData.SaveXML();

            Console.WriteLine("Arquivo XML criado com sucesso...");

            Console.Write($"Total de Registros: {TotReg}");

            Console.ReadKey();
        }

        public void ReadXML(Data EngineerData)
        {
            int TotReg;

            TotReg = EngineerData.ReadXML();

            Console.WriteLine("Arquivo XML carregado com sucesso...");

            Console.Write($"Total de Registros: {TotReg}");

            Console.ReadKey();
        }


    }
}