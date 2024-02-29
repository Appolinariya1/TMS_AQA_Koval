using BuilderPattern.Models;
using BuilderPattern.Pages.ProjectPages;
using OpenQA.Selenium;
using ValueOfObjects.Models;

namespace BuilderPattern.Steps;

public class ProjectSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(Driver, true);

        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        if (project.IsShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();

        AddProjectPage.AddButton.Click();

        return new ProjectsPage(Driver);
    }
}