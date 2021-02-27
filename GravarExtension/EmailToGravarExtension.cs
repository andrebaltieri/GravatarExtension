using System;
using System.Security.Cryptography;
using System.Text;

namespace GravarExtension
{
    public static class EmailToGravarExtension
    {
        public static string ToGravatar(this string email)
        {
            if (string.IsNullOrEmpty(email))
                return string.Empty;

            using var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(email);
            var hashBytes = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var t in hashBytes)
                sb.Append(t.ToString("X2"));

            return $"https://www.gravatar.com/avatar/{sb.ToString().ToLower()}";
        }
    }
}
