namespace BookLibrary.Utils
{
    using System;
    using System.Security.Cryptography;
    using Microsoft.AspNetCore.Cryptography.KeyDerivation;
    public static class PasswordManager
    {

        public static string HashPassword(string password, string salt)
        {

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Convert.FromBase64String(salt),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }

        public static string GenerateSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (RNGCryptoServiceProvider? rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }


            return Convert.ToBase64String(salt);
        }

    }
}
