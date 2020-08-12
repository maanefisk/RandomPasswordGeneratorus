using System;

namespace RandomPasswordGeneratorus
{
    class Program
    {
        static void Main()
        {
            
            string s = "noe";
            while (!string.IsNullOrWhiteSpace(s))
            {
                s = Console.ReadLine();
                Console.WriteLine("PasswordGenerator \n Options: \n -l = lower case letter \n - L = upper case letter \n - d = digit \n - s = special character(!\"#¤%&/(){}[] \n Example: PasswordGenerator 14 lLssdd \n Min. 1 lower case \n Min. 1 upper case \n Min. 2 special characters \n Min. 2 digits");

                foreach (var c in s)
                {
                    
                }

                if (s.Length == 2) {
                }

                if (s.Contains(int))
            }
        }
    }
}
