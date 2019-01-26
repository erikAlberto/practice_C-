using System;
using System.Linq;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using NUnit.Framework;

namespace ClassLibrary2.steps
{
    [Binding]
    public class ManageTasksSteps
    {
        readonly IApp app;

        [Given(@"I am on task list page")]
            public void GivenIAmOnTaskListPage()
        {
            app.WaitForElement("+");
            app.Tap(c => c.Marked("+"));
        }

        [When(@"I add a new task called ""(.*)""")]
        public void WhenIAddANewTaskCalled(string TaskName)
        {
            app.EnterText(c => c.Class("FormsEditText").Index(0), TaskName);
        }

        [When(@"I add a note ""(.*)"" for the new task")]
        public void WhenIAddANoteForTheNewTask(string TaskNote)
        {
            app.EnterText(c => c.Class("FormsEditText").Index(1), TaskNote);
        }

        [When(@"I save the task")]
        public void WhenISaveTheTask()
        {
            app.Tap(c => c.Class("AppCompatButton").Text("Save"));
        }

        [Then(@"I should see the ""(.*)"" task in the list page")]
        public void ThenIShouldSeeTheTaskInTheListPage(string p0)
        {
            string a = app.Query(c => c.Class("FormsTextView")).First().Text;
            Assert.IsTrue(a.Equals(p0));
        }
    }
}
