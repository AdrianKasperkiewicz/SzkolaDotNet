using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Email.App.Abstract;
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
            AddItem(new MenuAction(1, "Add User.", "Main"));
            AddItem(new MenuAction(2, "Send mail.", "Main"));
            AddItem(new MenuAction(3, "View the list of users.", "Main"));
            AddItem(new MenuAction(4, "Message history.", "Main"));
            AddItem(new MenuAction(5, "Get message by id.", "Main"));
            AddItem(new MenuAction(6, "Remove message by id", "Main"));
            AddItem(new MenuAction(7, "Delete users file.", "Main"));
            AddItem(new MenuAction(8, "Delete messages file.", "Main"));
            AddItem(new MenuAction(9, "Add file User.json.", "Main"));
            AddItem(new MenuAction(10, "Add file Messages.json", "Main"));
            AddItem(new MenuAction(11, "Get user by id", "Main"));
            AddItem(new MenuAction(12, "Remove user by id", "Main"));

        }
    }
}