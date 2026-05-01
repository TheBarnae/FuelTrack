namespace FuelTrack
{
    public sealed class UserSession
    {
        public UserSession(int employeeId, string username, string? fullName, string role)
        {
            EmployeeId = employeeId;
            Username = username;
            FullName = fullName ?? string.Empty;
            Role = role;
        }

        public int EmployeeId { get; }
        public string Username { get; }
        public string FullName { get; }
        public string Role { get; }

        public string DisplayName => string.IsNullOrWhiteSpace(FullName)
            ? $"{Role} - {Username}"
            : $"{Role} - {FullName}";
    }

    public static class SessionContext
    {
        public static UserSession? CurrentUser { get; private set; }

        public static void SetUser(UserSession user)
        {
            CurrentUser = user;
        }

        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}
