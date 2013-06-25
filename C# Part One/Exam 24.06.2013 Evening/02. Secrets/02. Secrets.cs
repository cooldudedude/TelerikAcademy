using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            if (number < 0)
            {
                number*= -1;
            }

            BigInteger originalNumber = number;

            BigInteger specialSum = 0;

            for (BigInteger i = 1; true; i++)
            {
                BigInteger tempNumber = number % 10;

                if (i % 2 != 0)
                {
                    specialSum = specialSum + tempNumber * i * i;
                }
                else
                {
                    specialSum = specialSum + tempNumber * tempNumber * i;
                }

                number = number / 10;

                if (number < 1 && number % 10 == 0)
                {
                    break;
                }
            }

            if (specialSum % 10 == 0)
            {
                Console.WriteLine(specialSum);
                Console.WriteLine("{0} has no secret alpha-sequence", originalNumber);
                return;
            }

            int alphaSequenceLength = (int) specialSum % 10;

            char[] alphaSequence = new char[alphaSequenceLength];

            BigInteger remainderBig = specialSum % 26 + 1;

                for (int i = 0; i < alphaSequenceLength; i++)
                {
                    alphaSequence[i] = (char)((remainderBig + 64 + i));
                    if (alphaSequence[i] > 90)
                    {
                        alphaSequence[i] = (char)(alphaSequence[i] - 26);
                    }
                }

                Console.WriteLine(specialSum);
                for (int i = 0; i < alphaSequenceLength; i++)
                {
                    Console.Write(alphaSequence[i]);
                }

            }
}