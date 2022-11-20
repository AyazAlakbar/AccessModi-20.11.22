using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    internal class Person
    {
        public Person()
        {
            
        }
        private string _name;
        public string Name 
        { 
            
            get 
            {
               
                return _name;
            } 
            set 
            {

                if (value.Length>4)
                {
                    _name = value;
                    Console.WriteLine("success");
                    return;

                }
                Console.WriteLine("wrong");
            } 
        }
    }
}
