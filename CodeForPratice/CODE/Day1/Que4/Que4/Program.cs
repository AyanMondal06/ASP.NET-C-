/*
 A class has an integer data member 'i' and a
 function named 'printNum' to print the value
 of 'i'. Its subclass also has an integer data
 member 'j' and a function named 'printNum'
 to print the value of 'j'. Now call the
 function 'printNum' by this object.
*/

using System;

class containingI
{
    int i=10;

    public virtual void printNum()
    {
        Console.WriteLine("This is class of I " + i );
    }
}

class containingJ:containingI
{
    int j = 20;

    public override void printNum()
    {
        Console.WriteLine("This is class of J " + j);
        base.printNum();
    }
}
class Questin1
{
    static void Main()
    {
        containingI obj1 = new containingJ();
        obj1.printNum();
    }
}