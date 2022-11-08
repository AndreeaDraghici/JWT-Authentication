using JWTASPNetCore.Models;

namespace JWTASPNetCore.Interfaces
{
    public interface IUserRepository
    {
        UserDTO GetUser(UserModel userModel);
    }
}
