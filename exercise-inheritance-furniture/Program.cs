using System;
using System.Dynamic;

namespace exercise_inheritance_furniture
{
    public class Program
    {

        static void Main(string[] args)
        {
            //create an array  of objects in furniture type
            Furniture[] furniture = new Furniture[2] ;

            //create program class object
            Program p = new Program();
            // call AddToStock(<furniture array>);
            p.AddToStock(furniture);
            //call ShowStockDetails(<furniture array>);
            p.ShowStockDetails(furniture);
            p.ShowStockDetails(furniture);
            // call TotalStockValue(<furniture array>) and display output 
            p.TotalStockValue(furniture);

        }
        public int AddToStock(Furniture[] items)
        {

            //accept the choice from user for type of furniture(BookShelf  or DiningTable)
            // and according to the choice create necessary sub class object and store data
            //continue the process up to the size of array

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Type of furniture \n 1.Bookshelf \n 2.Diningtable");
                Furniture newFurniture;

                // input
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {

                    newFurniture = new BookShelf();

                }
                else
                {
                    newFurniture = new DiningTable();
                }

                newFurniture.Accept(); 
                Console.WriteLine("--------------------------------------");
                // store items into array
                items[i] = newFurniture;

            }

            // return <size of array>;
            return items.Length;
        }
        public double TotalStockValue(Furniture[] items)
        {
            double stockValue = default;
            //calculate total stock value i.e qty * price of each item
            for (int i = 0; i < items.Length; i++)
            {
                stockValue += (items[i].qty * items[i].price);
            }

            Console.WriteLine("Total Stock value: {0} ", stockValue);
            Console.WriteLine("--------------------------------------------------");
            return stockValue;
        }
        public int ShowStockDetails(Furniture[] items)
        {
            //call display method from all object to display the stock 

            foreach (Furniture item in items)
            {
                item.Display();
            }

            //return <size of array>;
            return items.Length;

        }
    }
}
