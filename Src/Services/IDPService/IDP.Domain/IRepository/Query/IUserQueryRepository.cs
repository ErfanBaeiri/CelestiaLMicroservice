﻿using IDP.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Domain.IRepository.Query
{
    public interface IUserQueryRepository
    {
        Task<User> GetUserAsync(string mobilenumber);    
    }
}
