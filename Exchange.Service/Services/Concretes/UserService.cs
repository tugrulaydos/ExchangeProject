using Exchange.Data.Repositories.UnitOfWorks.Abstractions;
using Exchange.Entity.DTOs.Users;
using Exchange.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        public UserService()
        {

        }
        public Task<List<UserDto>> GetAllUserWithRoleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
