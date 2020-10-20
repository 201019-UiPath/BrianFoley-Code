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
            Hero obj = new Hero(1, "brian");
            Console.WriteLine($"{obj.Id} {obj.name}");
            #endregion 
            #region access via properties
            obj.Id = 2;
            Console.WriteLine($"New Id = {obj.Id}");
            #endregion
        }
    }
}
