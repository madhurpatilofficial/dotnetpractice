using System;
using MyNamespace;

namespace Addition
{
    class Validate  // Renamed to follow PascalCase
    {
        private int a;  // Made private
        private int b;  // Made private

        public Validate()
        {
            a = 10;
            b = 10;
            Console.WriteLine(a + b);
        }

        public void Display()
        {
            Console.WriteLine(a);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hi There");
            Validate obj = new Validate();  // Renamed to follow PascalCase
            obj.Display();
            Lol d = new Lol(); //creating obj to acces data from other file with help of namespace which we have imorted in this file          
            d.show();
        }
    }
}