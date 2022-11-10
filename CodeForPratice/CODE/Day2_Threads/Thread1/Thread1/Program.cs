using System;
class HelloWorld
{
    static void Main()
    {
        Thread t1 = new Thread(PrintFruitName.PrintingFruit);
        Console.WriteLine("Program is running");
        t1.Start();
    }
}

class PrintFruitName
{
    static public void PrintingFruit()
    {
        int i = 5;
        while (true)
        {
            Console.WriteLine("This is not a Banana but a HaraFruit");
            Thread.Sleep(1000);
            i--;
        }
    }
}