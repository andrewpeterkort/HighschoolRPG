using System;

namespace HighschoolRPG
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            Student newStudentOne = new Student( "AI_One", rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));
            Student newStudentTwo = new Student("AI_Two", rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));

            newStudentTwo.defend(newStudentOne.attack());
            newStudentOne.defend(newStudentTwo.attack());

        }
    }
}