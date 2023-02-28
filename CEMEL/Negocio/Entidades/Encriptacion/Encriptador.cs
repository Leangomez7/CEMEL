using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CEMEL.Negocio.Entidades.Encriptacion
{
    public static class Encriptador
    {
        // Código extraido de https://www.youtube.com/watch?v=OUIsmKiEvWc

        public static byte[] GenerateSalt()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var salt = new byte[32];
                randomNumberGenerator.GetBytes(salt);
                return salt;
            }
        }

        /// <summary>
        /// Encripta un string dado
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="iterations"></param>
        /// <returns>
        /// Un array de bytes
        /// </returns>
        public static byte[] HashPassword(string password, byte[] salt, int iterations)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, iterations: 600000))
            {
                return rfc2898.GetBytes(32);
            }
        }

        /// <summary>
        /// Compara dos arrays de bytes
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns>
        /// true : ambos arrays son iguales
        /// false : los arrays son distintos
        /// </returns>
        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
