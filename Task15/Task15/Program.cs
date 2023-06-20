using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    public class Program
    {
        static void Main(string[] args)
        {
            var encr = Encryptor.Encrypt("stierlitz");
            var decr = Encryptor.Decrypt(encr);

            var encr2 = Encryptor.Encrypt("A little bee");
            var decr2 = Encryptor.Decrypt(encr2);

            var encr3 = Encryptor.Encrypt("M u l l e r");
            var decr3 = Encryptor.Decrypt(encr3);

            var encr4 = Encryptor.Encrypt("Morse code");
            var decr4 = Encryptor.Decrypt(encr4);

            Console.WriteLine(encr);
            Console.WriteLine(decr);

            Console.WriteLine(encr2);
            Console.WriteLine(decr2);

            Console.WriteLine(encr3);
            Console.WriteLine(decr3);

            Console.WriteLine(encr4);
            Console.WriteLine(decr4);

            Console.ReadLine();
        }
    }
}
