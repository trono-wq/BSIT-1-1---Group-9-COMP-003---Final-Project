using System;

namespace HRApplicantSystem
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static int RoleId { get; set; }

        public static void SetUser(int userId, string fullName, string email, int roleId)
        {
            UserId = userId;
            FullName = fullName;
            Email = email;
            RoleId = roleId;
        }

        public static void Clear()
        {
            UserId = 0;
            FullName = null;
            Email = null;
            RoleId = 0;
        }

        public static bool IsLoggedIn()
        {
            return UserId > 0;
        }
    }
}