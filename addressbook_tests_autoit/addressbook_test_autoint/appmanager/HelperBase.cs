using AutoItX3Lib;

namespace addressbook_test_autoint
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        public static string WINTITLE = "Free Address Book";
        protected AutoItX3 Aux;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            WINTITLE = ApplicationManager.WINTITLE;
            Aux = manager.Aux;

        }
    }
}