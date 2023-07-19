using System;
using System.Collections.Generic;
using System.Text;
using exercise_inheritance_furniture;

namespace exercise_inheritance_furniture
{
    //child of furniture
    public class DiningTable: Furniture
    {
        //Add  NoOfLegs  property
        int NoOfLegs { get; set; }
        //overrride the Accept method to read NoOfLegs property also
        public override void Accept()
        {
            //base.Accept();
            Console.WriteLine("Number of legs: ");
            NoOfLegs = int.Parse(Console.ReadLine());
        }

        //override the Display method to include the display of NoOfLegs property also
        public override void Display()
        {
            //base.Display();
            Console.WriteLine("No of Legs: " + NoOfLegs);
        }
    }
}


















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:27:28 PM 
*/
