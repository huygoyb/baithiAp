using System;
using System.Runtime.InteropServices;

namespace BaiThiAP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimenstion of the cylinder");
            double Radius = 38.64;
            double Height = 22.48;
            Console.WriteLine("Radius:"+Radius);
            Console.WriteLine("Height:"+Height);
            double BaseArea = Radius * Radius * Math.PI;
            double LateralArea = 2 * Math.PI * Radius * Height;
            double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            double Volume = Math.PI * Radius * Radius * Height;


            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius:"+Radius, "Height:"+Height );
            Console.WriteLine("Base:" +BaseArea) ;
            Console.ReadLine();
        }
    }

   // class Cylinder
   // {
        
   // }
}