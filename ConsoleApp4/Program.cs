using System;
using Lib;



namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Edit ed = new Edit();
            ed.Model = "M5";
            
            //ed.Model = "M5";
            Console.WriteLine($" { ed.Model} ");
            

            

        }
    }
}
