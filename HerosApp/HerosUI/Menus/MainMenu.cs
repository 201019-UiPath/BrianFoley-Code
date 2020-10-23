using HerosLib;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using HerosBL;

namespace HerosUI.Menus
{
    ///<summary>
    /// The welcome menu for users
    ///</summary>
    public class MainMenu:IMenu
    {
        HeroBL heroBL = new HeroBL();
        public void Start() {

            string userInput; 
            do{
                System.Console.WriteLine("Welcome Friend! What would you like to do today?");
                //Options
                System.Console.WriteLine("[0] Create a hero \n[1] Get all heroes \n[2] Exit");
                userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Hero newHero = GetHeroDetails();
                        heroBL.AddHero(newHero);
                        System.Console.WriteLine($"Hero {newHero.Name} was created with a superpower of {Hero.superPowers.Pop()}");
                        break;
                    case "1":
                        List<Hero> allheroes = heroBL.GetAllHeroes();
                        foreach(var hero in allheroes){
                            System.Console.WriteLine($"Hero {hero.Name}");
                        }
                        break;
                    case "2":
                        System.Console.WriteLine("Goodbye friend.");
                        break;
                    default:
                        System.Console.WriteLine("Invalid input! Please select a valid option!");
                        break;
                }
            } while (!userInput.Equals("2"));
        }

        public Hero GetHeroDetails()
        {
            Hero hero = new Hero();
            do {
                Console.WriteLine("Enter Hero Name: ");
                hero.Name = Console.ReadLine();
            } while (Regex.IsMatch(hero.Name, "\\d"));
                Console.WriteLine("Enter to add a super power to your hero: ");
                hero.AddSuperPower(Console.ReadLine());
                System.Console.WriteLine("Hero Created!");
            return hero;
        }
    }

}