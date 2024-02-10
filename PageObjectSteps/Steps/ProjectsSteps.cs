using OpenQA.Selenium;
using SeleniumBasic.Pages;

namespace SeleniumBasic.Steps;

public class ProjectsSteps : BaseSteps
{
    public ProjectsSteps(IWebDriver driver) : base(driver)
    {
        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        DashboardPage dashboardPage = new DashboardPage(Driver);
    }

    public void CreateProject()
    {
        
    }

    public void UpdateProject()
    {
        
    }

    public void ReadProject()
    {
        
    }

    public void DeleteProject()
    {
        
    }
}