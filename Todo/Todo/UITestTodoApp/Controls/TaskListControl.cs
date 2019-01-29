using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace UITestTodoApp.Controls
{
    class TaskListControl
    {
        private Func<AppQuery, AppQuery> plusButton;
        private Func<AppQuery, AppQuery> taskList;
        private Func<AppQuery, AppQuery> checkDoneTask;


        public Func<AppQuery, AppQuery> PlusButton
        {
            get
            {
                this.plusButton = c => c.Marked("+");
                return this.plusButton;
            }
        }

        public Func<AppQuery, AppQuery> TaskDone
        {
            get
            {
                this.checkDoneTask = c => c.Class("FormsImageView");
                return this.checkDoneTask;
            }
        }

        public Func<AppQuery, AppQuery> TaskList
        {
            get
            {
                this.taskList = c => c.Class("FormsTextView");
                return this.taskList;
            }
        }

    }
}
