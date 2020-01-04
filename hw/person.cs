using System;

namespace hw1
{
    interface Iperson{
        string name { get; set; } 
    }

    public class person : Iperson
    {
        private string _name = ""; 
        public string name { get { return "Hello, "+ this._name + "!"; } set { this._name = value; } }
        
        public person(){
            Console.WriteLine("From person class");
        }

        public class metoo {
            public metoo(){
                Console.WriteLine("hashtag metoo");
            }
        }
    }
}