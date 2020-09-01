using System;
using System.Collections.Generic;
using System.Text;
using Email.Domain.Common;

namespace EmailApplication.Domain.Entity
{
    public class User :BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}
