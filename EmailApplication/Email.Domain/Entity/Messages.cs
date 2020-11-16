using System;
using Email.Domain.Common;

namespace Email.Domain.Entity
{
    public class Messages : BaseEntity
    {
        public int Id { get; set; }
        public string MessageContents { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        
        public Messages()
        {
        }

        public Messages(int id, string email, string subject, string messageContents, DateTime createdDateTime, DateTime updateDateTime)
        {
            Id = id;
            Email = email;
            Subject = subject;
            MessageContents = messageContents;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updateDateTime;
        }

    }
}
