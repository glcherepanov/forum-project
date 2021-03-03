using EntityFramework.Repositories;
using Forum.EntityFramework.Entities;
using ForumProject.Dto;
using ForumProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Controllers
{
    [ApiController]
    [Route( "[controller]" )]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController( IUserService userService )
        {
            _userService = userService;
        }

        [HttpGet]
        public UserDto Get( int id )
        {
            return _userService.GetUserById( id );
        }
    }
}
