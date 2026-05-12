using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Helper
{
    public class HashPassword
    {
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor:12);
        }
        public static bool Verify(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
