using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTracker.Model;

namespace IssueTracker.Repository
{
    public class ProjectFlatFileRepository : IProjectRepository
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
            throw new NotImplementedException();
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
}
