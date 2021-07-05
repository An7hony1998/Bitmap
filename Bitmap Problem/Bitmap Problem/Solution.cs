using System;
using System.Collections.Generic;

   public static class Solution
    {
        static void Main()
        {
                int numberOfCases;
            string d = Console.ReadLine();
                    numberOfCases = Convert.ToInt32(d);
            for (int a = 0; a < numberOfCases; a++)
            {
                
                List<int[]> BitmapLines = new List<int[]>();
                List<int[]> BitmapResult = new List<int[]>();
                List<int> intResult = new List<int>();
                string[] stringArray = Console.ReadLine().Split(' ');
                for (int i = 0; i < stringArray.Length; i++)
                {
                    int num;
                    if (!string.IsNullOrEmpty(stringArray[i].Replace(" ", "")))
                    {
                        if (int.TryParse(stringArray[i], out num))
                        {
                            intResult.Add(num);
                        }
                    }
                }
               int[] BitmapSize = intResult.ToArray();
                for (int i = 0; i < BitmapSize[0]; i++)
                {
                    int[] Aint = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)Char.GetNumericValue(c));
                    BitmapLines.Add(Aint);
                }
                for (int k = 0; k < BitmapLines.Count; k++)
                {
                    List<int> LineResult = new List<int>();
                    for (int j = 0; j < BitmapSize[1]; j++)
                    {
                        if (BitmapLines[k][j] == 1)
                            LineResult.Add(0);
                        else
                        {
                            int iterations = 0;
                            int reverseIterations = 0;
                            if (j < BitmapSize[1])
                                for (int i = j + 1; i < BitmapSize[1]; i++)
                                {
                                    iterations++;
                                    if (BitmapLines[k][i] == 1)
                                        break;
                                }
                            if (j > 0)
                                for (int i = j - 1; i > 0; i--)
                                {
                                    reverseIterations++;
                                    if (BitmapLines[k][i] == 1)
                                        break;
                                }

                            if (iterations < reverseIterations && iterations != 0 || reverseIterations == 0)
                                LineResult.Add(iterations);
                            else
                                LineResult.Add(reverseIterations);
                        }
                    }
                    BitmapResult.Add(LineResult.ToArray());
                    for (int s = 0; s < BitmapResult[BitmapResult.Count - 1].Length; s++)
                    {
                        Console.Write(BitmapResult[BitmapResult.Count - 1][s]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
