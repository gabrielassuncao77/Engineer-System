using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using ConsoleApp1;

namespace Enginnier
{
    class Dados
    {
        private ArrayList RegisterArray;
        public ArrayList EngineersProjects;

        public Dados()
        {
            RegisterArray = new ArrayList();
            EngineersProjects = new ArrayList(); // Inicializa a lista de projetos
        }

        public void InsertEngineer(Engineer x)
        {
            RegisterArray.Add(x);
        }

        public ArrayList ListEngineers()
        {
            return RegisterArray;
        }

        public void AlterEngineer(Engineer x, Engineer y)
        {
            int Posição;

            Posição = RegisterArray.IndexOf(x);

            RegisterArray.Remove(x);

            RegisterArray.Insert(Posição, y);
        }

        public Engineer SearchEngineer(string ID)
        {
            foreach (Engineer x in RegisterArray)
            {
                if (x.ID.ToUpper() == ID.ToUpper())
                    return x;
            }

            return null;
        }

        public void RemoveEngineer(Engineer x)
        {
            RegisterArray.Remove(x);
        }

        public int OrderingEngineer()
        {
            RegisterArray.Sort(new OrderingProcess());

            return RegisterArray.Count;
        }

        public void InsertProject(EnginnerProject project)
        {
            EngineersProjects.Add(project);
        }

        public void RemoveProject(EnginnerProject project)
        {
            EngineersProjects.Remove(project);
        }

        public ArrayList ListProjects()
        {
            return EngineersProjects;
        }

        public void AssociateProjectEngineer(Engineer engineer, EnginnerProject project)
        {
            project.addEnginner(engineer);
        }

        public class OrderingProcess : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Engineer)x).name.CompareTo(((Engineer)y).name);
            }
        }

        public int SaveXML()
        {
            TextWriter Writer = new StreamWriter(@"E:\xLixo\CadastroAlunos.xml");
            Engineer[] ListaAlunoVetor = (Engineer[])RegisterArray.ToArray(typeof(Engineer));
            XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

            Serialização.Serialize(Writer, ListaAlunoVetor);

            Writer.Close();

            return RegisterArray.Count;
        }

        public int ReadXML()
        {
            FileStream XML = new FileStream(@"E:\xLixo\CadastroAlunos.xml", FileMode.Open);
            Engineer[] EngineerList = (Engineer[])RegisterArray.ToArray(typeof(Engineer));
            XmlSerializer Serialização = new XmlSerializer(EngineerList.GetType());

            EngineerList = (Engineer[])Serialização.Deserialize(XML);

            RegisterArray.Clear();

            RegisterArray.AddRange(EngineerList);

            XML.Close();

            return RegisterArray.Count;
        }
    }
}
