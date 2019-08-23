using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bet
{
    static class Imports
    {
        public static IntPtr HWND_BOTTOM = (IntPtr)1;
        public static IntPtr HWND_TOP = (IntPtr)0;

        public static uint SWP_NOSIZE = 1;
        public static uint SWP_NOZORDER = 4;

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, uint wFlags);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 28);
            var consoleWnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            Imports.SetWindowPos(consoleWnd, 0, 0, 350, 0, 500, Imports.SWP_NOSIZE | Imports.SWP_NOZORDER);

            int wallet = int.Parse(args[1]);
            int dollars = wallet;
            List<Bet> bets = new List<Bet>();
            string input; //user input
            bool validBet = true, validAmount = true;
            Stopwatch s = new Stopwatch();
            int time = 87;//set this for a few seconds before wheel stops            
            s.Start();
            while (s.Elapsed < TimeSpan.FromSeconds(time))
            {
                Console.Clear();
                Table.BuildTable();
                if (!validAmount) Console.WriteLine("\tInvalid Bet");
                if (!validBet) Console.WriteLine("\tNot enough money!");
                validBet = true;
                Console.WriteLine("\tTotal money is: $" + wallet);
                Console.WriteLine("\tHow much would you like to bet?");
                Console.Write("\t$");
                input = Console.ReadLine();
                if (s.Elapsed >= TimeSpan.FromSeconds(time))
                {
                    Console.WriteLine("Too slow!");
                    validBet = false;
                    continue;
                }
                validAmount = int.TryParse(input, out dollars);
                if (dollars <= 0)//checks for bet of 0 or less
                {
                    validAmount = false;
                    continue;
                }
                if (validAmount)//actual number
                {
                    Console.WriteLine("\tWhat is your bet?");
                    if (dollars <= wallet)
                    {
                        wallet -= dollars;
                        while (true)
                        {
                            Console.Write("\t");
                            input = Console.ReadLine();
                            input = input.Trim();
                            input = input.ToLower();
                            if (s.Elapsed >= TimeSpan.FromSeconds(time))
                            {
                                Console.WriteLine("Too slow!");
                                validBet = false;
                                break;
                            }
                            if (!ActualBet.tryBet(input, dollars, int.Parse(args[0]), bets))
                            {
                                Console.WriteLine("Invalid bet or Improper Syntax, what is your bet?");                                
                            }
                            else break;
                        }
                    }
                    else validBet = false;
                }
            }
            Console.WriteLine("Betting is done!");
            while (s.Elapsed < TimeSpan.FromSeconds(80))
            {
                Console.Write("");
            }
            s.Stop();
            Console.WriteLine("\tPayout!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("==========+++++++========All Bets==========+++++++========");
            string isWin;          
            foreach (Bet item in bets)
            {
                if (item.win == true) isWin = "Win!";
                else isWin = "Lose!";
                Console.WriteLine("\t" + item.bet + ".........." + isWin + "\t\t$" + item.dollars);
                wallet += item.dollars;
            }
            Console.WriteLine("You now have $" + wallet + " in your wallet!");
            Console.WriteLine("Thanks for playing, type 'exit' to leave table");
            while(true)
            {
                if (Console.ReadLine() == "exit")
                {
                    Process.Start("cmd.exe", "/c taskkill /IM Wheel.exe");
                    break;
                }
            }
        }
    }
}
