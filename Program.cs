using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(60);
            Names();
        }

        public static int[] RandomArray()
        {   
            
            int sum = 0;
            Random rand = new Random();
            int[] randArr = new int[10];

            for(int i = 0; i <10; i++)
            {
                int randInt = rand.Next(5,25);
                randArr[i] = randInt;
                // if(randInt> max)
                // {
                //     max = randInt;
                // }
                sum += randInt;
            }
            int min = randArr[0];
            int max = randArr[0];

            for(int j = 0; j<randArr.Length; j++)
            {
                Console.WriteLine(randArr[j]);
                if(randArr[j]<min)
                {
                    min = randArr[j];
                }else if(randArr[j]> max)
                {
                    max = randArr[j];
                }
            }
            Console.WriteLine($"min: {min}, max: {max}, sum: {sum}");
            return randArr;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a coin!");
            string flip;
            Random rand = new Random();
            int flipResult = rand.Next(0,2);
            Console.WriteLine(flipResult);
            if(flipResult == 0)
            {
                flip = "heads";
            }else{
                flip = "tails";
            }
            Console.WriteLine(flip);
            return flip;
        }

        public static double TossMultipleCoins(int num)
        {
            double ratio;
            int heads = 0;
            int tails = 0;
            for(int i = 0; i<num; i++)
            {
                string res = TossCoin();
                if(res == "heads")
                {
                    heads++;
                }else{
                    tails++;
                }
            }
            ratio = (double)heads/(double)tails;
            Console.WriteLine(heads);
            Console.WriteLine(tails);
            Console.WriteLine(ratio);
            return ratio;
        }
        public static List<string> Names()
        {
            List<string> nameList = new List<string>();
            List<string> bigNames = new List<string>();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sysney");
            Random rand = new Random();
            for(int i = 0; i < nameList.Count; i++)
            {
                nameList[i] = nameList[rand.Next(0,6)];
                Console.WriteLine(nameList[i]);
                if(nameList[i].Length > 5)
                {
                    bigNames.Add(nameList[i]);
                }
            }


            return bigNames;


        }
        
    }
}
