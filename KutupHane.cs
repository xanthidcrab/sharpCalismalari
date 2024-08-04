using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using System.Xml.Serialization;
public class Person{
    //Fields and Proplar
    public int Boy { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Kilo { get; set; }

    public void PrintIsim(Person person)
    {
        System.Console.WriteLine($" İsim:{person.Name} \n Soyisim:{person.SurName}\n Kilo:{person.Kilo}\n Boy:{person.Boy}");
    }
}
public class Worker:Person{
    public int CalismaSaati { get; set; }
    public int AyakkabiNumarasi { get; set; }
    public string Address { get; set; }
    public string Shift { get; set; }
    
    }
}