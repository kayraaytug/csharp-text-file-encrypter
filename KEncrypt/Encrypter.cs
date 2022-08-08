using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Kencrypt

{
    public class Crypter
    {

        static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

        public void Main(string[] args)
        {

        }

        public static char GenerateChar(string availableChars)
        {
            var byteArray = new byte[1];
            char c;
            do
            {
                provider.GetBytes(byteArray);
                c = (char)byteArray[0];

            } while (!availableChars.Any(x => x == c));

            return c;
        }
    }
}