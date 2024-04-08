using System.Diagnostics;
using NLog;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Tests;

public class ProjectTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project = null;

    [Test]
    [Order(1)]
    public void AddProjectTest()
    {
        _project = new Project
        {
            Name = "Meow",
            Announcement = "Ks-ks",
            ShowAnnouncement = true,
            SuiteMode = 1
        };

        var actualProject = ProjectService!.AddProject(_project);

        //блок проверок
        Assert.Multiple(() =>
        {
            Assert.That(actualProject.Result.Name, Is.EqualTo(_project.Name));
            Assert.That(actualProject.Result.Announcement, Is.EqualTo(_project.Announcement));
            Assert.That(actualProject.Result.SuiteMode, Is.EqualTo(_project.SuiteMode));
        });
        _project = actualProject.Result;
        _logger.Info(_project.ToString);
    }
}