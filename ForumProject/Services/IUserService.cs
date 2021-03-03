using ForumProject.Dto;

namespace ForumProject.Services
{
    public interface IUserService
    {
        UserDto GetUserById( int id );
        void AddUser( UserDto userDto );
    }
}
