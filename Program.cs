using System;

namespace RandomPasswordGeneratorus
{
    class Program
    {
        static void Main( string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelp();
                return;
            }

            var length = Convert.ToInt32(args[0]);
            var options = args[1];

            var alltogether = options.PadLeft(length, 's');
            var password = string.Empty;
            while (alltogether.Length > 0)
            {
                var randomIndex = Random.Next(0, alltogether.Length - 1);

            }
        }
    }
}
