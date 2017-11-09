using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustQ2
{
    internal class Program
    {
        private static void Main()
        {
            int lineCount = File.ReadLines("survey.csv").Count();
            string[,] playerStrings = new string[lineCount, 3];
            int[] playerAges = new int[lineCount];
            int[] ageTotals = new int[5];
            int[,] genderCounts = new int[5, 2];
            Console.Clear();
            ReadFile(playerStrings);
            ConvertInt(lineCount, playerAges, playerStrings);
            GetCounts(lineCount, playerAges, ageTotals, playerStrings, genderCounts);
            WriteReport(ageTotals, genderCounts);
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ReadFile(string[,] playerStrings)
        {
            int x = 0;
            foreach (string line in File.ReadLines("survey.csv"))
            {
                string[] values = line.Split(',');
                playerStrings[x, 0] = values[0];
                playerStrings[x, 1] = values[1];
                playerStrings[x, 2] = values[2];
                x++;

            }
        }

        private static void ConvertInt(int lineCount, int[] playerAges, string[,] playerStrings)
        {
            for (int x = 0; x < lineCount; x++)
            {
                playerAges[x] = Convert.ToInt32(playerStrings[x, 1]);
            }
        }

        private static void GetCounts(int lineCount, int[] playerAges, int[] ageTotals, string[,] playerStrings, int[,] genderCounts)
        {
            for (int x = 0; x < lineCount; x++)
            {
                if (playerAges[x] < 20)
                {
                    ageTotals[0]++;
                    if (playerStrings[x, 2] == "male")
                    {
                        genderCounts[0, 0]++;
                    }
                    else
                    {
                        genderCounts[0, 1]++;
                    }
                }

                else if (playerAges[x] >= 20 && playerAges[x] <= 29)
                {
                    ageTotals[1]++;
                    if (playerStrings[x, 2] == "male")
                    {
                        genderCounts[1, 0]++;
                    }
                    else
                    {
                        genderCounts[1, 1]++;
                    }
                }

                else if (playerAges[x] >= 30 && playerAges[x] <= 39)
                {
                    ageTotals[2]++;
                    if (playerStrings[x, 2] == "male")
                    {
                        genderCounts[2, 0]++;
                    }
                    else
                    {
                        genderCounts[2, 1]++;
                    }
                }

                else if (playerAges[x] >= 40 && playerAges[x] <= 49)
                {
                    ageTotals[3]++;
                    if (playerStrings[x, 2] == "male")
                    {
                        genderCounts[3, 0]++;
                    }
                    else
                    {
                        genderCounts[3, 1]++;
                    }
                }

                else if (playerAges[x] >= 50)
                {
                    ageTotals[4]++;
                    if (playerStrings[x, 2] == "male")
                    {
                        genderCounts[4, 0]++;
                    }
                    else
                    {
                        genderCounts[4, 1]++;
                    }
                }
            }
        }

        private static int GetTotalGenderCounts(int gender, int[] ageTotals, int[,] genderCounts)
        {
            int genderTotal = 0;
            for (int x = 0; x < ageTotals.Length; x++)
            {
                genderTotal += genderCounts[x, gender];
            }
            return genderTotal;
        }

        private static void WriteReport(int[] ageTotals, int[,] genderCounts)
        {
            string[] ageRanges = { "Under 20", "20-29", "30-39", "40-49", "50+" };
            const string tableLayout = "{0,-15}{1,-15}{2,-10}{3,-10}";
            Console.WriteLine(tableLayout, "Age Group", "Total Count", "Male", "Female");
            Console.WriteLine();
            for (int x = 0; x < ageRanges.Length; x++)
            {
                Console.WriteLine(tableLayout, ageRanges[x], ageTotals[x], genderCounts[x, 0], genderCounts[x, 1]);
            }
            Console.WriteLine();
            int maleTotal = GetTotalGenderCounts(0, ageTotals, genderCounts);
            int femaleTotal = GetTotalGenderCounts(1, ageTotals, genderCounts);
            Console.WriteLine(tableLayout, "Totals", ageTotals.Sum(), maleTotal, femaleTotal);
            Console.WriteLine();
            Console.WriteLine("Biggest age category: " + ageRanges[ageTotals.ToList().IndexOf(ageTotals.Max())]);
        }
    }
}
