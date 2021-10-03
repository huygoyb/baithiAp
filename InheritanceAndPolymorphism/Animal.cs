using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace InheritanceAndPolymorphism
{
     class lion
    {
        public lion(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public void Show()
        {
            Console.WriteLine("Name: {0},Weight: {1}", name, weight);
        }
        private string name;
        private int weight;
        
    }

     class Tiger : lion
     {
         public Tiger(string name, int weight)
             :base(name, weight) 
         {
             
         }

         public new void Animal()
         {
             base.Show();
         }

     }

     class Animal
     {
         public static void Main()
         {
             lion l = new lion("tiger", 100);
             l.Show();
             Tiger tg = new Tiger("Lion", 200);
             tg.Show();
         }
     }
}