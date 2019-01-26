using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestTodoApp
{
    [TestFixture(Platform.Android)]
    // [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //[Test]
        //public void TestWithRelp()
        //{
        //    app.Repl();
        //}

        

        [Test]
        public void NavegationBar()
        {
            app.Tap(c => c.Marked("+"));
            app.Tap(c => c.Class("AppCompatImageButton"));
        }

        [Test]
        public void AddNewTask()
        {
            // Act
            app.Tap(c => c.Marked("+"));
            app.EnterText(c => c.Class("FormsEditText").Index(0), "learn c#");
            app.EnterText(c => c.Class("FormsEditText").Index(1), "cool");
            app.DismissKeyboard();
            //app.Tap(c => c.Class("SwitchCompat"));
            app.TouchAndHold(c => c.Class("SwitchCompat"));
            app.Tap(c => c.Class("AppCompatButton").Text("Save"));

            // Assert
            app.WaitForElement(c => c.Marked("learn c#"));
            string a = app.Query(c => c.Class("FormsTextView")).First().Text;
            Assert.IsTrue(a.Equals("learn c#"));
            ////app.Query(c => c.All().Class("FormsTextView").Index(1)).First().Text

            //// Act
            //app.Tap(c => c.Class("FormsTextView").Text("learn c#"));
            //app.ClearText(c => c.Class("FormsEditText").Index(0));
            //app.ClearText(c => c.Class("FormsEditText").Index(1));
            //app.EnterText(c => c.Class("FormsEditText").Index(0), "modificado");
            //app.Tap(c => c.Class("SwitchCompat"));
            //app.Tap(c => c.Class("AppCompatButton").Text("Save"));
            //// Assert
            //app.WaitForElement(c => c.Marked("modificado"));

            //// Act
            //app.Tap(c => c.Class("FormsTextView").Text("modificado"));
            //app.Tap(c => c.Class("AppCompatButton").Text("Delete"));
            //// Assert
            //app.WaitForNoElement(c => c.Marked("modificado"));

        }
        [Test]
        public void EditTask()
        {
            // Arrange
            app.Tap(c => c.Marked("+"));
            app.EnterText(c => c.Class("FormsEditText").Index(0), "learn c#");
            app.EnterText(c => c.Class("FormsEditText").Index(1), "cool");
            app.DismissKeyboard();
            app.TouchAndHold(c => c.Class("SwitchCompat"));
            app.Tap(c => c.Class("AppCompatButton").Text("Save"));

            // Act
            app.Tap(c => c.Class("FormsTextView").Text("learn c#"));
            app.ClearText(c => c.Class("FormsEditText").Index(0)); 
            app.ClearText(c => c.Class("FormsEditText").Index(1));
            app.EnterText(c => c.Class("FormsEditText").Index(0), "modificado");
            app.Tap(c => c.Class("SwitchCompat"));
            app.Tap(c => c.Class("AppCompatButton").Text("Save"));

            // Assert
            app.WaitForElement(c => c.Marked("modificado"));
            string a = app.Query(c => c.Class("FormsTextView")).First().Text;
            Assert.IsTrue(a.Equals("modificado"));

        }

        [Test]
        public void DeleteTask()
        {
            // Arrage
            app.Tap(c => c.Marked("+"));
            app.EnterText(c => c.Class("FormsEditText").Index(0), "learn c#");
            app.EnterText(c => c.Class("FormsEditText").Index(1), "cool");
            app.DismissKeyboard();
            app.TouchAndHold(c => c.Class("SwitchCompat"));
            app.Tap(c => c.Class("AppCompatButton").Text("Save"));
            
            // Act
            app.Tap(c => c.Class("FormsTextView").Text("learn c#"));
            app.Tap(c => c.Class("AppCompatButton").Text("Delete"));

            // Assert
            app.WaitForNoElement(c => c.Marked("learn c#"));

        }

        //[Test]
        //public void AddTask2()
        //{
        //    app.Tap(c => c.Marked("+"));
        //    app.EnterText(c => c.Class("FormsEditText").Index(0), "Task2");
        //    app.EnterText(c => c.Class("FormsEditText").Index(1), "yes");
        //    app.DismissKeyboard();
        //    app.Tap(c => c.Class("AppCompatButton").Text("Save"));

        //    app.Tap(c => c.Class("FormsTextView").Text("Task2"));
        //    app.Tap(c => c.Class("SwitchCompat"));
        //    app.Tap(c => c.Class("AppCompatButton").Text("Save"));

        //    app.Tap(c => c.Marked("+"));
        //    app.EnterText(c => c.Class("FormsEditText").Index(0), "Task3");
        //    app.DismissKeyboard();
        //    app.Tap(c => c.Class("AppCompatButton").Text("Save"));
        //}
    }
}
