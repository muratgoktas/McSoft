using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        // out ref türü bir şey içerideki değişikliği passwrodHash ve passwordSalt a aktarıcak . referans tip yapıp
        public static void CreatePasswordHash(string password,out byte[] passwrodHash, out byte[] passwordSalt)
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                // out sayesinde bu atamaları yapabiliyoruz.
                passwordSalt = hmac.Key;
                passwrodHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password,  byte[] passwordHash,  byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!= passwordHash[i])
                    {
                        return false;
                    }
                 
                }
              
            }
            return true;
        }
    }
}
