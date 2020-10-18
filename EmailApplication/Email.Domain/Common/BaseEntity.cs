using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Email.Domain.Common
{
    public class BaseEntity : AuditableModel
    {
        public int Id { get; set; }
    }
}
