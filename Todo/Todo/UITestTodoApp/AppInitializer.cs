using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestTodoApp
{
    public class AppInitializer
    {
        static IApp app;

        private AppInitializer()
        {
            Console.WriteLine("Instance is created");
        }

        public static IApp StartApp(Platform platform)
        {
            if (app == null)
            {
                if (platform == Platform.Android)
                {
                    app = ConfigureApp.Android.InstalledApp("Todo.Android").StartApp();
                    return app;
                }

                app = ConfigureApp.iOS.StartApp();
                return app;
            }
            return app;
        }

        public static IApp GetCurrentApp()
        {
            return app;
        }
    }
}