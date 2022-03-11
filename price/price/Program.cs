using System;

namespace price
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            //book.name = "Robin Hood";
            //book.costPrice = 5;
            //book.saledPrice = 9;
            //book.authorName = "J.Walker";
            //book.pageCount = 217;
            book.discountPercent = 100;
            book.salePrice=200;
           // book.discountedprice = 20;
            book.GetDiscountedPrice();
        }
        internal class Book
        {
            //1.fields
            //public string name;
            //public int costPrice; //default deyeri bu hissede veririk (15ci setir )
            //public int saledPrice;
            //public string authorName;
            //public int pageCount;
            public int discountPercent;
            public int salePrice;
            public int discountedprice;
            public int price;




            public void GetDiscountedPrice()
            {
                //Console.WriteLine($"Name: {name}");
                //Console.WriteLine($"CostPrice: {costPrice}");
                //Console.WriteLine($"SaledPrice: {saledPrice}");
                //Console.WriteLine($"AuthorName: { authorName}");
                //Console.WriteLine($"PageCount:{ pageCount}");
                 price = (salePrice * discountPercent) / 100;
                discountedprice = salePrice - price;



               Console.WriteLine($"DiscountPercent:{discountPercent }");

            }
        }
    }
}
