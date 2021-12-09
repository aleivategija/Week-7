using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta numbrina, millist funktsiooni soovid (1, 2 voi 3)");
            char userChoice = Convert.ToChar(Console.ReadLine());

            switch(userChoice)
            {
                case '1':
                    FirstNameReverse(userName);
                    break;
                case '2':
                    FirstNameLetter(userName);
                    break;
                case '3':
                    FirstNameLength(userName);
                    break;
            }
           
        }

        public static void FirstNameReverse(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
            }
                
        }

        public static void FirstNameLetter(string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene taht on {userName[0]}");
        }

        public static void FirstNameLength(string userName)
        {
            Console.WriteLine($"Sinu nimi on {userName.Length} sumbolit pikk.");
        }
    }
}
