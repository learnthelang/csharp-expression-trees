using System;

namespace BasicDelegate
{
    internal class Step4_FuncDelegateRefactor
    {
        //removed delegate declaration        

        //Method 1 with return type which matches the delegate
        public static bool WriteMessage(string message) { Console.WriteLine(message); return true; }

        //Method 2 with return type which matches the delegate
        public static bool WriteTimelyMessage(string message) { Console.WriteLine($"{message} - {DateTime.Now}"); return true; }

        static void Main(string[] args)
        {
            var selection = Console.ReadLine();

            //declare a delegate type using Func
            //because Action doesn't support return type
            Func<string, bool> func;

            //Assign method according to the condition
            if (selection == "1")
                func = WriteTimelyMessage;
            else
                func = WriteMessage;

            var result = ExecuteWrite(func);
        }

        private static bool ExecuteWrite(Func<string, bool> func)
        {
            return func("Hello World!");
        }
    }
}