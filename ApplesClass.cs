using System;

namespace CanHazSourceLink.Apples
{
    public class ApplesClass
    {
        public void MyMethod()
        {
            if (!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("APPLES")))
            {
                Console.WriteLine("apples");
            }
        }
    }
}
