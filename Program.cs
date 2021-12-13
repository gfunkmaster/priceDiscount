using System;

namespace Price
{
    class Price
    {
        static void Main(string[] args)
        {

            string inData;
            Console.Write("Amount? ");
            inData = Console.ReadLine();

            int amount = int.Parse(inData);
            Console.Write("Price per piece? ");
            inData = Console.ReadLine();

            double pPiece = double.Parse(inData);
            double price = pPiece * amount;
            double disCount;

            if(price > 5000)
            {
                disCount = price * 0.15;
                price = price - disCount; 
            } else if(price > 1000)
            {
                disCount = price * 0.15;
                price = price - disCount;
            } else
            {
                Console.WriteLine("No discount, sorry");
            }

            Console.WriteLine("Total price: " + price);

        }
    }
}

