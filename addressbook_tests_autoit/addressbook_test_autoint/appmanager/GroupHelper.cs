using System;
using System.Collections.Generic;

namespace addressbook_test_autoint
{
    public class GroupHelper:HelperBase
    {
        public static string GROUPWINTITITLE = "Group editor";
        public GroupHelper(ApplicationManager manager) : base(manager) { }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>();
            OpenGroupsDialog();
            string count = Aux.ControlTreeView(GROUPWINTITITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "GetItemCount","#0","");
            CloseGroupsDialog();
            return list;
           
        }

        public void Add(GroupData newGroup)
        {
            OpenGroupsDialog();
            Aux.ControlClick(GROUPWINTITITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            Aux.Send(newGroup.Name);
            Aux.Send("{ENTER}");
            CloseGroupsDialog();
        }

        private void CloseGroupsDialog()
        {
            Aux.ControlClick(GROUPWINTITITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

        private void OpenGroupsDialog()
        {
            Aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            Aux.WinWait(GROUPWINTITITLE);
        }
    }
}