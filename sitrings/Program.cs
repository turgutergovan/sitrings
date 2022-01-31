using System;

namespace sitrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ergovan";
            string fullname = " turgut ergovan";

            /*   var result = name.Length;
               Console.WriteLine(result);
               Console.WriteLine(name[0]);

               foreach (var item in name)
               {
                   Console.WriteLine(item);
               } */


            /*  var result1 = name + fullname;
              Console.WriteLine(result1);
              Console.WriteLine(String.Format("{0} {1}", name,fullname));

              */

            /*    var result2 = fullname.Substring(0, 8);

                var result3 = fullname.IndexOf(' ');
                var result4 = fullname.LastIndexOf(' ');
                var result5 = fullname.ToLower();
                var result6 = fullname.ToUpper();
                var result7 = fullname.Replace(' ','+');
                var result8 = fullname.Remove(0,8);
                var result9 = fullname.Trim();
                var result10 = fullname.TrimStart();
                var result11 = fullname.TrimEnd();


                Console.WriteLine(result2);
                Console.WriteLine(result3);
                Console.WriteLine(result4);
                Console.WriteLine(result5);
                Console.WriteLine(result6);
                Console.WriteLine(result7);
                Console.WriteLine(result8);
                Console.WriteLine(result9);
                Console.WriteLine(result10);
                Console.WriteLine(result11); */

            /*   string[] words = fullname.Split(' ');
               foreach (var item in words)
               {
                   Console.WriteLine(item);
               }
             */

            /*   char[] letters = fullname.ToCharArray();
               foreach (var item in letters)
               {
                   Console.WriteLine(item);
               }
            */

            /*   DateTime dt = DateTime.Now;
               Console.WriteLine(dt);


               DateTime dt2;
               dt2 = dt.AddDays(1);
               Console.WriteLine(dt2);

               TimeSpan ts = dt2.Subtract(dt);
               Console.WriteLine(ts.Days);
            */


            double number = 625;
            double kok = Math.Sqrt(number);
            Console.WriteLine(kok);

            double number1 = 6.3;
            double round = Math.Round(number1);
            Console.WriteLine(round);


            double round1 = Math.Ceiling(number1);
            Console.WriteLine(round1);

            int number2 = -5;
            int absolute = Math.Abs(number2);
            Console.WriteLine(absolute);

            double max = Math.Max(5, 3.2);
            Console.WriteLine(max);

            double min= Math.Min(5,3.2);
            Console.WriteLine(min);


        }
    }
}
