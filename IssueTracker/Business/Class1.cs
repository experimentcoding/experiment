using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTracker.Model;
using IssueTracker.Repository;

namespace IssueTracker.Business
{
    public class Projects 
    {
        private IProjectRepository _repo;


        public Projects()
        {
            _repo = new ProjectRepository();
        }

        public Projects(IProjectRepository repProject)
        {
            _repo = repProject;
        }


        /// <summary>
        /// Project information for a given project id
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public Project GetById(int ProjectId)
        {
            return _repo.GetById(ProjectId);
        }


        //public int SaveProjectAndMember()
        //{

        //}
        
    }
}
