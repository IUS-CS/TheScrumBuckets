﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataAccess
{
   public class ScrumTestSource : IDataAccess, IDisposable

    {


        public List<Team> teams { get; } = new List<Team>();
        public List<Sprint> sprints { get; } = new List<Sprint>();
        public List<Project> projects { get; } = new List<Project>();
        public List<SprintTask> sprintTasks { get; } = new List<SprintTask>();
        public List<User> users { get; } = new List<User>();
        public List<Backlog> backlogs { get; } = new List<Backlog>();


        

        public IEnumerable<Team> Teams => teams;

        public IEnumerable<Sprint> Sprints => sprints;

        public IEnumerable<SprintTask> SprintTasks => sprintTasks;

        public IEnumerable<Project> Projects => projects;

        public IEnumerable<User> Users => users;

        public IEnumerable<Backlog> Backlogs => Backlogs;
        public void Dispose()
        {
            

        }
    }
}
