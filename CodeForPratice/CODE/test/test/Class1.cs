using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    /*
C# Program Create a class student with a data
member name, age, marks of English, marks of
math, marks of science, total marks, obtained
marks and percentage provide member 
functions CalculateTotalMarks and 
CalculatePercentage to calculate marks and 
percentage
*/


    using System;
    class Student
    {
        String name;
        int stuAge;
        int engScore;
        int mathScore;
        int scienceScore;
        int Total = 0;
        float Avg;

        public void readData()
        {
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            stuAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your English score : ");
            engScore = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Math Score : ");
            mathScore = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Sciencce Score : ");
            scienceScore = Convert.ToInt32(Console.ReadLine());

        }
        public void calculateAvarage()
        {
            Total = (engScore + mathScore + scienceScore);
        }
        public void calculatePercentage()
        {
            Avg = Total / 3;
        }
        public void showData()
        {
            Console.WriteLine("Name of the student: " + name + "\n" +
            "Age of student: " + stuAge + "\n" +
            "Total " + Total + "\n" +
            "Percentage " + Avg);
        }

    }

    class Question2
    {
        static void Main()
        {
            Student s = new Student();
            s.readData();
            s.calculateAvarage();
            s.calculatePercentage();
            s.showData();

        }
    }
}
