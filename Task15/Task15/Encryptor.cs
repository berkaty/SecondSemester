using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Task15
{
    /// <summary>
    /// Класс для шифрования и дешифрования сообщений
    /// </summary>
    public static class Encryptor
    {
        /// <summary>
        /// Шифрует сообщение по алгоритму, представленному в задании
        /// </summary>
        /// <param name="stringEncrypt">Строка для шифрования</param>
        /// <returns>Шифрованную строку</returns>
        public static String Encrypt(String stringEncrypt)
        {
            var lowerString = stringEncrypt.ToLower();
            var textWithOnlyChars = Regex.Replace(lowerString, @"[^a-z]", "");
            var noRepetitionsString = Regex.Replace(textWithOnlyChars, @"([a-z])\1", @"$1");

            //Длина получившейся строки
            var length = noRepetitionsString.Length;
            var countRandom = new Random().Next(length, 3 * length);
            var stringBuilder = new StringBuilder(noRepetitionsString);

            for (var i = 0; i < countRandom; i++)
            { 
                stringBuilder.Insert(new Random().Next(0, stringBuilder.Length), ((char)new Random().Next('a', 'z')).ToString(), 2);
                Thread.Sleep(new Random().Next(3, 14));
            }
            return stringBuilder.ToString();
        }
        /// <summary>
        /// Дешифрует сообщение по алгоритму, представленному в задании
        /// </summary>
        /// <param name="stringDecrypt">Строка для дешифрования</param>
        /// <returns>Дешифрованную строку</returns>
        public static String Decrypt(String stringDecrypt)
        {
            var stringBuilder = new StringBuilder(stringDecrypt);

            while (true)
            {
                var end = true;
                for (var i = 0; i < stringBuilder.Length - 1; i++)
                    if (stringBuilder[i] == stringBuilder[i + 1])
                    { 
                        stringBuilder.Remove(i, 2);
                        end = false;
                    }
                if (end) break;
            }

            return stringBuilder.ToString();
        } 
    }
}