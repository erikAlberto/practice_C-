using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace UITestTodoApp.Controls
{
    class TaskFormControl
    {
        private Func<AppQuery, AppQuery> backButton;
        private Func<AppQuery, AppQuery> taskNameInput;
        private Func<AppQuery, AppQuery> notesTaskInput;
        private Func<AppQuery, AppQuery> doneTaskSwitch;
        private Func<AppQuery, AppQuery> saveTaskButton;
        private Func<AppQuery, AppQuery> deleteTaskButton;


        public Func<AppQuery, AppQuery> TaskNameInput
        {
            get
            {
                this.taskNameInput = c => c.Class("FormsEditText").Index(0);
                return this.taskNameInput;
            }
        }

        public Func<AppQuery, AppQuery> TaskNoteInput
        {
            get
            {
                this.notesTaskInput = c => c.Class("FormsEditText").Index(1);
                return this.notesTaskInput;
            }
        }

        public Func<AppQuery, AppQuery> DoneTaskSwitch
        {
            get
            {
                this.doneTaskSwitch = c => c.Class("SwitchCompat");
                return this.doneTaskSwitch;
            }
        }


        public Func<AppQuery, AppQuery> SaveTaskButton
        {
            get
            {
                this.saveTaskButton = c => c.Class("AppCompatButton").Text("Save");
                return this.saveTaskButton;
            }
        }

        public Func<AppQuery, AppQuery> DeleteTaskButton
        {
            get
            {
                this.deleteTaskButton = c => c.Class("AppCompatButton").Text("Delete");
                return this.deleteTaskButton;
            }
        }
    }
}
