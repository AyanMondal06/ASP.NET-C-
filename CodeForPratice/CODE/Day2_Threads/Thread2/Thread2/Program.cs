/*2.
 Write a c# program that creates three threads. 
 First thread displays “Good Morning”  every one second, 
 the second thread displays “Hello” every two seconds and 
 the third  thread displays “Welcome”every three seconds 
  */

using System;
class HelloWorld
{
    static void Main()
    {
        Thread t1 = new Thread(PrintWord.PrintingMorning);
        Thread t2 = new Thread(PrintWord.PrintingHello);
        Thread t3 = new Thread(PrintWord.PrintingWelcome);
        Console.WriteLine("Program is running");

        t1.Name = "1";
        t2.Name = "2";
        t3.Name = "3";

        t1.Start();
        t2.Start();
        t3.Start();
    }
}

class PrintWord
{
    static public void PrintingMorning()
    {
        int i = 5;
        while (i > 0)
        {
            Console.WriteLine("This is "+ Thread.CurrentThread.Name +" saying : 'Good Morning'");
            Thread.Sleep(1000);
            i--;
        }
    }
    static public void PrintingHello()
    {
        int i = 5;
        while (i > 0)
        {
            Console.WriteLine("This is " + Thread.CurrentThread.Name + " saying: 'Hello'");
            Thread.Sleep(2000);
            i--;
        }
    }
    static public void PrintingWelcome()
    {
        int i = 5;
        while (i > 0)
        {
            Console.WriteLine("This is " + Thread.CurrentThread.Name + " saying : 'Welcome'");
            Thread.Sleep(3000);
            i--;
        }
    }
}
