using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //public string name="Robin Hood";
            Book book = new Book();
            book .name = "Robin Hood";
            book .costPrice = 5;
            book .saledPrice = 9;
            book .authorName = "J.Walker";
            book .pageCount = 217;
            book .discountPercent = 5;
            book.GetInto();

        }
        internal class Book
        {
            //1.fields
            public string name;
            public int costPrice ; //default deyeri bu hissede veririk (15ci setir )
            public int saledPrice;
            public string authorName;
            public int pageCount;
            public int discountPercent;


            public void GetInto()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"CostPrice: {costPrice}");
                Console.WriteLine($"SaledPrice: {saledPrice}");
                Console.WriteLine($"AuthorName: { authorName}" );
                Console.WriteLine($"PageCount:{ pageCount}" );
                Console.WriteLine($"DiscountPercent:{discountPercent }" );

            }


        }
    }
}
