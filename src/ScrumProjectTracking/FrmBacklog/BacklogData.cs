﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScrumProjectTracking.DataAccess;

namespace ScrumProjectTracking.FrmBacklog
{
    public class BacklogData
    {
        ScrumDBSource data = new ScrumDBSource();
        ScrumContext dataManipulation = new ScrumContext();
        
        public List<Team> teamData()
        {
            return (data.Teams).ToList();
        }
        public List<Project> projectData()
        {
            return (data.Projects).ToList();
        }
        public List<User> userData()
        {
            return (data.Users).ToList();
        }
        public List<Backlog> backlogData()
        {
            return (data.Backlogs).ToList();
        }
        public void newBacklogRow(int PrID, int TID, string PrName, string Story, int StrPoints, int Prior, string AddB, DateTime AddDT)
        {
            var dataObject = new Backlog()
            {
                
                ProjectID = PrID,
                TeamID = TID,
                ProjectName = PrName,
                UserStory = Story,
                StoryPoints = StrPoints,
                Priority = Prior,
                AddedBy = AddB,
                AddedDateTime = AddDT

            };

            dataManipulation.Add(dataObject);
            dataManipulation.SaveChanges();
        }

        public void editBacklogRow(int PrID, int TID, string PrName, string Story, int StrPoints, int Prior, string UpdB, DateTime UpdT, Backlog b)
        {
            dataManipulation.Attach(b);

            b.ProjectID = PrID;
            b.TeamID = TID;
            b.ProjectName = PrName;
            b.UserStory = Story;
            b.StoryPoints = StrPoints;
            b.Priority = Prior;
            b.UpdatedBy = UpdB;
            b.UpdatedDateTime = UpdT;

            dataManipulation.SaveChanges();
        }

        public void deleteRow()
        {
        }
    }
}
