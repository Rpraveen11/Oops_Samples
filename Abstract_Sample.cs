using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts

{    // Implementing abstract method
    abstract class Vehicle //abstract  class 
    {
      
        public abstract void display();

    }

    internal class Bike : Vehicle // abstaract class inherits Bike class 
    {
        String ? name;

        public override void display()
        {
            Console.WriteLine("Enter Your Vehicle Name :");
            name=Console.ReadLine();
            Console.WriteLine("name of  Vehicle is :" + name);
        }
    
        static void Main(string[] args)
        {
            Bike owner= new Bike(); // create object
            owner.display();
            

        }

    }
}
    

