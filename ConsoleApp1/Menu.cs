
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ConsoleApp1;

namespace Enginnier
{ 
    class Menu
    {
        private string SearchIDengineer;
        private string SearchIDproject;

        private Operations Op;
        private Data Data;

        public Menu(Operations O, Data D)
        {
            Op = O;
            Data = D;
        }
        public void MostraMenu()
        {
            int Opção;

            do
            {
                Console.Clear();

                Console.WriteLine("Sistema de Cadastro de Alunos");
                Console.WriteLine("=============================\n");

                Console.WriteLine("1 - Insert Engineer");
                Console.WriteLine("2 - Alter Engineer");
                Console.WriteLine("3 - Remove Engineer");
                Console.WriteLine("4 - Search by ID");
                Console.WriteLine("5 - List");
                Console.WriteLine("6 - Order");
                Console.WriteLine("7 - Salve in XML");
                Console.WriteLine("8 - load by XML");
                Console.WriteLine("9 - Insert Project");
                Console.WriteLine("10 - List Project");
                Console.WriteLine("11 - Search Project");
                Console.WriteLine("12 - Associate Project to engineer");
                Console.WriteLine("13- Exit");


                Console.Write("\nOpção: ");
                Opção = int.Parse(Console.ReadLine());

                switch (Opção)
                {
                    case 1:
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("Registering engineers..");
                            Console.WriteLine("=================\n");

                            Op.Insert(new Engineer(), Data);

                            Console.WriteLine("\nWanna regist another data? (PRESS ESC TO CANCEL...)");

                        } while (Console.ReadKey().Key != ConsoleKey.Escape);

                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Altering engineer registers...");
                        Console.WriteLine("===========================\n");

                        Console.Write("Engineer ID...: ");
                        SearchIDengineer = Console.ReadLine();
                        Op.Alter(SearchIDengineer, new Engineer(), new Engineer(), Data);

                        break;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("Remove engineer....");
                        Console.WriteLine("=============================\n");

                        Console.Write("Engineer ID: ");
                        SearchIDengineer = Console.ReadLine();

                        Op.Remove(SearchIDengineer, new Engineer(), Data);

                        break;
                    case 4:
                        Console.Clear();

                        Console.WriteLine("Search engineers...");
                        Console.WriteLine("=============================\n");

                        Console.Write("Engineer ID: ");
                        SearchIDengineer = Console.ReadLine();

                        Op.EngineerSearcher(SearchIDengineer, new Engineer(), Data);

                        break;
                    case 5:
                        Console.Clear();

                        Console.WriteLine("List engineers...");
                        Console.WriteLine("===========================\n");
                        Console.WriteLine();
                        Op.List(Data);

                        break;
                    case 6:
                        Console.Clear();

                        Console.WriteLine("Ordering engineers registers...");
                        Console.WriteLine("===========================\n");
                        Console.WriteLine();

                        Op.Order(Data);

                        break;
                    case 7:
                        Console.Clear();

                        Console.WriteLine("Save data in XML...");
                        Console.WriteLine("===========================\n");
                        break;
                    case 8:
                        Console.Clear();

                        Console.WriteLine("Read XML file...");
                        Console.WriteLine("===========================\n");
                        break;

                    case 9:
                        Console.Clear();
                        Console.WriteLine("Project register... ");
                        Console.WriteLine("===========================\n");

                        Op.insertProject(new Project(), Data);

                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Listing projects...");
                        Console.WriteLine("===========================\n");
                        Console.WriteLine();
                        Op.ListProject(Data);

                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("Searching projects...");
                        Console.WriteLine("===========================\n");
                        Console.WriteLine();
                        Console.Write("Project searched: ");
                        Console.WriteLine();
                        SearchIDproject = Console.ReadLine();
                        Op.ProjectSearcher(SearchIDproject, new Project(), Data);
                        break;
                    case 12:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Responsabilit");
                            Console.WriteLine("===========================\n");
                            Console.WriteLine();
                            Console.WriteLine("Engineer ID: ");
                            SearchIDengineer = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Project ID:");
                            SearchIDproject = Console.ReadLine();

                            Op.AddEngineerToProject(SearchIDengineer, SearchIDproject, Data, new Engineer(), new Project());
                            Console.WriteLine("\nWanna regist another data? (PRESS ESC TO CANCEL...)");
                        } while (Console.ReadKey().Key != ConsoleKey.Escape);
                        break;

                    case 13:
                        Console.Write("\nSaída do sistema...");
                        Thread.Sleep(3000);
                        break;

                }
            } while (Opção != 13);
        }
    }
}
