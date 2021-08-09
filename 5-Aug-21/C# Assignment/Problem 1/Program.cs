using System;

class problem
{
    public static void Main()
    {
        Computer cs1 = new Computer("512GB", "i3");
        Laptop lp1 = new Laptop("8GB", "3Hrs", "i5");
        HeadPhones hp1 = new HeadPhones("Yes",EnumerationExample.ConnectionType.Bluetooth, "3hrs");
        HeadPhones hp2 = new HeadPhones("No",EnumerationExample.ConnectionType.Wired);

        Mouse m1 = new Mouse("Optical");
        DocStation ds1 = new DocStation(5);


        cs1.configuration();
        cs1.Warranty("3 years");

        lp1.configuration();
        lp1.Warranty("2 years");

        hp1.configuration();
        hp1.Warranty("6 months");

        hp2.configuration();
        hp2.Warranty("No Warranty");

        m1.configuration();
        m1.Warranty("3 months");

        ds1.configuration();
        ds1.Warranty("3 months");


        Console.ReadKey();
    }
}
