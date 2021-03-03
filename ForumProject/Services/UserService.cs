using EntityFramework.Repositories;
using Forum.EntityFramework.Entities;
using ForumProject.Dto;

namespace ForumProject.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService( IRepository<User> repository )
        {
            _repository = repository;
        }

        public void AddUser( UserDto userDto )
        {
            _repository.Save( ConvertToDbo( userDto ) );
        }

        public UserDto GetUserById( int id )
        {
            return Convert( _repository.GetItem( id ) );
        }

        private UserDto Convert( User userDbo )
        {
            return new UserDto
            {
                Id = userDbo.Id,
                Username = userDbo.Username,
                Login = userDbo.Login,
                UserImage = userDbo.Image.Path
            };
        }

        private User ConvertToDbo( UserDto userDto )
        {
            return new User
            {
                Username = userDto.Username,
                Login = userDto.Login,
                Password = userDto.Password
            };
        }
    }
}
