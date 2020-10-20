using System;

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
        public int Id {get; set;}
        public string Name{get; set;}
        public string[] superPowers = new string[10];
        //jagged array
        public int[][] ja=new int[3][];
 
    }
    #endregion
}
