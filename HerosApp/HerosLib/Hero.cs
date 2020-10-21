using System;
using System.Collections.Generic;

namespace herosLib
{
    // default access modifier: internal

    #region old way of creating class members
    /*
    public class Hero
    {
        
        // default access modifiers: private
        private int id; // value type => System.Int32

        public int Id {
            get {
                return id;
            }
            set {
                id=value;
            }
        }
        public string name; // reference type

        //constructor
        public Hero(int id, string name) {
            this.id = id;
            this.name = name;
        }

    }
    */
    #endregion

    #region Modern way of creating class members
    public class Hero {
        //public static Hero shared = Hero();
        public int Id {get; set;}
        public string Name{get; set;}
        #region arrays
        // public string[] superPowers = new string[10];
        // //jagged array
        // public int[][] ja=new int[3][];
        #endregion

        #region 
        //public static List<string> superPowers = new List<string>();

        //public static Stack<string> superPowers = new Stack<string>();
        public static Dictionary<string, string> hideouts = new Dictionary<string,string>();
        // public static Stack<string> GetSuperPowers() {
        //     return superPowers;
        // }
        // public void RemoveSuperPower(string superPower) {
        //     if(superPowers.Contains(superPower)) {
        //         superPowers.Pop();
        //     }
        // }
        #endregion
        public Hero() {
            // superPowers.Push("Strength");
            // superPowers.Push("Fly");
            // superPowers.Push("Invisibility");
            // superPowers.Push("X-ray vision");
            hideouts.Add("Thor", "Asgard");
            hideouts.Add("Batman", "Batcave");
            hideouts.Add("Superman", "Fortress Solitude");
        }
    }
    #endregion
}
