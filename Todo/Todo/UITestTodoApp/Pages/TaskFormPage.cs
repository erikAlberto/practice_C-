using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestTodoApp.Controls;
using Xamarin.UITest;
//using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace UITestTodoApp.Pages
{
    class TaskFormPage
    {
        IApp app;

        TaskFormControl taskFormControl;

        public TaskFormPage()
        {
            taskFormControl = new TaskFormControl();
            app = AppInitializer.GetCurrentApp();
        }

        public void EnterTaskName(string TaskName)
        {
            var taskNameInputLambda = this.taskFormControl.TaskNameInput;
            this.app.EnterText(taskNameInputLambda, TaskName);
        }

        public void EnterNotesTask(string TaskNote)
        {
            var taskNotesInputLambda = this.taskFormControl.TaskNoteInput;
            app.EnterText(taskNotesInputLambda, TaskNote);
        }

        public void SaveTask()
        {
            var saveTaskLambda = this.taskFormControl.SaveTaskButton;
            app.DismissKeyboard();
            app.Tap(saveTaskLambda);
        }

    }
}
