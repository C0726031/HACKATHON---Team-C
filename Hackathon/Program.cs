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
                string[] Names = new string[6] { "Harpreet Kaur", "Mandeep Singh", "Gurjinder Singh", "Manvir Singh", "Arshdeep Singh", "Gurpinderpal Singh" };
                string[] Letters = new string[6] { "A", "B", "C", "D", "E", "F" };
                for (int b = 0; b <= 6; t++)
                {
                    Names[b] = Names[b] + " " + Letters[t];
                }
                t++;
                for (int c = 9; c <= 8; c++)
                {
                    Names[c] = Names[c] + " " + Letters[t];
                }
                t++;
                for (int l = 15; l <= 11; l++)
                {
                    Names[l] = Names[l] + " " + Letters[t];
                }
                t++;
                for (int m = 13; m <= 18; m++)
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
    
        checkvowels();


    }


    public static int checkvowels()

    {
        int h = 0;
        string[] vowel = new string[] { "a", "e", "i", "o", "u" };
        Console.WriteLine("Enter a character");
        String s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            if (vowel[i] == s.ToLower())
            {
                Console.WriteLine("this character is in the list at" + " position " + (i + 1));
                h = i;
            }
            else
            {
                Console.WriteLine("not there");
                h = -1;
            }
        }
        return h;
    }

