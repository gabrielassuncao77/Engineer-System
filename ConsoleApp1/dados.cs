using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using ConsoleApp1;

namespace Enginnier
{
    public class Data
    {
        private ArrayList RegisterArray;
        public List<Project> Projects { get; set; }
        public List<ProjectEngineer> Responsables { get; set; }

        public Data()
        {
            RegisterArray = new ArrayList();
            Projects = new List<Project>();
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
            int Position;

            Position = RegisterArray.IndexOf(x);

            RegisterArray.Remove(x);

            RegisterArray.Insert(Position, y);
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
        public Project SearchProject(string ID) 
        {
            foreach (Project y in Projects) 
            {
                if (y.ProjectID.ToUpper() == ID.ToUpper()) 
                {
                    return y;
                }
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

        public void InsertProject(Project project)
        {
            Projects.Add(project);
        }

        public void RemoveProject(Project project)
        {
            Projects.Remove(project);
        }

        public List<Project> ListProjects()
        {
            return Projects;
        }
        
        public void addResponsability(Engineer idEngineer, Project idProject) 
        {
            if(idEngineer !=null && idProject != null) 
            {
                Responsables.Add(idEngineer);
            }
        }
        
        public class OrderingProcess : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Engineer)x).Name.CompareTo(((Engineer)y).Name);
            }
        }

        public int SaveXML()
        {
            TextWriter Writer = new StreamWriter(@"E:\xLixo\CadastroAlunos.xml");
            Engineer[] EngineerArray = (Engineer[])RegisterArray.ToArray(typeof(Engineer));
            XmlSerializer Serialization = new XmlSerializer(EngineerArray.GetType());

            Serialization.Serialize(Writer, EngineerArray);

            Writer.Close();

            return RegisterArray.Count;
        }

        public int ReadXML()
        {
            FileStream XML = new FileStream(@"E:\xLixo\CadastroAlunos.xml", FileMode.Open);
            Engineer[] EngineerList = (Engineer[])RegisterArray.ToArray(typeof(Engineer));
            XmlSerializer Serialization = new XmlSerializer(EngineerList.GetType());

            EngineerList = (Engineer[])Serialization.Deserialize(XML);

            RegisterArray.Clear();

            RegisterArray.AddRange(EngineerList);

            XML.Close();

            return RegisterArray.Count;
        }
    }
}
