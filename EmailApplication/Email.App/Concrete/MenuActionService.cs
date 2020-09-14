using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Email.App.Common;
using Email.Domain.Entity;

namespace Email.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
       
        private List<MenuAction> menuActions;

        public MenuActionService()
        {
            Initialize();
        }

        //public void AddNewAction(int id, string name, string menuName)
        //{
        //    MenuAction menuAction = new MenuAction(id, name, )
        //    {
        //        MenuName = menuName
        //    };
        //    menuActions.Add(menuAction);

        //}

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

        private void Initialize()
        {
            AddItem(new MenuAction(1,"Add User.", "Main"));
            AddItem(new MenuAction(2, "Send mail.", "Main"));
            AddItem(new MenuAction(3, "View the list of users.", "Main"));
            AddItem(new MenuAction(4, "Message history.", "Main"));
            AddItem(new MenuAction(5, "Delete users file.", "Main"));
            AddItem(new MenuAction(6, "Delete messages history file.", "Main"));
            AddItem(new MenuAction(7, "Add file User.txt.", "Main"));
            AddItem(new MenuAction(8, "Add file Messages.txt", "Main"));

        }
    }
}