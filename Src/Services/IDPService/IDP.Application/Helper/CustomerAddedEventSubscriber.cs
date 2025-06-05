using DotNetCore.CAP;
using IDP.Application.Command.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IDP.Application.Helper
{
    public class CustomerAddedEventSubscriber: ICapSubscribe
    {
        [CapSubscribe("otpevent")]
        public void Consumer(AuthCommand  authCommand)

        {
            Console.WriteLine(authCommand.MobileNumber);
        }
    }
}
