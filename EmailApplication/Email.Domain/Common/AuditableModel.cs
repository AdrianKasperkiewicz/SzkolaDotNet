﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Email.Domain.Common
{
    public class AuditableModel
    {
        public int CreateById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}