using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

//
namespace SOM_PRIMES
{
    internal class main_program
    {
        public static void Main()
        {
            // Initialize GUI and get # of notes to play
            var nv = functions.UI();

            // Generate # note values
            functions.gen_note_values(nv);

            // Generate players
            functions.generate_players();

            Console.WriteLine("Press any key to hear the song...\r\n");
            Console.ReadKey();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var time = 600;
            var l = 0;
            List<int> COUNT = new List<int>();
                for (int i =0;i<9;i++)
                    COUNT.Add(0);
            for (var j = 0; j < nv; j++)
            {
                Console.Write(j + ". Prime number = " + functions.PrimeInts[j] + " -> Digital root = " +
                              functions.DigitalRootInts[j]);

                if (time > 2000 || time < 800)
                    time = 800;

                if (functions.DigitalRootInts[j] > l)
                {
                    time = time + 200;
                }
                else
                {
                    time = time - 200;
                }

                l = functions.DigitalRootInts[j];
                
                switch (functions.DigitalRootInts[j])
                {
                    case 1:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player1.Play();
                        COUNT[0]++;
                        break;

                    case 2:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player2.Play();
                        COUNT[1]++;
                        break;

                    case 3:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player3.Play();
                        COUNT[2]++;
                        break;

                    case 4:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player4.Play();
                        COUNT[3]++;
                        break;

                    case 5:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player5.Play();
                        COUNT[4]++;
                        break;

                    case 6:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player6.Play();
                        COUNT[5]++;
                        break;

                    case 7:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player7.Play();
                        COUNT[6]++;
                        break;

                    case 8:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player8.Play();
                        COUNT[7]++;
                        break;

                    case 9:
                        Console.Write("-> Note = {0} -> Delay = {1}\n\r", functions.DigitalRootInts[j], time);
                        functions.Player9.Play();
                        COUNT[8]++;
                        break;
                }

                Thread.Sleep(time);
            }
            stopwatch.Stop();

            //Display song duration
            Console.WriteLine("\r\n The song was: {0} long.\r\n", stopwatch.Elapsed);

            //Display note count
            Console.WriteLine("Note count:");
            for (int i=0;i<9;i++)
                Console.WriteLine("     Note {0} - " +COUNT[i] + "times",i+1);
            Console.ReadLine();
        }
    }
}