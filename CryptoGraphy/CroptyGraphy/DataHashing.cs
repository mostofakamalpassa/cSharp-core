using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoGraphy.CroptyGraphy
{
    public class DataHashing
    {
        public void Hashing()
        {
            File.WriteAllText("myfile.txt", "");
            File.Encrypt("myfile.txt");
            File.AppendAllText("myfile.txt", "sensitive data");
            byte[] hash;

            using (Stream fs = File.OpenRead("checkme.doc"))
                hash = SHA1.Create().ComputeHash(fs); // SHA1 hash is 20 bytes long

            byte[] data = System.Text.Encoding.UTF8.GetBytes("stRhong%pword");
            byte[] hashs = SHA256.Create().ComputeHash(data);
        }

       
    }
}
