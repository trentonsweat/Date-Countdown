using System;



namespace DateCountDown

{

    class MainClass

    {

        public static void Main(string[] args)

        {

            //Declare the variables for the dates in question.

            DateTime FirstDateInQuestion, SecondDateInQuestion;



            Console.WriteLine("Hello I am programmed to assist you in determing the remaining time between one date to another in (Days/Hours/Minutes)!");



            //Provide initial values for the 1st date.

            Console.WriteLine("Please enter in a date (year/month/day)!");

            FirstDateInQuestion = new DateTime();

            FirstDateInQuestion = Convert.ToDateTime(Console.ReadLine());



            //Provide initial values for the 2nd date.

            Console.WriteLine("Please enter in another date!");

            SecondDateInQuestion = new DateTime();

            SecondDateInQuestion = Convert.ToDateTime(Console.ReadLine());



            //Exception to catch if initial date entered occurs after the second.

            if (FirstDateInQuestion > SecondDateInQuestion)

            {

                Console.WriteLine("Sorry the 1st date must occur before 2nd!");

            }

            else

            {

                TimeSpan TimeSpanUntil = SecondDateInQuestion.Subtract(FirstDateInQuestion);

                Console.WriteLine("Your currently have {0} day(s) {1} hour(s) and {2} minute(s) until then", TimeSpanUntil.TotalDays, TimeSpanUntil.TotalHours, TimeSpanUntil.TotalMinutes);

                Console.WriteLine("Thank you for using our services!");





            }





        }

    }

}