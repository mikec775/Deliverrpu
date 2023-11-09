using System.Security.Cryptography;
using System.Text;

namespace BusinessLogic.Helpers
{
    public static class HashHelper
    {
        public static string HashPassword(string password)
        {
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            using SHA512 sha512 = SHA512.Create();
            return Encoding.UTF8.GetString( sha512.ComputeHash(passwordBytes));
        }
        public static bool CompareHash(string hashToCompare, string passwordToCompare)
        {
            string hash = HashPassword(passwordToCompare);
            return string.Equals(hashToCompare, hash);
        }
    }
}
