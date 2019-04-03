﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumProjectTracking.Sprints.SprintTaskList;
using ScrumProjectTracking.DataAccess;
using System.Collections.Generic;
namespace ScrumProjectTrackingTest.Sprints.SprintTaskList
{
    [TestClass]
    public class SprintTaskListUnitTests
    {
        [TestMethod]
        public void getResultsCountTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks.Count == 1, "Sprint task list count does not equal expected value");
        }

        [TestMethod]
        public void getResultsCountTest2()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 2", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 2, ProjectID = 1, TaskName = "Test Task 3", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });

            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks.Count == 2, "Sprint task list count does not equal expected value");
        }

        [TestMethod]
        public void getResultsTaskNameTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 2", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 2, ProjectID = 1, TaskName = "Test Task 3", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });

            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].TaskName == "Test Task 1", "Sprint task list task name does not equal expected value");
        }

        [TestMethod]
        public void getResultsProjectNameTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
  
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].ProjectName == "Project 1", "Sprint task list project name does not equal expected value");
        }


        [TestMethod]
        public void getResultsSprintNameTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].SprintName == "Sprint 1", "Sprint task list sprint name does not equal expected value");
        }

        [TestMethod]
        public void getResultsSprintTaskIDTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].SprintTaskID == 1, "Sprint task list sprint task ID does not equal expected value");
        }

        [TestMethod]
        public void getResultsSprintTaskStatusTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].TaskStatus == "Pending", "Sprint task list task status does not equal expected value");
        }


        [TestMethod]
        public void getResultsSprintTeamNameTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1 });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].TeamName == "Team 1", "Sprint task list team name does not equal expected value");
        }


        [TestMethod]
        public void getResultsSprintAssignedToNameTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1, LastName = "Doe", FirstName = "John" });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].AssignedToName == "Doe, John", "Sprint task list assigned to name does not equal expected value");
        }

        [TestMethod]
        public void getResultsSprintAssignedToUserIDTest1()
        {
            SprintTaskListTestAccess sprintTaskList = new SprintTaskListTestAccess();
            sprintTaskList.DBSource.projects.Add(new Project { ProjectID = 1, ProjectName = "Project 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 1, SprintName = "Sprint 1" });
            sprintTaskList.DBSource.sprints.Add(new Sprint { SprintID = 2, SprintName = "Sprint 2" });
            sprintTaskList.DBSource.teams.Add(new Team { TeamID = 1, TeamName = "Team 1" });
            sprintTaskList.DBSource.users.Add(new User { UserID = "TEST", TeamID = 1, LastName = "Doe", FirstName = "John" });
            sprintTaskList.DBSource.sprintTasks.Add(new SprintTask { SprintID = 1, ProjectID = 1, TaskName = "Test Task 1", TeamID = 1, AssignedUserID = "TEST", TaskStatus = "Pending", Description = "Test Task Description", StoryPoints = 1, SprintTaskID = 1, TaskSubStatus = "Gathering requirements" });
            List<SprintTaskListItem> sprintTasks = new List<SprintTaskListItem>();
            sprintTasks = sprintTaskList.getResults(null, 1, 0, 0, null, new List<string> { "Pending" });
            Assert.IsTrue(sprintTasks[0].AssignedToUserID == "TEST", "Sprint task list assigned to user ID does not equal expected value");
        }
    }
}