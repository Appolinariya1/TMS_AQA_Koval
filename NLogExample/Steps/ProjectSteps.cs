using NLogExample.Models;
using NLogExample.Pages.ProjectPages;
using OpenQA.Selenium;

namespace NLogExample.Steps;

public class ProjectSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(Driver, true);
        
        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
        AddProjectPage.AddButton.Click();
        
        return new ProjectsPage(Driver);
    }
}