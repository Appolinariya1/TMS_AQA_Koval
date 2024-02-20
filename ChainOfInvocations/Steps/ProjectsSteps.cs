using ChainOfInvocations.Pages;
using ChainOfInvocations.Pages.ProjectPages;
using OpenQA.Selenium;

namespace ChainOfInvocations.Steps;

public class ProjectsSteps : BaseSteps
{
    public ProjectsSteps(IWebDriver driver) : base(driver)
    {
        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        DashboardPage dashboardPage = new DashboardPage(Driver);
    }

    public void AddProductToCart(List<string> Products)
    {
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