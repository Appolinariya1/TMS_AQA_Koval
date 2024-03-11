using CoreProject.Core;
using CoreProject.Steps;

namespace AdvancedSpecFlowProject.Steps;
[Binding]
public class NavigationGuiStepDefs : BaseGuiSteps
{
    private NavigationSteps _navigationSteps;
    public NavigationGuiStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _navigationSteps = new NavigationSteps(Driver);
    }

    [Given(@"open the login page")]
    public void NavigateToLoginPage()
    {
        _navigationSteps.NavigateToLoginPage();
    }
}