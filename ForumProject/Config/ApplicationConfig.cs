using Forum.EntityFramework.Configuration;
using Microsoft.Extensions.Configuration;

namespace ForumProject.Config
{
    internal class ApplicationConfig
    {
        public DbContextConfiguration DbContextConfiguration => _serviceConfiguration.GetSection( "DbContextConfiguration" ).Get<DbContextConfiguration>();

        private readonly IConfiguration _serviceConfiguration;

        public ApplicationConfig( IConfiguration serviceConfiguration )
        {
            _serviceConfiguration = serviceConfiguration;
        }
    }
}