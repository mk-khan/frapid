using Frapid.DataAccess;
using Frapid.NPoco;

namespace Frapid.Authorization.DTO
{
    [TableName("account.users")]
    public class User : IPoco
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}