using Gherkin.CucumberMessages.Types;
using NUnit.Framework;

namespace SpecFlowTestProject.Steps;

[Binding]
public class FirstStepDefinition
{




    [When("страница логина открыта")]
    public void OpenLoginPage()
    {
        Console.WriteLine();
    }


    [Then(@"username field is displayed")]
    public void IsUsernameDisplayed()
    {
        ScenarioContext.StepIsPending();
        Assert.That(true);
    }

    [Given(@"открыт браузер")]
    public void GivenОткрытБраузер()
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"страница логина открыта")]
    public void GivenСтраницаЛогинаОткрыта()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"user ""(.*)"" with password ""(.*)"" loggen in")]
    public void WhenUserWithPasswordLoggenIn(string p0, string p1)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"the add project button is displayed")]
    public void ThenTheAddProjectButtonIsDisplayed()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"username is ""(.*)""")]
    public void ThenUsernameIs(string p0)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"a project ID is (.*)")]
    public void ThenAProjectIdIs(int p0)
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"a blog post named ""(.*)"" with Markdown body")]
    public void GivenABlogPostNamedWithMarkdownBody(string random, string multilineText)
    {
        ScenarioContext.StepIsPending();
        Console.WriteLine($"Blog has name ");
    }
}