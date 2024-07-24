using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("13725 White Meadow Ct","Johnson City","TN","37604","USA");
        Address address2 = new Address("123 Main St","Chicago","IL","88543","USA");
        Address address3 = new Address("3452 Ensign Dr","Kansas City","MO","64153","USA");

        Lecture lecture = new Lecture("Why you Should Attend Church","Find all the reasons to attend church","07/24/2024","08:00AM",address1,"Shaun Marquis",400);
        Reception reception = new Reception("Marquis Wedding","The Marriage of Shaun and Michelle Marquis","04/23/2024","3:30PM",address2);
        reception.AddRsvpName("Shaun Marquis");
        reception.AddRsvpName("Michelle Marquis");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Marquis Fun and Games","Come have fun at the Marquis home with lawn games","05/12/2024","12:00PM",address3,"Thunder Storms");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
    }
}