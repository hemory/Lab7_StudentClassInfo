using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GC_ClassroomLibrary;

namespace CreateAClassroom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string toContine;

                {
                    Classroom expNet = new Classroom();

                    {
                        Console.WriteLine("Welcome to our .Net class! \n The class has " + expNet.students.Length + " students");
                        Console.WriteLine("Which student would you like to learn more about? Enter a number 1-4.");

                        int userAnswer = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Student " + userAnswer + " is " + expNet.students[userAnswer].Name +
                                " What more would you like to know about " + expNet.students[userAnswer].Name + " ? ");

                            Console.WriteLine("Please enter hometown or favorite food");

                            string answerIsHomeTownORFood = Console.ReadLine();
                            if (answerIsHomeTownORFood == "hometown")
                            {
                                Console.WriteLine(expNet.students[userAnswer].Name + "'s hometown is " + expNet.students[userAnswer].Hometown);
                            }

                            if (answerIsHomeTownORFood == "favorite food")
                            {
                                Console.WriteLine(expNet.students[userAnswer].Name + "'s favorite food is " + expNet.students[userAnswer].FavoriteFood);
                            }

                            Console.WriteLine("Would you like to know more? Enter y or n. ");
                            toContine = Console.ReadLine();
                        } while (toContine == "y");
                    }
                }
        }

            catch (FormatException message)
            {
                Console.WriteLine(message);
                Console.ReadLine();
            }
}

        internal class m_students
        {
        }
    }
}
