using System;

namespace PasswordChecker
{
    class Program
    {

        public static void Main(string[] args)
        {

            int minLength = 2;

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string lowercase = "abcdefghijklmnopqrstuvwxyz";

            string digits = "12345678910";

            string specialChars = "!@£$%^&*()";

            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length > minLength)
            {
                score++;
            }

            if (password.Contains(uppercase))
            {
                score++;
            }

            if (password.Contains(lowercase))
            {
                score++;
            }

            if (password.Contains(digits))
            {
                score++;
            }

            if (password.Contains(specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("This password is very strong");
                    break;
                case 3:
                    Console.WriteLine("This password is strong");
                    break;
                case 2:
                    Console.WriteLine("This password is medium");
                    break;
                case 1:
                    Console.WriteLine("This password is weak");
                    break;
                default:
                    Console.WriteLine("This is not a password");
                    break;
            }
        }
    }
}
