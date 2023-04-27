using System.Diagnostics;
using System.Xml.Linq;

namespace inheritance_furniture
{
    class Furniture
    {
       

        
        public int height;
        public int width;
        public string colour;
        public int qty;
        public int price;
        public int total;
        public void display()
        {
            double total = 0;
            double avg;
            int[] price = new int[qty];
            Console.WriteLine("Enter Price ");

            for (int i = 0; i < price.Length; i++)
            {
                Console.WriteLine($"Enter Price {i+1}");
                price[i] = Convert.ToInt16(Console.ReadLine());

            }
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Colour: {colour}");
            Console.WriteLine($"Quantity: {qty}");

            for (int j = 0; j <qty; j++)
            {
                total = total +price[j];
            }
            Console.WriteLine($"Total Price: {total}");
            avg = total /qty;
            Console.WriteLine($"avg:{avg}");
            


        }
    }
    class BookShelf : Furniture
    {
      
        public void getselve()
        {
            Console.WriteLine("Enter No. of Shelves");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"No. Of Shelves: {num}");
        }
    }
    class DiningTable: Furniture
    {
       
        public void getlegs()
        {
            Console.WriteLine("No. Of legs");
            int legs = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"No. Of legs: {legs}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter DiningTable or BookShelf ");
            
            string select = Convert.ToString(Console.ReadLine());
            select.ToLower();
                
            if (select == "DiningTable")
            {
                DiningTable shop = new DiningTable();
                Console.WriteLine("Enter height");
                shop.height = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter width");
                shop.width = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter colour");
                shop.colour = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter quantity");
                shop.qty = Convert.ToInt16(Console.ReadLine());
                shop.display();
                shop.getlegs();
            }
            else
            {
                BookShelf shop = new BookShelf();
                Console.WriteLine("Enter height");
                shop.height = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter width");
                shop.width = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter colour");
                shop.colour = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter quantity");
                shop.qty = Convert.ToInt16(Console.ReadLine());
                shop.display();
                shop.getselve();

            }


                

        }
    }
}