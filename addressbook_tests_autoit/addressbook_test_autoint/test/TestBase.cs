using System;
using NUnit.Framework;

namespace addressbook_test_autoint
{
    
    public class TestBase
    {
        public ApplicationManager app;
        [SetUp]
        public void initApplication()
        {
            app = new ApplicationManager();

        }
        [TearDown]
        public void stopApplication()
        {
            app.Stop();
        }
    }
}
