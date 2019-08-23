using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet
{
    public class Table
    {
        public static void BuildTable() //Builds a roulette table

        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("+---+--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\tTYPES OF BETS:");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 3");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 6");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 9");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("12");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("15");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("18");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("21");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("24");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("27");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("30");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("33");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("36");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|3rd|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t1. Individual Numbers: Type a number Ex: '17'");




            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 +--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t2. Evens/Odds: Type 'even' or 'odd'");




            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|---|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 2");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 5");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 8");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("11");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("14");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("17");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("20");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("23");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("26");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("29");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("32");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("35");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|2nd|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t3. Reds/Blacks: Number is red or black");




            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|   +--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t4. 1-18/19-36: Type 'low' or 'high'");




            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 1");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 4");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 7");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("10");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("13");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("16");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("19");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("22");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("25");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("28");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("31");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("34");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|1st|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t5. Dozens: Type 'dozen' followed by a space and '1', '2', or '3'");




            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("+---+--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t6. Colums: Type '1st', '2nd', or '3rd'");




            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    |    1-12   |   13-24   |   25-36   |    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t7. Street: Type 'street' and bottom  value Ex: street 4 -> 4-7");



            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    +-----+-----+-----+-----+-----+-----+    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t8. Six: Type 'six' and bottom left value Ex: 'street 4' -> 4-9");

            

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    | 1-18| EVEN| RED |BLACK| ODD |19-36|    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t9. Split: Type 'split' and two numbers separated by spaces. Ex: 'split 1 2'");
            

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    +-----+-----+-----+-----+-----+-----+    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t10. Corner: Type 'corner' followed by a space and the bottom left value");
            Console.Write("                                             \t    Ex: 'corner 17' -> 17/18/20/21");


            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

        }
    }
}
