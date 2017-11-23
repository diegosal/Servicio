using System;
using System.Text;
using System.Security.Cryptography;

namespace PasswordSecurity
{
    /// <summary>
    /// Class InvalidHashException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    class InvalidHashException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidHashException"/> class.
        /// </summary>
        public InvalidHashException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidHashException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidHashException(string message)
            : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidHashException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public InvalidHashException(string message, Exception inner)
            : base(message, inner) { }
    }

    /// <summary>
    /// Class CannotPerformOperationException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    class CannotPerformOperationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CannotPerformOperationException"/> class.
        /// </summary>
        public CannotPerformOperationException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CannotPerformOperationException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public CannotPerformOperationException(string message)
            : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CannotPerformOperationException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public CannotPerformOperationException(string message, Exception inner)
            : base(message, inner) { }
    }

    /// <summary>
    /// Class PasswordStorage.
    /// </summary>
    class PasswordStorage
    {
        // These constants may be changed without breaking existing hashes.
        /// <summary>
        /// The salt bytes
        /// </summary>
        public const int SALT_BYTES = 24;
        /// <summary>
        /// The hash bytes
        /// </summary>
        public const int HASH_BYTES = 18;
        /// <summary>
        /// The PBKD f2 iterations
        /// </summary>
        public const int PBKDF2_ITERATIONS = 64000;

        // These constants define the encoding and may not be changed.
        /// <summary>
        /// The hash sections
        /// </summary>
        public const int HASH_SECTIONS = 5;
        /// <summary>
        /// The hash algorithm index
        /// </summary>
        public const int HASH_ALGORITHM_INDEX = 0;
        /// <summary>
        /// The iteration index
        /// </summary>
        public const int ITERATION_INDEX = 1;
        /// <summary>
        /// The hash size index
        /// </summary>
        public const int HASH_SIZE_INDEX = 2;
        /// <summary>
        /// The salt index
        /// </summary>
        public const int SALT_INDEX = 3;
        /// <summary>
        /// The PBKD f2 index
        /// </summary>
        public const int PBKDF2_INDEX = 4;

        /// <summary>
        /// Creates the hash.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="PasswordSecurity.CannotPerformOperationException">
        /// Random number generator not available.
        /// or
        /// Invalid argument given to random number generator.
        /// </exception>
        public static string CreateHash(string password)
        {
            // Generate a random salt
            byte[] salt = new byte[SALT_BYTES];
            try
            {
                using (RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider())
                {
                    csprng.GetBytes(salt);
                }
            }
            catch (CryptographicException ex)
            {
                throw new CannotPerformOperationException(
                    "Random number generator not available.",
                    ex
                );
            }
            catch (ArgumentNullException ex)
            {
                throw new CannotPerformOperationException(
                    "Invalid argument given to random number generator.",
                    ex
                );
            }

            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTES);

            // format: algorithm:iterations:hashSize:salt:hash
            String parts = "sha1:" +
                PBKDF2_ITERATIONS +
                ":" +
                hash.Length +
                ":" +
                Convert.ToBase64String(salt) +
                ":" +
                Convert.ToBase64String(hash);
            return parts;
        }

        /// <summary>
        /// Verifies the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="goodHash">The good hash.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="PasswordSecurity.InvalidHashException">
        /// Fields are missing from the password hash.
        /// or
        /// Could not parse the iteration count as an integer.
        /// or
        /// The iteration count is too large to be represented.
        /// or
        /// Invalid number of iterations. Must be >= 1.
        /// or
        /// Base64 decoding of salt failed.
        /// or
        /// Base64 decoding of pbkdf2 output failed.
        /// or
        /// Could not parse the hash size as an integer.
        /// or
        /// The hash size is too large to be represented.
        /// or
        /// Hash length doesn't match stored hash length.
        /// </exception>
        /// <exception cref="PasswordSecurity.CannotPerformOperationException">
        /// Unsupported hash type.
        /// or
        /// Invalid argument given to Int32.Parse
        /// or
        /// Invalid argument given to Convert.FromBase64String
        /// or
        /// Invalid argument given to Convert.FromBase64String
        /// or
        /// Invalid argument given to Int32.Parse
        /// </exception>
        public static bool VerifyPassword(string password, string goodHash)
        {
            char[] delimiter = { ':' };
            string[] split = goodHash.Split(delimiter);

            if (split.Length != HASH_SECTIONS)
            {
                throw new InvalidHashException(
                    "Fields are missing from the password hash."
                );
            }

            // We only support SHA1 with C#.
            if (split[HASH_ALGORITHM_INDEX] != "sha1")
            {
                throw new CannotPerformOperationException(
                    "Unsupported hash type."
                );
            }

            int iterations = 0;
            try
            {
                iterations = Int32.Parse(split[ITERATION_INDEX]);
            }
            catch (ArgumentNullException ex)
            {
                throw new CannotPerformOperationException(
                    "Invalid argument given to Int32.Parse",
                    ex
                );
            }
            catch (FormatException ex)
            {
                throw new InvalidHashException(
                    "Could not parse the iteration count as an integer.",
                    ex
                );
            }
            catch (OverflowException ex)
            {
                throw new InvalidHashException(
                    "The iteration count is too large to be represented.",
                    ex
                );
            }

            if (iterations < 1)
            {
                throw new InvalidHashException(
                    "Invalid number of iterations. Must be >= 1."
                );
            }

            byte[] salt = null;
            try
            {
                salt = Convert.FromBase64String(split[SALT_INDEX]);
            }
            catch (ArgumentNullException ex)
            {
                throw new CannotPerformOperationException(
                    "Invalid argument given to Convert.FromBase64String",
                    ex
                );
            }
            catch (FormatException ex)
            {
                throw new InvalidHashException(
                    "Base64 decoding of salt failed.",
                    ex
                );
            }

            byte[] hash = null;
            try
            {
                hash = Convert.FromBase64String(split[PBKDF2_INDEX]);
            }
            catch (ArgumentNullException ex)
            {
                throw new CannotPerformOperationException(
                    "Invalid argument given to Convert.FromBase64String",
                    ex
                );
            }
            catch (FormatException ex)
            {
                throw new InvalidHashException(
                    "Base64 decoding of pbkdf2 output failed.",
                    ex
                );
            }

            int storedHashSize = 0;
            try
            {
                storedHashSize = Int32.Parse(split[HASH_SIZE_INDEX]);
            }
            catch (ArgumentNullException ex)
            {
                throw new CannotPerformOperationException(
                    "Invalid argument given to Int32.Parse",
                    ex
                );
            }
            catch (FormatException ex)
            {
                throw new InvalidHashException(
                    "Could not parse the hash size as an integer.",
                    ex
                );
            }
            catch (OverflowException ex)
            {
                throw new InvalidHashException(
                    "The hash size is too large to be represented.",
                    ex
                );
            }

            if (storedHashSize != hash.Length)
            {
                throw new InvalidHashException(
                    "Hash length doesn't match stored hash length."
                );
            }

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        /// <summary>
        /// Slows the equals.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }

        /// <summary>
        /// PBKDs the f2.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="salt">The salt.</param>
        /// <param name="iterations">The iterations.</param>
        /// <param name="outputBytes">The output bytes.</param>
        /// <returns>System.Byte[].</returns>
        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt))
            {
                pbkdf2.IterationCount = iterations;
                return pbkdf2.GetBytes(outputBytes);
            }
        }
    }
}