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
        public void Insert(Engineer x, Dados EngineerData)
        {
            x.readEnginnerData();

            EngineerData.InsertEngineer(x);
        }
        public void insertProject(EnginnerProject X, Dados MeusDados) 
        {
            X.readProject();
            MeusDados.InsertProject(X);
        }
        public void List(Dados EngineerData)
        {
            ArrayList Lista;

            Lista = EngineerData.ListEngineers();

            foreach (Engineer x in Lista)
            {
                x.showEnginnerData();
            }
            Console.ReadKey();
        }
        public void ListProject(Dados EngineerData) 
        {
            ArrayList Lista;

            Lista = EngineerData.ListProjects();
            foreach(EnginnerProject x in Lista) 
            {
                x.showProject();
            }
            Console.ReadKey();
        }
        public void Alter(string SearchID, Engineer EnginnerSearched, Engineer EnginnerChanged, Dados EngineerData)
        {
            EnginnerSearched = EngineerData.SearchEngineer(SearchID);

            if (EnginnerSearched != null)
            {
                EnginnerSearched.showEnginnerData();

                Console.WriteLine("Dados de Atualização: \n");

                EnginnerChanged.readEnginnerData(false);

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

        public void Remove(string SearchID, Engineer X, Dados data)
        {
            X = data.SearchEngineer(SearchID);

            if (X != null)
            {
                X.showEnginnerData();

                data.RemoveEngineer(X);

                Console.WriteLine("Engenheiro Excluído do Cadastro...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\Engenheiro não encontrado...");
            }
        }

        public void Search(string ID, Engineer X, Dados EngineerData)
        {
            X = EngineerData.SearchEngineer(ID);

            if (X != null)
            {
                X.showEnginnerData();
            }
            else
            {
                Console.Write("\nEngenheiro não encontrado...");
            }

            Console.ReadKey();
        }

        public void Order(Dados EnginnerData)
        {
            int Registers;

            Registers = EnginnerData.OrderingEngineer();

            Console.Write($"Total de Registros: {Registers}");

            Console.ReadKey();
        }

        public void SaveXML(Dados EngineerData)
        {
            int TotReg;

            TotReg = EngineerData.SaveXML();

            Console.WriteLine("Arquivo XML criado com sucesso...");

            Console.Write($"Total de Registros: {TotReg}");

            Console.ReadKey();
        }

        public void ReadXML(Dados EngineerData)
        {
            int TotReg;

            TotReg = EngineerData.ReadXML();

            Console.WriteLine("Arquivo XML carregado com sucesso...");

            Console.Write($"Total de Registros: {TotReg}");

            Console.ReadKey();
        }


    }
}