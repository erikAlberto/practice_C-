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


        [Given(@"I tap add tasks \(\+\) button")]
        public void GivenITapAddTasksButton()
        {
            this.taskListPage.TapAddButton();
        }

        [StepDefinition(@"I enter a new task called ""(.*)""")]
        public void WhenIAddANewTaskCalled(string TaskName)
        {
            ScenarioContext.Current["TaskName"] = TaskName;
            this.taskFormPage.EnterTaskName(TaskName);
        }

        [StepDefinition(@"I enter a note for the new task ""(.*)""")]
        public void WhenIEnterANoteForTheNewTask(string TaskNote)
        {
            this.taskFormPage.EnterNotesTask(TaskNote);
        }

        [StepDefinition(@"I save the task")]
        public void WhenISaveTheTask()
        {
            this.taskFormPage.SaveTask();
        }

        [Then(@"Verify if the following task is displayed in the list: (.*)")]
        public void ThenVerifyIfTheFollowingTaskIsDisplayedInTheListLearnC(string expectedTaskName)
        {
            this.taskListPage.VerifyIfExpectedTaskIsPresent(expectedTaskName);
        }


        [StepDefinition(@"I select the task ""(.*)"" on task list page")]
        public void GivenISelectTheTaskOnTaskListPage(string taskList)
        {
            this.taskListPage.SelectTask(taskList);
        }

        [StepDefinition(@"I edit task name to be ""(.*)""")]
        public void WhenIEditTaskNameToBe(string TaskNameModify)
        {
            taskFormPage.EnterTaskName(TaskNameModify);
        }

        [StepDefinition(@"I edit task note to be ""(.*)""")]
        public void WhenIEditTaskNoteToBe(string TaskNoteModify)
        {
            taskFormPage.EnterNotesTask(TaskNoteModify);
        }

        [StepDefinition(@"I set task as Done")]
        public void WhenISetTaskAsDone()
        {
            taskFormPage.SetTaskAsDone();
        }
        

        [When(@"I delete the task selected")]
        public void WhenIDeleteTheTaskSelected()
        {
            taskFormPage.DeleteTask();
        }

        [Then(@"I should not see the ""(.*)"" task on task list page")]
        public void ThenIShouldNotSeeTheTaskOnTaskListPage(string TaskName)
        {
            taskListPage.VerifyTaskDelete(TaskName);
        }
    }
}
