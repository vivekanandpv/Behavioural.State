using System;

namespace Behavioural.State
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardApplication application = new CreditCardApplication();

            Console.WriteLine(application);

            application.ProcessRequest();

            Console.WriteLine(application);

            application.ProcessRequest();

            Console.WriteLine(application);

            application.ProcessRequest();

            Console.WriteLine(application);

            application.ProcessRequest();

            Console.WriteLine(application);

        }
    }
}
