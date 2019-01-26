using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using UITestTodoApp.Pages;
using Xamarin.UITest;

namespace UITestTodoApp.TestSuite.StepsDefinition
{
    [TestFixture(Platform.Android)]
    [Binding]
    public class TodoTestSteps
    {
        TaskListPage taskListPage;
        TaskFormPage taskFormPage;

        
        Platform platform;

        [Given(@"I launch Todo APP")]
        public void GivenILaunchTodoAPP()
        {
            AppInitializer.StartApp(platform);
            this.taskListPage = new TaskListPage();
            this.taskFormPage = new TaskFormPage();
        }

        [Given(@"I tap \+ button")]
        public void GivenITapButton()
        {
            this.taskListPage.TapAddButton();
        }

        [When(@"I enter a new task called ""(.*)""")]
        public void WhenIAddANewTaskCalled(string TaskName)
        {
            ScenarioContext.Current["TaskName"] = TaskName;
            this.taskFormPage.EnterTaskName(TaskName);
            //this.app.EnterText(c => c.Class("FormsEditText").Index(0), TaskName);
        }

        [When(@"I enter a note for the new task ""(.*)""")]
        public void WhenIEnterANoteForTheNewTask(string TaskNote)
        {
            //this.app.EnterText(c => c.Class("FormsEditText").Index(1), TaskNote);
            this.taskFormPage.EnterNotesTask(TaskNote);
        }

        [When(@"I save the task")]
        public void WhenISaveTheTask()
        {
            //this.app.DismissKeyboard();
            //this.app.Tap(c => c.Class("AppCompatButton").Text("Save"));
            this.taskFormPage.SaveTask();
        }

        //[Then(@"I should see the task in the list page")]
        //public void ThenIShouldSeeTheTaskInTheListPage()
        //{
        //    var TaskName = ScenarioContext.Current["TaskName"];
        //    this.app.WaitForElement(c => c.Marked(TaskName.ToString()));
        //    string a = this.app.Query(c => c.Class("FormsTextView")).First().Text;
        //    Assert.IsTrue(a.Equals(TaskName));
        //}

        //[Then(@"I should see an image next to task name")]
        //public void ThenIShouldSeeAnImageNextToTaskName()
        //{
        //    app.WaitForElement(c => c.Class("FormsImageView"));
        //}



        //[When(@"I select the task ""(.*)"" on task list page")]
        //public void GivenISelectTheTaskOnTaskListPage(string taskList)
        //{
        //    this.app.Tap(c => c.Class("FormsTextView").Text(taskList));
        //}

        //[When(@"I edit task name to be ""(.*)""")]
        //public void WhenIEditTaskNameToBe(string TaskNameModify)
        //{
        //    ScenarioContext.Current["TaskName"] = TaskNameModify;
        //    this.app.ClearText(c => c.Class("FormsEditText").Index(0));
        //    this.app.EnterText(c => c.Class("FormsEditText").Index(0), TaskNameModify);
        //}

        //[When(@"I edit task note to be ""(.*)""")]
        //public void WhenIEditTaskNoteToBe(string TaskNoteModify)
        //{
        //    this.app.ClearText(c => c.Class("FormsEditText").Index(1));
        //    this.app.EnterText(c => c.Class("FormsEditText").Index(1), TaskNoteModify);
        //}

        //[When(@"I set task as Done")]
        //public void WhenISetTaskAsDone()
        //{
        //    this.app.TouchAndHold(c => c.Class("SwitchCompat"));
        //}



        //[When(@"I delete the task selected")]
        //public void WhenIDeleteTheTaskSelected()
        //{
        //    app.Tap(c => c.Class("AppCompatButton").Text("Delete"));
        //}

        //[Then(@"I should not see the ""(.*)"" task on task list page")]
        //public void ThenIShouldNotSeeTheTaskOnTaskListPage(string TaskName)
        //{
        //    app.WaitForNoElement(c => c.Marked(TaskName));
        //}

    }
}
