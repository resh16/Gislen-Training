using System;

public abstract class Asset
{
    abstract public void configuration();

    public void Warranty(string no_of_year)
    {
        Console.WriteLine("The Warrent period is :" + no_of_year);
    }
}

public class Computer : Asset
{
    string Storage = "";
    string Processor = "";

    public Computer(string storage,string processor)
    {
        Storage = storage;
        Processor = processor;

       
    }

    public override void configuration()

    {
        Console.WriteLine("Configuration of Computer: ");
        Console.WriteLine("The Storage of the Computer is : " + Storage);
        Console.WriteLine("The processor of the Computer is : " + Processor);
    }

}

public class Laptop : Asset
{
    string RAM_Memory = "";
    string Battery = "";
    string Processor = "";

    public Laptop(string RAM_Memory, string battery, string processor)
    {
        this.RAM_Memory = RAM_Memory;
        this.Battery = battery;
        this.Processor = processor;


    }

    public override void configuration()

    {
        Console.WriteLine("");
        Console.WriteLine("Configuration of Laptop: ");
        Console.WriteLine("The RAM-Memory of the Laptop is : " + RAM_Memory);
        Console.WriteLine("The Battery level of the Laptop is : " + Battery);
        Console.WriteLine("The processor of the Laptop is : " + Processor);
    }

}

public static class EnumerationExample
{
    public enum ConnectionType { Wired, Bluetooth };

}

public class HeadPhones: Asset
{
    

    string  WaterResistent= "";
    string Battery = "";
    EnumerationExample.ConnectionType ConnectType;

    

    public HeadPhones(string water_resistent, EnumerationExample.ConnectionType ConnectType, string battery = "")

    {
        this.WaterResistent = water_resistent;
        this.Battery = battery;
        this.ConnectType = ConnectType;
    }

    
   

    public override void configuration()

    {
        Console.WriteLine("");
        Console.WriteLine("Configuration of HeadPhones: ");
        Console.WriteLine("Is it Water resistent? : " + WaterResistent);
        Console.WriteLine("The Connection type of HeadPhone is: " + ConnectType);
        
        if(ConnectType == EnumerationExample.ConnectionType.Bluetooth)
        {
            Console.WriteLine("The Battery level of the HeadPhones is : " + Battery);


        }






    }

}

public class Mouse : Asset
{
    string ConnectionType = "";
    

    public Mouse(string connectionType)
    {
        this.ConnectionType = connectionType;
    }

    public override void configuration()

    {
        Console.WriteLine("");
        Console.WriteLine("Configuration of Mouse: ");
        Console.WriteLine("The ConnectionType of the Mouse is : " + ConnectionType);
       
    }

}

public class DocStation : Asset
{
    int No_Of_Ports = 0;
    

    public DocStation(int no_of_ports)
    {
        this.No_Of_Ports = no_of_ports;
        


    }

    public override void configuration()

    {
        Console.WriteLine("");
        Console.WriteLine("Configuration of DocStation: ");
        Console.WriteLine("No of Ports in the DocStation is : " + No_Of_Ports);
       
    }

}
