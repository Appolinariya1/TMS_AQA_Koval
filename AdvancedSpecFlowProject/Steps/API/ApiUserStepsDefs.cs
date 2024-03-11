namespace AdvancedSpecFlowProject.Steps.API;

[Binding]
public class ApiUserStepsDefs : BaseApiSteps
{
    [Given(@"sent request with correct data")]
    public void GivenSentRequestWithCorrectData()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"response status code is (.*)")]
    public void ThenResponseStatusCodeIs(int p0)
    {
        ScenarioContext.StepIsPending();
    }
}