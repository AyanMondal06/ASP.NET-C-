/*Write a c# program that implements a
    multi-thread application that has three threads. 
    First thread generates random integer every 1 second 
    and if the value is even, second thread computes the square of the number and prints. 
    If the value is odd, the third thread will print the value of cube of the number.*/


using System;

class HelloWorld
{
    static void Main()
    {
        Thread Generator = new Thread(PrintSum.GenerateNumber);


        Console.WriteLine("Program is running");
        
        Generator.Name = "Generator";
        Generator.Start();
    }
}

class PrintSum
{


    static public void GenerateNumber()
    {
        int randomNumberStore;

        
        


        Random randomNumber = new Random();
        while(true)
        {
            randomNumberStore = randomNumber.Next(10);
            Console.WriteLine("This is " + Thread.CurrentThread.Name + " and Your Random Number is : "+randomNumberStore);
            
            if (randomNumberStore % 2 == 0)
            {
                Thread SquarePrinterThread = new Thread(SquareNumber);
                SquarePrinterThread.Start(randomNumberStore);
               
            }
            else
            {
                Thread CubePrinterThread = new Thread(CubeNumber);
                CubePrinterThread.Start(randomNumberStore);
            }
         Thread.Sleep(1000);
        }
        
    }

    static public void SquareNumber (object randomNumberStore)
    {
        int num= (int)randomNumberStore;
       
        Console.WriteLine("This the the Square of " + num + " = " + (num * num));
    }
    static public void CubeNumber(object randomNumberStore)
    {
        int num = (int)randomNumberStore;
        Console.WriteLine("This the the Cube of " + num + " = " + ((num * num )* num));
    }
}
