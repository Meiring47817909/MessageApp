using Humanizer.Bytes;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; } //Default is 0 By convetion entity Framework will use property called id a primary key
    public required string UserName { get; set; } //Default is null if not required
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
