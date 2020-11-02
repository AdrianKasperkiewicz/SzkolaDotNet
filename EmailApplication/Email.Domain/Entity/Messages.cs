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

    }
}
