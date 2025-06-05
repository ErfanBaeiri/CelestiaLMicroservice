using IDP.Application.Command.User;
using IDP.Domain.IRepository.Command;
using IDP.Domain.Entities.Account;
using MediatR;

namespace IDP.Application.Handler.Command.User
{
    public class UserHandler : IRequestHandler<UserCommand, bool>
    {
        #region DI
        private readonly IUserCommandRepository _userRepository;
        public UserHandler(IUserCommandRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            var res = await _userRepository.CreateUser(new IDP.Domain.Entities.Account.User
            {
                FullName = request.FullName,
                CodeNumber = request.CodeNumber
            });

            return res;
        }
    }
}
