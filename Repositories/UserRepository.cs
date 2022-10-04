using ApiAuth.Models;

namespace ApiAuth.Repositories;

public static class UserRepository
{
    public static UserModel? Get(string username, string password)
    {
        var users = new List<UserModel?>
        {
            new() { Id = 1, Username = "batman", Password = "batman", Role = "manager"},
            new() { Id = 2, Username = "robin", Password = "robin", Role = "employee"}
        };

        return users
            .FirstOrDefault(x => 
                x.Username == username 
                && x.Password == password);
    }
}