    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int svar;
            string writetext1;
            int i=0;
            int J=0;

            File.Delete("svar.txt");
            String[] davs = 
            { 
                "Spørgsmål 1", "Svar mulighed 1", "Svar mulighed 2", "Svar mulighed 3", "Svar mulighed 4",
                "Spørgsmål 2", "Svar mulighed 1", "Svar mulighed 2", "Svar mulighed 3", "Svar mulighed 4",
                "Spørgsmål 3", "Svar mulighed 1", "Svar mulighed 2", "Svar mulighed 3", "Svar mulighed 4",
                "Spørgsmål 4", "Svar mulighed 1", "Svar mulighed 2", "Svar mulighed 3", "Svar mulighed 4",
                "Spørgsmål 5", "Svar mulighed 1", "Svar mulighed 2", "Svar mulighed 3", "Svar mulighed 4",
                "Spørgsmål 6", "Svar mulighed 1", "Svar mulighed 2", "Svar mulighed 3", "Svar mulighed 4",

            };


            while (true)
            {
                if (i >= 30)
                {
                    break;
                }
                Console.WriteLine(davs[0 + i]);
                Console.WriteLine(davs[1 + i]);
                Console.WriteLine(davs[2 + i]);
                Console.WriteLine(davs[3 + i]);
                Console.WriteLine(davs[4 + i]);

                _ = int.TryParse(Console.ReadLine(), out svar);
                
               
                if (svar+i==1+i)
                {
                    Console.WriteLine(davs[1+i]);
                    J++;
                    writetext1 = "" + J+" " + davs[1+i]+"\n";
                    File.AppendAllText("svar.txt", writetext1);
                    i++; i++; i++; i++; i++;
                    Console.Clear();
                    
                }

                if (svar+i == 2+i)
                {
                    Console.WriteLine(davs[2 + i]);
                    J++;
                    writetext1 = "" + J+ " " + davs[2 + i] + "\n";
                    File.AppendAllText("svar.txt", writetext1);
                    i++; i++; i++; i++; i++;
                    Console.Clear();
                    
                }

                if (svar+i == 3+i)
                {
                    Console.WriteLine(davs[3+i]);
                    J++;
                    writetext1 = "" + J+ " " + davs[3 + i] + "\n";
                    File.AppendAllText("svar.txt", writetext1);
                    i++; i++; i++; i++; i++;
                    Console.Clear();
                    
                }

                if (svar+i == 4+i)
                {
                    Console.WriteLine(davs[4 + i]);
                    J++;
                    writetext1 = "" + J + " " + davs[4 + i] + "\n";
                    File.AppendAllText("svar.txt", writetext1);
                    i++; i++; i++; i++; i++;
                    Console.Clear();
                    
                }

                




                if (svar > 4)
                {
                    Console.WriteLine("Du skal skrive et tal mellem 1-4");
                }
                if (svar < 0)
                {
                    Console.WriteLine("Du skal skrive et tal mellem 1-4");
                }



            }

            Console.WriteLine("Resultat");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");
            //Console.WriteLine("Spørgsmål 1:"); String readtext = File.ReadLines1("svar.txt"); Console.WriteLine(readtext);



            string line1 = File.ReadLines("svar.txt").Skip(0).Take(1).First();

            string line2 = File.ReadLines("svar.txt").Skip(1).Take(1).First();

            string line3 = File.ReadLines("svar.txt").Skip(2).Take(1).First();

            string line4 = File.ReadLines("svar.txt").Skip(3).Take(1).First();

            string line5 = File.ReadLines("svar.txt").Skip(4).Take(1).First();

            string line6 = File.ReadLines("svar.txt").Skip(5).Take(1).First();

            Console.Write("Spørgsmål 1: ");
            Console.WriteLine("Dit svar var --> "+line1);
            Console.WriteLine("Svarmuligheder:");
            Console.Write("1: "); Console.WriteLine(davs[1]);
            Console.Write("2: "); Console.WriteLine(davs[2]);
            Console.Write("3: "); Console.WriteLine(davs[3]);
            Console.Write("4: "); Console.WriteLine(davs[4]);
            Console.WriteLine("Det rigtige svar var --> " + davs[1]);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Spørgsmål 2: ");
            Console.WriteLine("Dit svar var --> " + line2);
            Console.WriteLine("Svarmuligheder:");
            Console.Write("1: "); Console.WriteLine(davs[1+5]);
            Console.Write("2: "); Console.WriteLine(davs[2+5]);
            Console.Write("3: "); Console.WriteLine(davs[3 + 5]);
            Console.Write("4: "); Console.WriteLine(davs[4 + 5]);
            Console.WriteLine("Det rigtige svar var --> " + davs[2+5]);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Spørgsmål 3: ");
            Console.WriteLine("Dit svar var --> " + line3);
            Console.WriteLine("Svarmuligheder:");
            Console.Write("1: "); Console.WriteLine(davs[1+10]);
            Console.Write("2: "); Console.WriteLine(davs[2+10]);
            Console.Write("3: "); Console.WriteLine(davs[3+10]);
            Console.Write("4: "); Console.WriteLine(davs[4+10]);
            Console.WriteLine("Det rigtige svar var --> " + davs[3+10]);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Spørgsmål 4: ");
            Console.WriteLine("Dit svar var --> " + line4);
            Console.WriteLine("Svarmuligheder:");
            Console.Write("1: "); Console.WriteLine(davs[1+15]);
            Console.Write("2: "); Console.WriteLine(davs[2+15]);
            Console.Write("3: "); Console.WriteLine(davs[3+15]);
            Console.Write("4: "); Console.WriteLine(davs[4+15]);
            Console.WriteLine("Det rigtige svar var --> " + davs[4 + 15]);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Spørgsmål 5: ");
            Console.WriteLine("Dit svar var --> " + line5);
            Console.WriteLine("Svarmuligheder:");
            Console.Write("1: "); Console.WriteLine(davs[1+20]);
            Console.Write("2: "); Console.WriteLine(davs[2+20]);
            Console.Write("3: "); Console.WriteLine(davs[3+20]);
            Console.Write("4: "); Console.WriteLine(davs[4+20]);
            Console.WriteLine("Det rigtige svar var --> " + davs[1 + 20]);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("Spørgsmål 6: ");
            Console.WriteLine("Dit svar var --> " + line6);
            Console.WriteLine("Svarmuligheder:");
            Console.Write("1: "); Console.WriteLine(davs[1+25]);
            Console.Write("2: "); Console.WriteLine(davs[2+25]);
            Console.Write("3: "); Console.WriteLine(davs[3+25]);
            Console.Write("4: "); Console.WriteLine(davs[4+25]);
            Console.WriteLine("Det rigtige svar var --> " + davs[2 + 25]);

            Console.ReadLine();
            // string line6 = File.ReadLines("svar.txt").Skip(5).Take(1).First();

        }
    }
}
