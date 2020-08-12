using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public Array DomainAdress { get; set; }
        public string Message { get; set; }
        public int MessageId { get; set; }
        public string Subject { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
