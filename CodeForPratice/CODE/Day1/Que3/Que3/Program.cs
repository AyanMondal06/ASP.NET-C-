/*
Create a class to print the area of a square
and a rectangle. The class has two functions 
with the same name but different number of
parameters. The function for printing the 
area of rectangle has two parameters which 
are its length and breadth respectively while
the other function for printing the area of 
square has one parameter which is the side
of the square.
*/


using System;
using System.ComponentModel.DataAnnotations;

class CalculateArea
{
    double totalArea;

    public void Area(int length,int breadth)
    {
        totalArea = length*breadth;
        Console.WriteLine("Area of Rectange is : " +totalArea);
    }
    public void  Area(int side)
    {
        totalArea = side*side;
        Console.WriteLine("Area of Square is : " + totalArea);
    }

}

class Question2
{
    static void Main()
    {
        CalculateArea a1 = new CalculateArea();
        a1.Area(4);
        a1.Area(2, 4);

    }
}