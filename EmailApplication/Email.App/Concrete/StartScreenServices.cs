using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Email.App.Common;
using Email.App.Concrete;
using Email.Domain.Entity;
using EmailApplication.Services.Concrete;

namespace EmailApplication.App.Concrete
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
