using System;

class TrippleRorationOfDigids
{
    static void Main()
    {
        long k = long.Parse(Console.ReadLine());

        long remainder = 0;

        for (int i = 0; i < 3; i++)
        {
            remainder = k % 10;
            k = k / 10;

            string StringRemainder = remainder.ToString();
            string kString = k.ToString();

            string result = StringRemainder + kString;

            k = long.Parse(result);
        }

        Console.WriteLine(k);
    }
}
