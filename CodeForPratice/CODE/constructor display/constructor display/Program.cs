/*Write a program create a class ‘simpleobject‘. Using constructor display
the message. 
 */
using System;
class SimpleObjet
{
    int a;


    public SimpleObjet(int a)
    {
        Console.WriteLine("this is a construcrtor "+ a);

    }
}

class CopyConstructor
{
    static void Main()
    {
        SimpleObjet obj1 = new SimpleObjet(10);
    }
}