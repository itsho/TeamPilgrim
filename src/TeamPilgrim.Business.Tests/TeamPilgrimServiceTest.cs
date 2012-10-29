﻿using System.Linq;
using JustAProgrammer.TeamPilgrim.VisualStudio.Business.Services;
using JustAProgrammer.TeamPilgrim.VisualStudio.Domain.Entities;
using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using NUnit.Framework;

namespace JustAProgrammer.TeamPilgrim.Business.Tests
{
    [TestFixture]
    public class TeamPilgrimServiceTest
    {
        private TeamPilgrimTfsService _teamPilgrimTfsService;

        [SetUp]
        public void Initialize()
        {
            _teamPilgrimTfsService = new TeamPilgrimTfsService();
        }

        [Test]
        public void ManualTest()
        {
            var pilgrimProjectCollections = _teamPilgrimTfsService.GetProjectCollections();
            var pilgrimProjectCollection = pilgrimProjectCollections.First();

            var teamPilgrimBuildService = _teamPilgrimTfsService.GetTeamPilgrimBuildService(pilgrimProjectCollection.Uri);

            var pilgrimProjects = _teamPilgrimTfsService.GetProjects(pilgrimProjectCollection.Uri);
            Project pilgrimProject = pilgrimProjects.First();

            BuildDefinitionWrapper[] buildDefinitions = teamPilgrimBuildService.QueryBuildDefinitions(pilgrimProject.Name);
        }
    }
}