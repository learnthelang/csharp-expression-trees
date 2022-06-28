using System;

namespace BasicDelegate
{
    internal class Step2_ActionDelegate
    {
        //removed delegate declaration        

        //Method 1 which matches the delegate
        public static void WriteMessage(string message) { Console.WriteLine(message); }

        //Method 2 which matches the delegate
        public static void WriteTimelyMessage(string message) { Console.WriteLine($"{message} - {DateTime.Now}"); }

        static void Main(string[] args)
        {
            var selection = Console.ReadLine();

            //declare a delegate type using Action
            Action<string> func;

            //Assign method according to the condition
            if (selection == "1")
                func = WriteTimelyMessage;
            else
                func = WriteMessage;

            func("Hello World!");
        }
    }
}