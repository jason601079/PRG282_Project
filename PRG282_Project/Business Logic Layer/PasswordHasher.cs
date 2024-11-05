using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PRG282_Project.Business_Logic_Layer
{
    public class PasswordHasher
    {

        public string HashPassword(string password)
        {
            // Convert the password string to a byte array
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Use SHA-256 to hash the password
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash for the byte array
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hashed byte array to a readable string (hexadecimal format)
                StringBuilder hashedPassword = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    hashedPassword.Append(b.ToString("x2"));
                }

                return hashedPassword.ToString();
            }
        }

    }
}
