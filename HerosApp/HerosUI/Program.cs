using System;
using HerosLib;
using HerosUI.Menus;

namespace herosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region default constructor
            #endregion
            #region Parameterized constructor
            
            // Hero obj = new Hero(1, "brian");
            // Console.WriteLine($"{obj.Id} {obj.name}");
            #endregion 
            #region access via properties
            // obj.Id = 2;
            // Console.WriteLine($"New Id = {obj.Id}");
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
            // obj.ja[0] = new int[2]; // first column
            // obj.ja[1] = new int[3]; // second column
            // obj.ja[2] = new int[2]; // third column
            // obj.ja[0][0] = 10;
            // obj.ja[1][2] = 15;
            // Console.WriteLine(obj.ja.Length);
            // Console.WriteLine();

            // for(int i = 0; i < obj.ja.Length; i++) {
            //     for(int j = 0; j < obj.ja[i].Length; j++) {
            //         Console.WriteLine(obj.ja[i][j]);
            //     }
            // }

            // foreach (var rows in obj.ja) {
        
            //     foreach (var item in rows) {
            //         Console.Write($"{item} ");
            //     }
            //      Console.WriteLine();
            // }
            #endregion
            #region collections
            
            // foreach(var superPower in obj.GetSuperPowers()) {
            //     Console.WriteLine(superPower);
            // }

            // Console.WriteLine("Please enter the super power to be removed ");
            // string sp = Console.ReadLine();
            // obj.RemoveSuperPower(sp);

            // foreach(var superPower in obj.GetSuperPowers()) {
            //     Console.WriteLine(superPower);
            // }
            #endregion
            #region traverse dictionary
            // Console.WriteLine("Super Hero      Hideout");
            // foreach(var superHero in Hero.hideouts) {
            //     Console.WriteLine($"{superHero.Key}      {superHero.Value}");
            // }
            #endregion

            #region Calling hero menu
            // IMenu startMenu = new MainMenu();
            // startMenu.Start();
            #endregion

            #region Delegate, Anonymous methods, Lambda
            HeroTasks heroTasks=new HeroTasks();
            
            //HeroDel del=new HeroDel(heroTasks.GetPowers);
            //Action del =new Action(heroTasks.GetPowers);
            //Func<string, string> fd=new Func<string, string>(some method);
            //Predicate<string> predicate=new Predicate<string>(some method);            
            // del += heroTasks.DoWork; // += subscribe to a method
            // del += heroTasks.ManageLife;
            // del();
            // del -= heroTasks.ManageLife; // unsubscribe 
            // del();
        
            //Anonymous methods
            // Action<string> am=delegate(string name){
            //     Console.WriteLine($"Hello {name}");
            // };
            // am("Brian");
            //Lambda expression - shorthand notations to anonymous methods
            // Action result= ()=>Console.WriteLine("Hello Lambda");
            // result();
            #endregion 
            #region Async and Sync programming
            /// Subscribing to publisher
            heroTasks.workDone += EmailService.SendEmail;
            heroTasks.workDone += TextMessageService.SendText;
            heroTasks.DoWork();
            heroTasks.ManageLife();
            Console.Read(); //hold the screen until a key is pressed
            #endregion
        }
    }
}
