using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int t = 0;
                string[] Names = new string[6] {"Harpreet Kaur","Mandeep Singh","Gurjinder Singh","Manvir Singh", "Arshdeep Singh", "Gurpinderpal Singh"};
                string[] Letters = new string[6] { "A", "B", "C", "D", "E", "F" };
                for (int b = 0; b <= 6; t++)
                {
                    Names[b] = Names[b] + " " + Letters[t];
                }
                t++;
                for (int c = 4; c <= 7; c++)
                {
                    Names[c] = Names[c] + " " + Letters[t];
                }
                t++;
                for (int l = 8; l <= 11; l++)
                {
                    Names[l] = Names[l] + " " + Letters[];
                }
                t++;
                for (int m = 12; m <= 15; m++)
                {
                    Names[m] = Names[m] + " " + Letters[t];
                }

                for (int i = 0; i < Names.Length; i++)
                {
                    Console.WriteLine(Names[i]);
                }


                Console.ReadLine();
            }
        }
    }
}

