using IDP.Domain.Entities.Account;
using IDP.Domain.IRepository.Common;

namespace IDP.Domain.IRepository.Command
{
    public interface IUserCommandRepository : ICommandRepository<User>
    {
      
    }
}
