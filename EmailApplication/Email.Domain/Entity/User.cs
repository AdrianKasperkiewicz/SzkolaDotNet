﻿using System;
using Email.Domain.Common;

namespace Email.Domain.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User()
        {
        }
        public User(string name, string lastName, string email, int id, DateTime createdDateTime, DateTime updatedDateTime)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Id = id;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }
    }
}
