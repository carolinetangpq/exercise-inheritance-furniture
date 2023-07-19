using System;
using System.Collections.Generic;
using System.Text;
namespace exercise_inheritance_furniture
{
    public class Furniture
    {
        //Add below mentioned Properties 
        //Height(int),Width(int),Color(string),Price(double),Qty(int)
        public int height { get; set; }
        public int width { get; set; }
        public string color { get; set; }
        public double price { get; set; }
        public int qty { get; set; }

        public virtual void Accept()
        {
            //code to accept height,width ,color,price and qty
            Console.WriteLine("Height: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Width: ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Color: ");
            color = Console.ReadLine();
            Console.WriteLine("Price: ");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantity: ");
            qty = int.Parse(Console.ReadLine());

        }
        public virtual void Display()
        {
            //code to display height width ,price,qty and color
            Console.WriteLine("The properties are: {0}, {1}, {2}, {3}, {4}", height, width, color, price, qty);

        }
    }
}




/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:24:45 PM 
*/



















