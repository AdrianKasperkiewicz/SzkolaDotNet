﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Email.Domain.Common
{
    public class AuditableModel
    {
        [JsonIgnore]
        public int CreateById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        [JsonIgnore]
        public int? ModifiedById { get; set; }
        
        public DateTime? UpdatedDateTime { get; set; }
    }
}
