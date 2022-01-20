using System;

namespace HWS_Ctors_Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //way to random names
            string[] stamNames = { "yossi", "dana", "shimi", "orit", "meir" };
            int ranIndex = new Random().Next(0, stamNames.Length);
            string name = stamNames[ranIndex];


            // Exr 9 : 
            int size = int.Parse(Console.ReadLine());
            string[] namesArray = new string[size];

            string randomName;
            Person p;
            for (int i = 0; i < namesArray.Length; i++)
            {
                randomName = CreateRandomString(6);
                namesArray[i] = randomName;
                p = new Person(randomName);
            }

            for (int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine(namesArray[i]);
            }

            namesArray = new string[size];
            int[] agesArray = new int[size];

            int randomAge;
            Person[] persons = new Person[size];
            for (int i = 0; i < namesArray.Length; i++)
            {
                randomName = CreateRandomString(6);
                namesArray[i] = randomName;

                randomAge = CreateRandomInteger(1, 101);
                agesArray[i] = randomAge;

                persons[i] = new Person(randomName, randomAge);
            }

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }


        public static string CreateRandomString(int length)
        {
            // creating a StringBuilder object()
            //Add using To System.Text;
            Random r = new Random();
            System.Text.StringBuilder str_build = new System.Text.StringBuilder();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = r.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }


        public static double CreateRandomDouble()
        {
            Random r = new Random();
            return r.NextDouble() * 10;
        }


        public static int CreateRandomInteger(int from, int to)
        {
            Random r = new Random();
            return r.Next(from, to);
        }
    
    }

}
