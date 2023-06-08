﻿using Exchange.Entity.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service.Services.Abstractions
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUserWithRoleAsync();

    }
}
