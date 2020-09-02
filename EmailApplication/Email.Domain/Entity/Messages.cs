using Email.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApplication.Domain.Entity
{
    public class Messages :BaseEntity
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }

       
    }
}
