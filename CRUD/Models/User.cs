namespace CRUD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PasswordHash { get; set; }   // null for Google (OAuth) users
        public string Role { get; set; } = "User";  // Admin / User
        public string Provider { get; set; } = "Local"; // Local / Google
    }
}
