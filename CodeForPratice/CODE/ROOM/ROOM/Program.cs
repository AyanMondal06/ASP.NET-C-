/*Write a program to create a room class, the attributes of this class is
roomno, roomtype, roomrent . In this class the member
functions are setdata and displaydata. 
 */



using System;
using System.Runtime.CompilerServices;

class Room
{
    int roomNo;
    string roomType;
    int roomRent;

    public void  Setdata(int roomNo, string roomType, int roomRent)
    {
        this.roomNo = roomNo;
        this.roomType = roomType;
        this.roomRent = roomRent;
    }
    public void DisplayData()
    {
        Console.WriteLine("\n" + roomNo + " "
                              + roomType + " "
                              + roomRent
                              );
    }
}
class Questin1
{
    static void Main()
    {

        Room r1 = new Room();
        r1.Setdata(1,"free",200);
        r1.DisplayData();
    }
}