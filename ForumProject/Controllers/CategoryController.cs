using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Repositories;
using Forum.EntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ForumProject.Controllers
{
    [ApiController]
    [Route( "[controller]" )]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;

        public CategoryController( IRepository<User> repository )
        {
            _userRepository = repository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var user = _userRepository.All.First();

            return new List<WeatherForecast>()
            {
                new WeatherForecast
                {
                    Summary = user.Login
                }
            };
        }
    }
}
