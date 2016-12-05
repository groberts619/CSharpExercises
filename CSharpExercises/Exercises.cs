using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return $"Hello {name}!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int val1, int val2)
        {
            int Sum = val1 + val2;
            return Sum;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal val1, decimal val2)
        {
            decimal Divide = val1 / val2;
            return Divide;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            string[] firstName = fullName.Split(' ');
            return firstName[0];
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string name)
        {
            char[] someArray = name.ToCharArray();
            string reverseName = "";
            for (int i = someArray.Length - 1; i >= 0; --i)
            {
                reverseName += someArray[i];
            }

            return reverseName;
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string name)
        {
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable(int number)
        {
            // Create the empty "timesTable" string variable to hold the times table.
            string timesTable = "";
            // Now, create a loop to iterate over the 9th multiplication, all the way to, but not including 10.
            for (int i = 1; i <= 9; i++)
            {
                timesTable += number + " * " + i + " = " + (number * i) + "\r\n";
            }
            timesTable += number + " * " + 10 + " = " + (number * 10);
            return timesTable;
        }
        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            double fahrenheit = kelvin * 9 / 5 - 459.67;
            return fahrenheit = Math.Round(fahrenheit, 2);
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] val1)
        {
            double sum = 0;
            foreach (int number in val1)
            {
                sum += number;
            }
            sum /= val1.Length;
            return sum;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] val1)
        {
            return val1.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
         public static string  DrawTriangle(int number, int width)
        {
            string someString = "";
            for (var i = width; i >= 0; i--)
            {
                for (var x = i; x >= 1; x--)
                {
                    someString += number.ToString();
                }
                if (i >= 2)
                {
                    someString += "\r\n";
                }
            }
            return someString;
        }
        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double miles, int hours, int minutes, int seconds)
            {
            int hoursInSeconds = (hours * 3600);
            int minutesInSeconds = (minutes * 60);
            double totalSeconds = hoursInSeconds + minutesInSeconds + seconds;
            double roundedHours = (totalSeconds / 60 / 60);
            int milesPerHour = (int)Math.Round(miles / roundedHours);
            return $"{milesPerHour}MPH";
        }
        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char param)
        {
            if(param == 'a' || param == 'e' || param == 'i' || param == 'o' || param == 'u') 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char param)
        {
            if (param == 'a' || param == 'e' || param == 'i' || param == 'o' || param == 'u')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int n)
        {
            int count = 0;
            while (n > 1)
            {
                count++;
                if (n % 2 == 0)
                {
                    n /= 2; // n = n / 2
                }
                else
                {
                    n = n * 3 + 1;
                }
            }
            return count;
        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime obj)
        {

            DateTime[] next7Days = new DateTime[7];
            for (int i = 0; i < next7Days.Length; i++)
            {
                next7Days[i] = obj;
                obj = obj.AddDays(1);
            }
            return next7Days;

        }
        // 18. Create a method called IsInLeapYear that accepts an int representing a year and returns true if the year is a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int aYear)
        {
           
            if (aYear % 4 == 0 && (aYear % 100 != 0 || aYear % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double loanBal, double intRate, int termYrs, int payPer)
        {
            double payment = 0;
            double ratePer = (intRate / 100) / payPer;
            double periods = termYrs * payPer;
            payment = loanBal * (ratePer * Math.Pow(1 + ratePer, periods)) / (Math.Pow(1 + ratePer, periods) - 1);
            return (Math.Round(payment, 2));
        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */
        public static string DuckGoose(int input)
        {
            string output = "";
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output += "DuckGoose";
                }
                else if (i % 5 == 0)
                {
                    output += "Goose";
                }
                else if (i % 3 == 0)
                {
                    output += "Duck";
                }
                else
                {
                    output += i;
                }
                if (i < input)
                {
                    output += Environment.NewLine;
                }
            }
            return output;
        }
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}