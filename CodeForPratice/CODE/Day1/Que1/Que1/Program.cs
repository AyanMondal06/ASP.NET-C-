/*
 * Write c# Program that receives the following information from a set of students:
Student Id:
Student Name:
Course Name:
Date of Birth:
The application should also display the information of all the students once the data is
Entered.
*/
using System;

class Student
{
    int studentId;
    String studentName;
    String courseName;
    String DOB;

    public Student(int studentId, String studentName, String courseName, String DOB)
    {
        this.studentId = studentId;
        this.studentName = studentName;
        this.courseName = courseName;
        this.DOB = DOB;
    }
    public void showStudent()
    {
        Console.WriteLine("\n" + studentId + " "
                              + studentName + " "
                              + courseName + " "
                              + DOB);
    }
}
class Questin1
{
    static void Main()
    {

        Student s1 = new Student(01, "A", "CSE", "12.12.12");
        Student s2 = new Student(02, "B", "ECE", "11.11.11");
        s1.showStudent();
        s2.showStudent();
    }
}