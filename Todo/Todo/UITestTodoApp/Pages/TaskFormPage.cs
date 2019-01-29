using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestTodoApp.Controls;
using Xamarin.UITest;
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
            this.app.ClearText(taskNameInputLambda);
            this.app.EnterText(taskNameInputLambda, TaskName);
        }

        public void EnterNotesTask(string TaskNote)
        {
            var taskNotesInputLambda = this.taskFormControl.TaskNoteInput;
            this.app.ClearText(taskNotesInputLambda);
            this.app.EnterText(taskNotesInputLambda, TaskNote);
        }

        public void SetTaskAsDone()
        {
            var taskDoneLambda = this.taskFormControl.DoneTaskSwitch;
            this.app.DismissKeyboard();
            this.app.TouchAndHold(taskDoneLambda);
        }

        public void SaveTask()
        {
            var saveTaskLambda = this.taskFormControl.SaveTaskButton;
            this.app.DismissKeyboard();
            this.app.Tap(saveTaskLambda);
        }

        public void DeleteTask()
        {
            var deleteTaskLambda = this.taskFormControl.DeleteTaskButton;
            this.app.Tap(deleteTaskLambda);
        }
    }
}
