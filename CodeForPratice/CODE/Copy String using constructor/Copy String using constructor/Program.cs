/*
 * Develop a program to illustrate a copy
 * constructor so that a string may be 
 * duplicated into another 
 * variable either by assignment or copying.
 */

using System;
class CopyStringUsingConstructor
{
    private string stringToCopy;

    public CopyStringUsingConstructor(string stringToCopy )
    {
        this.stringToCopy = stringToCopy;

    }
    public  CopyStringUsingConstructor(CopyStringUsingConstructor copy)
    {
        stringToCopy=copy.stringToCopy;
    }
    public string Data
    {

        get
        {
            return "We are having a -" + stringToCopy;
                 
        }
    }


}

class CopyConstructor
{
    static void Main()
    {
        CopyStringUsingConstructor c1 = new CopyStringUsingConstructor("Lab season");
        CopyStringUsingConstructor c2 = new CopyStringUsingConstructor(c1);
        Console.WriteLine(c1.Data);
    }
}