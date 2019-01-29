using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestTodoApp.Controls;
using Xamarin.UITest;
namespace UITestTodoApp.Pages
{

    public class TaskListPage
    {
        IApp app;
        TaskListControl taskListControl;
        
        public TaskListPage()
        {
            this.taskListControl = new TaskListControl();
            app = AppInitializer.GetCurrentApp();
        }

        public void TapAddButton()
        {
            var plusButtonLambda = this.taskListControl.PlusButton;
            app.WaitForElement(plusButtonLambda);
            app.Tap(plusButtonLambda);
        }

        public void SelectTask(string taskList)
        {
            var taskListLambda = this.taskListControl.TaskList;
            app.WaitForElement(taskListLambda);
            app.Tap(taskListLambda);
        }

        internal void VerifyIfExpectedTaskIsPresent(string expectedTaskName)
        {
            var taskListLambda = this.taskListControl.TaskList;

            app.WaitForElement(taskListLambda,
                               "Did not see the task in the list page.",
                               new TimeSpan(0, 0, 0, 90, 0));

            string actualTaskName = app.Query(taskListLambda)[0].Text;
            Assert.IsTrue(actualTaskName.Equals(expectedTaskName));
        }

        public void VerifyTaskDone()
        {
            var taskDoneLambda = this.taskListControl.TaskDone;
            app.WaitForElement(taskDoneLambda);
        }

        public void VerifyTaskDelete(string espectedTaskName)
        {
            var taskDeleteLambda = this.taskListControl.TaskList;
            var actualTaskName = app.Query(taskDeleteLambda)[0].Text;
            var a = app.Query(taskDeleteLambda);
            Assert.IsFalse(actualTaskName.Equals(espectedTaskName));
        }
    }
}
