using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        
        
        Menu main = new();
        main.LoadMenu([new BreathingActivity(), new ReflectingActivity(), new ListingActivity(), new Quit()]);
        main.ShowMenu(true);
    
    }
}