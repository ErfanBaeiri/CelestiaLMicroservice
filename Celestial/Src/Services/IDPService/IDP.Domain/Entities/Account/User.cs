using IDP.Domain.Entities.Common;

namespace IDP.Domain.Entities.Account
{
    public class User : BaseEntity
    {
        public required string FullName { get; set; }
        public required string CodeNumber { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Salt { get; set; }
    }
}
