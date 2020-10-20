using System;
using herosLib;

namespace herosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region default constructor
            #endregion
            #region Parameterized constructor
            /*
            Hero obj = new Hero(1, "brian");
            Console.WriteLine($"{obj.Id} {obj.name}");
            #endregion 
            #region access via properties
            obj.Id = 2;
            Console.WriteLine($"New Id = {obj.Id}");
            */
            #endregion

            #region Accessing 1-D Arrays

            Hero obj=new Hero();
            // Console.Write("Please Enter your heros id: ");
            // obj.Id = Int32.Parse(Console.ReadLine());
            // Console.Write("Please Enter your heros name: ");
            // obj.Name = Console.ReadLine();
            // Console.Write("Enter the first super power: ");
            // obj.superPowers[0] = Console.ReadLine();
            // Console.Write($"{obj.Id} {obj.Name} {obj.superPowers[0]}");
            obj.ja[0] = new int[2]; // first column
            obj.ja[1] = new int[3]; // second column
            obj.ja[2] = new int[2]; // third column
            obj.ja[0][0] = 10;
            obj.ja[1][2] = 15;
            Console.WriteLine(obj.ja.Length);
            Console.WriteLine();

            // for(int i = 0; i < obj.ja.Length; i++) {
            //     for(int j = 0; j < obj.ja[i].Length; j++) {
            //         Console.WriteLine(obj.ja[i][j]);
            //     }
            // }

            foreach (var rows in obj.ja) {
        
                foreach (var item in rows) {
                    Console.Write($"{item} ");
                }
                 Console.WriteLine();
            }
            #endregion


        }
    }
}
