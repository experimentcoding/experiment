using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTracker.Model;
using System.Data.Entity;

namespace IssueTracker.Repository
{

    public class ProjectRepository : IProjectRepository
    {
        public IQueryable<Project> Table
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryable<Project> TableUntracked
        {
            get { throw new NotImplementedException(); }
        }

        public Project Create()
        {
            throw new NotImplementedException();
        }

        public Project GetById(int id)
        {
            MainContext c = new MainContext();
            var p = c.Projects.Find(id);
            return p;
        }

        public void Insert(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public interface IProjectRepository : IRepository<Project>
    {
    }


}
