using System;
using System.Collections.Generic;
using System.Text;

namespace Email.Domain.Common
{
    public class BaseEntity : AuditableModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
    }
}
