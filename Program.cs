using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(6);
            Names();
        }
        public static int[] RandomArray()
        {
            int min = 25;
            int max = 5;
            int sum = 0;
            int[] array = new int[10];
            for(int i=0;i<array.Length;i++)
            {
                Random random = new Random();
                array[i]=random.Next(5, 26);
                sum += array[i];
                if(min>array[i])
                {
                    min = array[i];
                }
                if(max<array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min is " + min);
            Console.WriteLine("Max is " + max);
            return array;
        }
        public static string TossCoin()
        {
            string result;
            string[] coin = {"Heads","Tails"};
            Console.WriteLine("Tossing a Coin!");
            Random random = new Random();
            int flip = random.Next(2);
            result = coin[flip];
            Console.WriteLine("Landed on " + result);
            return result;
        }
        public static double TossMultipleCoins(int num)
        {
            int heads = 0;
            for(int i=1;i<=num;i++)
            {
                string result = TossCoin();
                if(result=="Heads"){
                    heads++;
                }
            }
            double ratio = heads;
            ratio = ratio/num;
            Console.WriteLine(ratio);
            return ratio;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            names = Shuffle(names);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            List<string> longNames = new List<string>();
            foreach(string name in names){
                if(name.Length>5)
                {
                    longNames.Add(name);
                }
            }
            return longNames;
        }
        public static List<string> Shuffle(List<string> list)
        {
            List<string> shuffled = new List<string>();
            while(list.Count>0)
            {
                Random random = new Random();
                int randomIndex = random.Next(list.Count);
                shuffled.Add(list[randomIndex]);
                list.RemoveAt(randomIndex);
            }
            return shuffled;
        }
    }
}
