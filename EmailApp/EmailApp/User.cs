using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp
{
    public class User : Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string DomainAdress { get; set; }
        public string AllAdress { get; set; }

    }
}
