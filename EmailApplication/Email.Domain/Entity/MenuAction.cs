using System;
using System.Collections.Generic;
using System.Text;
using Email.Domain.Common;

namespace Email.Domain.Entity
{
    public class MenuAction : BaseEntity
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string MenuName { get; set; }

        public MenuAction(int id)
        {
            Id = id;
        }

        public MenuAction(int id, string name, string menuName)
        {
            Id = id;
            Name = name;
            MenuName = menuName;
        }

    }
}
