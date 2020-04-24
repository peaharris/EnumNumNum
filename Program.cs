using System;
using System.Collections.Generic;


namespace Demo
{
    class MainClass
    {
        //This program demonstrates how we can utilize enumerations or enums

        public static void Main(string[] args)
        {
            //D A Y S  O F  T H E  W E E K
            Days today = Days.Saturday;  //this creates a new day called today, and setting it equal to the Day's Saturday
            Console.WriteLine(today); //this prints off Saturday


            //For loop, initializer is set to monday, condition is that day must be less than or equal to sunday,
            //and we are incrementing the day by 1
            for (Days day = Days.Monday; day <= Days.Sunday; day++) 
            {
                Console.Write(day);    //This is printing off the day
                Console.WriteLine((int)day);  //This is printing off the day's integer value, because enums are stored as ints

            }


            //M I L I T A R Y  R A N K S
            MilitaryRank johnSmith = MilitaryRank.E1; //This is creating a person johnSmith who is an E1
            Console.WriteLine(johnSmith);  //This prints off johnSmith's rank

            johnSmith++; //this increments the rank by 1, giving johnSmith a promotion
            Console.WriteLine(johnSmith);  //prints off johnSmith's new rank
        }
    }
}
