using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using SOM_Primes.Properties;

namespace SOM_PRIMES
{
    public class functions
    {
        //FIELDS
        public static List<int> PrimeInts;
        public static List<int> DigitalRootInts;
        public static SoundPlayer Player1 = new SoundPlayer();
        public static SoundPlayer Player2 = new SoundPlayer();
        public static SoundPlayer Player3 = new SoundPlayer();
        public static SoundPlayer Player4 = new SoundPlayer();
        public static SoundPlayer Player5 = new SoundPlayer();
        public static SoundPlayer Player6 = new SoundPlayer();
        public static SoundPlayer Player7 = new SoundPlayer();
        public static SoundPlayer Player8 = new SoundPlayer();
        public static SoundPlayer Player9 = new SoundPlayer();
        //METHODS
        /// <summary>
        ///     Initialize UI
        /// </summary>
        /// <returns></returns>
        public static int UI()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** SoundOfMath_Primes ***\r\n");
            Console.WriteLine("Choose # of prime numbers notes to generate in order to create the song:\r\n(0<#<1000)  ");
            getvalue:
            var input = Convert.ToInt32(Console.ReadLine());
            if (input < 1 || input > 999)
            {
                Console.WriteLine("Wrong #, please insert a # between 0 and 1000");
                goto getvalue;
            }
            Console.Clear();
            Console.WriteLine("*** SoundOfMath_Primes ***\r\n");
            Console.WriteLine("You chose to play " + input + " notes.");
            return input;
        }

        /// <summary>
        ///     Generate (#) of note values
        /// </summary>
        /// <param name="val"></param>
        public static void gen_note_values(int val)
        {
            //Take the string from primes_f.txt file and separate them into list items
            var pRawList = Resources.primes_f.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Generate list of prime ints based on the strings list
            var pIntsList = new List<int>();
            for (var i = 0; i < val; i++)
                pIntsList.Add(Convert.ToInt32(pRawList[i]));

            // System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteLines.txt", "test");
            //Assign values to the public list of primes
            PrimeInts = pIntsList;

            //Generate list of digital roots ints based on the prime ints list
            var pDigitalRootList = new List<int>();
            for (var j = 0; j < val; j++)
                pDigitalRootList.Add(digital_root(pIntsList[j]));

            //Assign values to the public list of digital roots
            DigitalRootInts = pDigitalRootList;
        }

        /// <summary>
        ///     Calculate the digital root of the given int
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int digital_root(int number)
        {
            repeat:
            var dr = 0;
            while (number != 0)
            {
                dr += number%10;
                number /= 10;
            }
            if (dr > 9)
            {
                number = dr;
                goto repeat;
            }

            return dr;
        }

        /// <summary>
        ///     Generate players
        /// </summary>
        public static void generate_players()
        {
            Player1.SoundLocation = "../../Resources/piano_chords/Amin7.wav";
            Player2.SoundLocation = "../../Resources/piano_chords/major A middle.wav";
            Player3.SoundLocation = "../../Resources/piano_chords/minor chords - Am higher.wav";
            Player4.SoundLocation = "../../Resources/piano_chords/Cmin7 Low Pitch.wav";
            Player5.SoundLocation = "../../Resources/piano_chords/major C middle.wav";
            Player6.SoundLocation = "../../Resources/piano_chords/minor chords - Cm higher.wav";
            Player7.SoundLocation = "../../Resources/piano_chords/Emin7.wav";
            Player8.SoundLocation = "../../Resources/piano_chords/major E.wav";
            Player9.SoundLocation = "../../Resources/piano_chords/minor chords - Em higher.wav";
        }
    }
}