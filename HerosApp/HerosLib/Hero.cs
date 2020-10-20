using System;

namespace herosLib
{
    // default access modifier: internal
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
}
