using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task15
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var text = "A little bee";
            var encr = Encryptor.Encrypt(text);
            var decr = Encryptor.Decrypt(encr);

            Assert.AreEqual("alitlebe", decr);
        }

        [Test]
        public void Test2()
        {
            var text = "stierlitz";
            var encr = Encryptor.Encrypt(text);
            var decr = Encryptor.Decrypt(encr);

            Assert.AreEqual("stierlitz", decr);
        }
    }
}
