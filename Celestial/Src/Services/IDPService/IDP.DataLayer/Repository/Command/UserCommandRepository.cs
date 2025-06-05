using IDP.Domain.Entities.Account;
using IDP.Domain.IRepository.Command;

namespace IDP.DataLayer.Repository.Command
{
    public class UserCommandRepository : IUserCommandRepository
    {
        public Task<bool> Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
