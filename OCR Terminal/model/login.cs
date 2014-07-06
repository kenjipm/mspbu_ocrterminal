using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OCR_Terminal
{
    public partial class login
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string nama_id { get; set; }
        public string alamat { get; set; }
        public string pemilik { get; set; }
        public string role { get; set; }

        public const int HASH_BYTE_SIZE = 24;
        public const int PBKDF2_ITERATIONS = 1000;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;

        /// <summary>
        /// Creates a salted PBKDF2 hash of the password
        /// </summary>
        /// <param name="username">The username as salt</param>
        /// <param name="password">The password to hash</param>
        /// <returns>The hash of the password</returns>
        public static string createHash(string username, string password)
        {
            // Username as a salt
            byte[] salt = new byte[username.Length * sizeof(char)];
            System.Buffer.BlockCopy(username.ToCharArray(), 0, salt, 0, salt.Length);

            // Hash the password and encode the parameters
            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Computes the PBKDF2-SHA1 hash of a password.
        /// </summary>
        /// <param name="password">The password to hash</param>
        /// <param name="salt">The salt</param>
        /// <param name="iterations">The PBKDF2 iterations count</param>
        /// <param name="outputBytes">The length of the hash to generate, in bytes</param>
        /// <returns>A hash of the password</returns>
        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }
    }
}