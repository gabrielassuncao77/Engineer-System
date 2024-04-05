using ConsoleApp1;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Enginnier
{
    public class Data
    {
        private List<Engineer> RegisterArray;
        public List<Project> Projects { get; set; }
        public List<Engineer> Responsables { get; set; }

        public Data()
        {
            RegisterArray = new List<Engineer>();
            Projects = new List<Project>();
            Responsables = new List<Engineer>();
        }

        public void InsertEngineer(Engineer x)
        {
            RegisterArray.Add(x);
        }

        public List<Engineer> ListEngineers()
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
            RegisterArray.Sort((x, y) => x.Name.CompareTo(y.Name));
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
            if (idEngineer != null && idProject != null)
            {
                Responsables.Add(idEngineer);
            }
        }

        public List<Engineer> listResponsabilities(string idEngineer, Data data) 
        {
            return null;
        }

        public class OrderingProcess : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Engineer)x).Name.CompareTo(((Engineer)y).Name);
            }
        }
    }
}
