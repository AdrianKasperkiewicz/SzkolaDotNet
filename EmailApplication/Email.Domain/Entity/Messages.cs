using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApplication.Domain.Entity
{
    public class Messages : User
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        
    }
}
