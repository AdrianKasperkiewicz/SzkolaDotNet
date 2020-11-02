using System.Collections.Generic;
using Email.App.Abstract;
using Email.Domain.Entity;

namespace Email.App.Concrete
{
    public class StartScreenServices : BaseService<MenuAction>
    {
        public List<MenuAction> GetMenuActions(string menuName)
        {
            List<MenuAction> result=new List<MenuAction>();
            foreach (var menuAction in Users)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
    }
}
