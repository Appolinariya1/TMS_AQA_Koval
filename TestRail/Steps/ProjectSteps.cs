using OpenQA.Selenium;
using TestRailComplexApi.Models;
using TestRailComplexApi.Pages.ProjectPages;

namespace TestRailComplexApi.Steps;

public class ProjectSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(Driver, true);

        AddProjectPage.NameInput.SendKeys(project.Name);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.SuiteMode);
        if (project.ShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();
        AddProjectPage.AddButton.Click();

        return new ProjectsPage(Driver);
    }
}