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

        public void SelectTask()
        {
            //app.WaitForElement(task);
            //app.Tap(task);
            var taskListLambda = this.taskListControl.TaskList;
            app.WaitForElement(taskListLambda);
            app.Tap(taskListLambda);
        }
    }
}
