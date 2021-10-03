using System;

namespace GeometryExample
{
    internal class Cylinder
    {
        static double Radius;
        static double Height;
        static double BaseArea;
        static double LateralArea;
        static double TotalArea;
        static double Volume;
         static void ProcessCylinder()
        {
            

            Console.WriteLine("Enter the dimension of the cylinder");
            Console.Write("Radius: ");
            Radius = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());
            
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
            
            
        }

         static void ResultCylinder()
         {
             Console.WriteLine("\nCylinder Characteristics");
             Console.WriteLine("Radius:  {0}", Radius);
             Console.WriteLine("Height:  {0}", Height);
             Console.WriteLine("Base:    {0:F}", BaseArea);
             Console.WriteLine("Lateral: {0:F}", LateralArea);
             Console.WriteLine("Total:   {0:F}", TotalArea);
             Console.WriteLine("Volume:  {0:F}", Volume);
         }


         

         public static void Main(string[] args)
        {
            ProcessCylinder();
            ResultCylinder();
            Console.WriteLine();
        }
    }
}