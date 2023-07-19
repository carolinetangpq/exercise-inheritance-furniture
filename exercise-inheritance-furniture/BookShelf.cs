using System;
using System.Collections.Generic;
using System.Text;
using exercise_inheritance_furniture;


namespace exercise_inheritance_furniture
{
    //child of Furniture
    public class BookShelf: Furniture
    {
        //Add  NoOfShelves  property
        int NoOfShelves { get; set; }

        //overrride the Accept method to read NoOfShelves property also
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Number of shelves this bookshelf have: ");
            NoOfShelves = int.Parse(Console.ReadLine());
        }

        //
        //override the Display method to include the display of NoOfShelves property also
        public override void Display()
        {
            base.Display();
            Console.WriteLine("No. of shelves: {0} ", NoOfShelves);
        }
    }
}

















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/













































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/
