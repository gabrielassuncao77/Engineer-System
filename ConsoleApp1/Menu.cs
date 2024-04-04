
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
        private string SearchID;

        private Operacoes Op;
        private Data Data;

        public Menu(Operacoes O, Data D)
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

                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Pesquisar");
                Console.WriteLine("5 - Listar");
                Console.WriteLine("6 - Ordenar");
                Console.WriteLine("7 - Salvar em XML");
                Console.WriteLine("8 - Carregar de XML");
                Console.WriteLine("9 - Sair");
                Console.WriteLine("10 - Insert Project");
                Console.WriteLine("11 - List Project");
                Console.WriteLine("12 - Associate Project");

                Console.Write("\nOpção: ");
                Opção = int.Parse(Console.ReadLine());

                switch (Opção)
                {
                    case 1:
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("Cadastro de Aluno");
                            Console.WriteLine("=================\n");

                            Op.Insert(new Engineer(), Data);

                            Console.WriteLine("\nInserir outro Registro? (ESC Cancela...)");

                        } while (Console.ReadKey().Key != ConsoleKey.Escape);

                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Alteração de Dados de Aluno");
                        Console.WriteLine("===========================\n");

                        Console.Write("Código.......: ");
                        SearchID = Console.ReadLine();
                        Op.Alter(SearchID, new Engineer(), new Engineer(), Data);

                        break;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("Exclusão de Aluno do Cadastro");
                        Console.WriteLine("=============================\n");

                        Console.Write("Código.....: ");
                        SearchID = Console.ReadLine();

                        Op.Remove(SearchID, new Engineer(), Data);

                        break;
                    case 4:
                        Console.Clear();

                        Console.WriteLine("Pesquisa de Aluno no Cadastro");
                        Console.WriteLine("=============================\n");

                        Console.Write("Código do Aluno: ");
                        SearchID = Console.ReadLine();

                        Op.EngineerSearcher(SearchID, new Engineer(), Data);

                        break;
                    case 5:
                        Console.Clear();

                        Console.WriteLine("Listagem de Alunos");
                        Console.WriteLine("==================\n");

                        Op.List(Data);

                        break;
                    case 6:
                        Console.Clear();

                        Console.WriteLine("Ordenação de Registros do Cadastro");
                        Console.WriteLine("==================================\n");

                        Op.Order(Data);

                        break;
                    case 7:
                        Console.Clear();

                        Console.WriteLine("Salvar Dados em Arquivo XML");
                        Console.WriteLine("===========================\n");

                        Op.SaveXML(Data);

                        break;
                    case 8:
                        Console.Clear();

                        Console.WriteLine("Ler Dados de Arquivo XML");
                        Console.WriteLine("===========================\n");

                        Op.SaveXML(Data);

                        break;
                    case 9:
                        Console.Write("\nSaída do sistema...");
                        Thread.Sleep(3000);
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Project register... ");
                        Op.insertProject(new Project(), Data);
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("Listing projects...");
                        Op.ListProject(Data);
                        break;
                    case 12:
                        Console.Clear();
                        Console.WriteLine("Searching projects...");
                        Console.Write("Código do Aluno: ");
                        SearchID = Console.ReadLine();
                        Op.ProjectSearcher(SearchID, new Project(), Data);
                        break;

                }
            } while (Opção != 9);
        }
    }
}
