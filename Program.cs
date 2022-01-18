﻿using System;

namespace trosso2024_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher;
            cipher = new Cipher(5);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encrypted message is: '{encrypted}");

            string decrypted;
            decrypted = cipher.Decrypt(encrypted);
            Console.Writeline($"The decrypted message is: '{decrypted}'");
        }
    }
}
