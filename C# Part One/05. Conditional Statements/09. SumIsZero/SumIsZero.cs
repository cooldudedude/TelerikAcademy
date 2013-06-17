using System;


class SubSet
{
    static void Main()
    {
        Console.Write("How many numbers do you want to enter?  ");
        int intCounter = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[intCounter];

        for (int i = 0; i < intCounter; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int counter = 0;

        for (int i = 0; i < intCounter; i++)
        {
            for (int j = i + 1; j < intCounter; j++)
            {
                sum = numbersArray[i] + numbersArray[j];
                if (sum == 0)
                {
                    counter++;
                }
                //Console.WriteLine("{0} + {1} = {2}", i, j, sum);
                for (int k = j + 1; k < intCounter; k++)
                {
                    sum = sum + numbersArray[k];
                    if (sum == 0)
                    {
                        counter++;
                    }

                    for (int l = k + 1; l < intCounter; l++)
                    {
                        sum = sum + numbersArray[l];
                        if (sum == 0)
                        {
                            counter++;
                        }

                        for (int m = l + 1; m < intCounter; m++)
                        {
                            sum = sum + numbersArray[m];
                            if (sum == 0)
                            {
                                counter++;
                            }

                        }
                    }
                }
            }
        }
        Console.WriteLine("There are {0} sums of subsets that are equal to Zero!", counter);
    }
}