using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Agri_Energy_Prototype_Project.Models
{
    /// <summary>
    /// to generate a salt and hash the password. 
    /// Store both the salt and hashed password in  database.
    /// 
    /// </summary>
    public class PasswordHasher
    {
        public static string HashPassword(string password, out string salt)
        {
            salt = GenerateSalt(); // Generate a random salt
            var hashedPassword = HashPasswordWithSalt(password, salt);
            return hashedPassword;
        }

        private static string GenerateSalt()
        {
            var rng = new RNGCryptoServiceProvider();
            var saltBytes = new byte[64];
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        private static string HashPasswordWithSalt(string password, string salt)
        {
            var hashedPassword = "";
            var passwordBytes = Encoding.UTF8.GetBytes(password + salt);
            var sha256 = SHA256.Create();
            var hashBytes = sha256.ComputeHash(passwordBytes);
            hashedPassword = Convert.ToBase64String(hashBytes);
            return hashedPassword;
        }
        //--------------------------------Verification-------------------
        /// <summary>
        /// retrieve the stored salt and
        /// hashed password,  
        /// VerifyPassword to check if the entered password matches the stored hash.
        /// </summary>
        /// 
        public static bool VerifyPassword(string enteredPassword, string storedSalt, string storedHashedPassword)
        {
            var hashedEnteredPassword = HashPasswordWithSalt(enteredPassword, storedSalt);
            return hashedEnteredPassword == storedHashedPassword;
        }


    }
}