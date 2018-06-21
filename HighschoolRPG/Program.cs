using System;

namespace HighschoolRPG
{
    class Program
    {
        static void Main()
        {
            bool sOneFaint = false, sTwoFaint = false;
            Random rnd = new Random();
            Student newStudentOne = new Student( "AI_One", rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));
            Student newStudentTwo = new Student("AI_Two", rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));

            while( !sOneFaint && !sTwoFaint )
            {
                sTwoFaint = newStudentTwo.defend(newStudentOne.attack());
                sOneFaint = newStudentOne.defend(newStudentTwo.attack());
            }

            if(sTwoFaint == true)
            {
                Console.WriteLine("STUDENT TWO FAINTED");
            }

            if(sOneFaint == true)
            {
                Console.WriteLine("STUDENT ONE FAINTED");
            }
        }
    }
}