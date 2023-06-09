using AutoMapper;
using Exchange.Data.Repositories.UnitOfWorks.Abstractions;
using Exchange.Entity.DTOs.Users;
using Exchange.Entity.Entities;
using Exchange.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;       
        private readonly IHttpContextAccessor _httpContextAccessor;       
        private readonly UserManager<AppUser> _userManager; 
        private readonly RoleManager<AppRole> _roleManager;
       
       

        public UserService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<List<UserDto>> GetAllUser()
        {
            throw new NotImplementedException();
        }


    }
}
