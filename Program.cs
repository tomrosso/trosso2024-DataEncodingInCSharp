using System;

namespace trosso2024_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           int shift;
           shift = 1;
           while(shift <= 10){
              Cipher cipher1;
            cipher1 = new Cipher(1);
            Console.WriteLine ((char)(shift + 1));
           }


           string filePath = args[0];
           Console.WriteLine($"Loading '{filePath}'.");
           
           string message;
           message = System.IO.File.ReadAllText(filePath);
           Console.WriteLine($"The encrypted message is: {message}");

            Cipher cipher;
            cipher = new Cipher(3);

            //string encrypted;
            //encrypted = cipher.Encrypt("rosebud");
            //Console.WriteLine($"The encrypted message is: '{encrypted}");

           string decrypted;
            decrypted = cipher.Decrypt(message);
            Console.WriteLine($"The decrypted message is: '{decrypted}'");
        }
    }
}
