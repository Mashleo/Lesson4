using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var lowBorder = 200;
            var higtBorder = 500;
           
            string result = string.Empty;
            string resultString = string.Empty;
            while (lowBorder<higtBorder)
            {
                if (lowBorder % 17 == 0)
                { 
                    result = $"{lowBorder},";
                    resultString += result;                   
                }
              
                lowBorder++;

            }

            Console.WriteLine(resultString);
        }
    }
}
