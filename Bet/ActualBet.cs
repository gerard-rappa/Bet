using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet
{
    public class Bet
    {
        public int dollars;
        public string bet;
        public bool win;

        public Bet( string bet, int dollars, int number, bool win, int multiplier)
        {
            if(win == true) //winning bet
            {
                this.dollars = dollars * multiplier;
                this.bet = bet;
                this.win = true;
            }
            else //losing bet
            {
                this.dollars = 0;
                this.bet = bet;
                this.win = false;
            }
        }
    }
    public class ActualBet
    {
        
        public static bool tryBet(string bet, int dollars, int winningNumber, List<Bet> bets)
        {
            char[] spaces = { ' ' };
            int[] reds = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] blacks = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] lows = { 1-18 };
            int[] highs = { 19-36 };
            int[] dozen1 = { };
            int[] dozen2 = { };
            int[] dozen3 = { };
            int[] column1 = { };
            int[] column2 = { };
            int[] column3 = { };
            bool boo = false;
            if (bet.Length > 0)
            {
                string[] parser = bet.Split(spaces, StringSplitOptions.RemoveEmptyEntries);
                if (parser.Length == 1)
                {
            //single number bet                    
                    if (bet.Equals("00"))
                    {
                        if (winningNumber == 37) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("0"))
                    {
                        if (winningNumber == 0) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("1"))
                    {
                        if (winningNumber == 1) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("2"))
                    {
                        if (winningNumber == 2) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("3"))
                    {
                        if (winningNumber == 3) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("4"))
                    {
                        if (winningNumber == 4) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("5"))
                    {
                        if (winningNumber == 5) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("6"))
                    {
                        if (winningNumber == 6) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("7"))
                    {
                        if (winningNumber == 7) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("8"))
                    {
                        if (winningNumber == 8) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("9"))
                    {
                        if (winningNumber == 9) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("10"))
                    {
                        if (winningNumber == 10) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("11"))
                    {
                        if (winningNumber == 11) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("12"))
                    {
                        if (winningNumber == 12) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("13"))
                    {
                        if (winningNumber == 13) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("14"))
                    {
                        if (winningNumber == 14) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("15"))
                    {
                        if (winningNumber == 15) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("16"))
                    {
                        if (winningNumber == 16) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("17"))
                    {
                        if (winningNumber == 17) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("18"))
                    {
                        if (winningNumber == 18) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("19"))
                    {
                        if (winningNumber == 19) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("20"))
                    {
                        if (winningNumber == 20) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("21"))
                    {
                        if (winningNumber == 21) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("22"))
                    {
                        if (winningNumber == 22) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("23"))
                    {
                        if (winningNumber == 23) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("24"))
                    {
                        if (winningNumber == 24) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("25"))
                    {
                        if (winningNumber == 25) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("26"))
                    {
                        if (winningNumber == 26) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("27"))
                    {
                        if (winningNumber == 27) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("28"))
                    {
                        if (winningNumber == 28) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("29"))
                    {
                        if (winningNumber == 29) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("30"))
                    {
                        if (winningNumber == 30) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("31"))
                    {
                        if (winningNumber == 31) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("32"))
                    {
                        if (winningNumber == 32) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("33"))
                    {
                        if (winningNumber == 33) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("34"))
                    {
                        if (winningNumber == 34) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("35"))
                    {
                        if (winningNumber == 35) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("36"))
                    {
                        if (winningNumber == 36) boo = true;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 36);
                        bets.Add(me);
                        return true;
                    }
                    
                    //even/odd
                    if (bet.Equals("odd"))
                    {
                        bet = ("Odds");
                        if (winningNumber % 2 == 1) boo = true;
                        if (winningNumber == 37) boo = false;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 2);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("even"))
                    {
                        bet = ("Evens");
                        if (winningNumber % 2 == 0) boo = true;
                        if (winningNumber == 0) boo = false;
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 2);
                        bets.Add(me);
                        return true;
                    }
                    //red/black
                    if (bet.Equals("red"))
                    {
                        bet = ("Reds");
                        foreach (int number in reds)
                        {
                            if(number == winningNumber)
                            {
                                boo = true;
                                break;
                            }
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 2);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("black"))
                    {
                        bet = ("Blacks");
                        foreach (int number in blacks)
                        {
                            if (number == winningNumber)
                            {
                                boo = true;
                                break;
                            }
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 2);
                        bets.Add(me);
                        return true;
                    }
                    //low /high
                    if (bet.Equals("low"))
                    {
                        bet = ("Lows");
                        foreach (int number in lows)
                        {
                            if (number == winningNumber)
                            {
                                boo = true;
                                break;
                            }
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 2);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("high"))
                    {
                        bet = ("Highs");
                        foreach (int number in highs)
                        {
                            if (number == winningNumber)
                            {
                                boo = true;
                                break;
                            }
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 2);
                        bets.Add(me);
                        return true;
                    }
                    //column
                    if (bet.Equals("1st"))
                    {
                        bet = ("1st Column");
                        foreach (int number in column1)
                        {
                            if (number == winningNumber)
                            {
                                boo = true;
                                break;
                            }
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 3);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("2nd"))
                    {
                        bet = ("2nd Column");
                        foreach (int number in column2)
                        {
                            if (number == winningNumber)
                            {
                                boo = true;
                                break;
                            }
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 3);
                        bets.Add(me);
                        return true;
                    }
                    if (bet.Equals("3rd"))
                    {
                        bet = ("3rd Column");
                        foreach (int number in column3)
                        {
                            if (number == winningNumber)
                            {
                                boo = true;
                                break;
                            }
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 3);
                        bets.Add(me);
                        return true;
                    }
                    //basket
                    if (bet.Equals("basket"))
                    {
                        bet = ("Basket");
                        if (winningNumber == 0 || winningNumber == 37 || winningNumber == 1 || winningNumber == 2 || winningNumber == 3)
                        {
                            boo = true;
                        }
                        Bet me = new Bet(bet, dollars, winningNumber, boo, 7);
                        bets.Add(me);
                        return true;
                    }
                }
                if(parser.Length == 2)
                {
                    //dozen + 1/13/25
                    if (parser[0].Equals("dozen"))
                    {
                        if (parser[1].Equals("1"))
                        {
                            bet = ("1st Dozen");
                            foreach (int number in dozen1)
                            {
                                if (number == winningNumber)
                                {
                                    boo = true;
                                    break;
                                }
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 3);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("2"))
                        {
                            bet = ("2nd Dozen");
                            foreach (int number in dozen2)
                            {
                                if (number == winningNumber)
                                {
                                    boo = true;
                                    break;
                                }
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 3);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("3"))
                        {
                            bet = ("3rd Dozen");
                            foreach (int number in dozen3)
                            {
                                if (number == winningNumber)
                                {
                                    boo = true;
                                    break;
                                }
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 3);
                            bets.Add(me);
                            return true;
                        }
                        return false;
                    }
                    //street + int
                    if (parser[0].Equals("street"))
                    {
                        if (parser[1].Equals("1"))
                        {
                            bet = ("1 Street");
                            if (winningNumber == 1 || winningNumber == 2 || winningNumber == 3)
                            {
                                boo = true; 
                            }
                            Bet me = new Bet(bet, dollars, winningNumber,  boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("4"))
                        {
                            bet = ("4 Street");
                            if (winningNumber == 4 || winningNumber == 5 || winningNumber == 6)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("7"))
                        {
                            bet = ("7 Street");
                            if (winningNumber == 7 || winningNumber == 8 || winningNumber == 9)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("10"))
                        {
                            bet = ("10 Street");
                            if (winningNumber == 10 || winningNumber == 11 || winningNumber == 12)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("13"))
                        {
                            bet = ("13 Street");
                            if (winningNumber == 13 || winningNumber == 14 || winningNumber == 15)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("16"))
                        {
                            bet = ("16 Street");
                            if (winningNumber == 16 || winningNumber == 17 || winningNumber == 18)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("19"))
                        {
                            bet = ("19 Street");
                            if (winningNumber == 19 || winningNumber == 20 || winningNumber == 21)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("22"))
                        {
                            bet = ("22 Street");
                            if (winningNumber == 22 || winningNumber == 23 || winningNumber == 24)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("25"))
                        {
                            bet = ("25 Street");
                            if (winningNumber == 25 || winningNumber == 26 || winningNumber == 27)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("28"))
                        {
                            bet = ("28 Street");
                            if (winningNumber == 28 || winningNumber == 29 || winningNumber == 30)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("31"))
                        {
                            bet = ("31 Street");
                            if (winningNumber == 31 || winningNumber == 32 || winningNumber == 33)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("34"))
                        {
                            bet = ("34 Street");
                            if (winningNumber == 34 || winningNumber == 35 || winningNumber == 36)
                            {
                                boo = true;
                            }
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 12);
                            bets.Add(me);
                            return true;
                        }
                    }
                    //six + int
                    if (parser[0].Equals("six"))
                    {
                        if (parser[1].Equals("1"))
                        {
                            bet = ("1-4 Street");
                            if (winningNumber == 1 || winningNumber == 2 || winningNumber == 3 || winningNumber == 4 || winningNumber == 5 || winningNumber == 6) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("4"))
                        {
                            bet = ("4-7 Street");
                            if (winningNumber == 4 || winningNumber == 5 || winningNumber == 6 || winningNumber == 7 || winningNumber == 8 || winningNumber == 9) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("7"))
                        {
                            bet = ("7-10 Street");
                            if (winningNumber == 7 || winningNumber == 8 || winningNumber == 9 || winningNumber == 10 || winningNumber == 11 || winningNumber == 12) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("10"))
                        {
                            bet = ("10-13 Street");
                            if (winningNumber == 10 || winningNumber == 11 || winningNumber == 12 || winningNumber == 13 || winningNumber == 14 || winningNumber == 15) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("13"))
                        {
                            bet = ("13-16 Street");
                            if (winningNumber == 13 || winningNumber == 14 || winningNumber == 15 || winningNumber == 16 || winningNumber == 17 || winningNumber == 18) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("16"))
                        {
                            bet = ("16-19 Street");
                            if (winningNumber == 16 || winningNumber == 17 || winningNumber == 18 || winningNumber == 19 || winningNumber == 20 || winningNumber == 21) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("19"))
                        {
                            bet = ("19-22 Street");
                            if (winningNumber == 19 || winningNumber == 20 || winningNumber == 21 || winningNumber == 22 || winningNumber == 23 || winningNumber == 24) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("22"))
                        {
                            bet = ("22-25 Street");
                            if (winningNumber == 22 || winningNumber == 23 || winningNumber == 24 || winningNumber == 25 || winningNumber == 26 || winningNumber == 27) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("25"))
                        {
                            bet = ("25-28 Street");
                            if (winningNumber == 25 || winningNumber == 26 || winningNumber == 27 || winningNumber == 28 || winningNumber == 29 || winningNumber == 30) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("28"))
                        {
                            bet = ("28-31 Street");
                            if (winningNumber == 28 || winningNumber == 29 || winningNumber == 30 || winningNumber == 31 || winningNumber == 32 || winningNumber == 33) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("31"))
                        {
                            bet = ("31-34 Street");
                            if (winningNumber == 31 || winningNumber == 32 || winningNumber == 33 || winningNumber == 34 || winningNumber == 35 || winningNumber == 36) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 6);
                            bets.Add(me);
                            return true;
                        }
                    }
                    //corner + int
                    if (parser[0].Equals("corner"))
                    {
                        if (parser[1].Equals("1"))
                        {
                            bet = ("Corner 1");
                            if (winningNumber == 1 || winningNumber == 2 || winningNumber == 4 || winningNumber == 5) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("2"))
                        {
                            bet = ("Corner 2");
                            if (winningNumber == 2 || winningNumber == 3 || winningNumber == 5 || winningNumber == 6) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("4"))
                        {
                            bet = ("Corner 4");
                            if (winningNumber == 7 || winningNumber == 8 || winningNumber == 4 || winningNumber == 5) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("5"))
                        {
                            bet = ("Corner 5");
                            if (winningNumber == 5 || winningNumber == 6 || winningNumber == 8 || winningNumber == 9) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("7"))
                        {
                            bet = ("Corner 7");
                            if (winningNumber == 7 || winningNumber == 8 || winningNumber == 10 || winningNumber == 11) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("8"))
                        {
                            bet = ("Corner 8");
                            if (winningNumber == 8 || winningNumber == 11 || winningNumber == 9 || winningNumber == 12) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("10"))
                        {
                            bet = ("Corner 10");
                            if (winningNumber == 10 || winningNumber == 13 || winningNumber == 11 || winningNumber == 14) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("11"))
                        {
                            bet = ("Corner 11");
                            if (winningNumber == 11 || winningNumber == 12 || winningNumber == 14 || winningNumber == 15) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("13"))
                        {
                            bet = ("Corner 13");
                            if (winningNumber == 13 || winningNumber == 14 || winningNumber == 16 || winningNumber == 17) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("14"))
                        {
                            bet = ("Corner 14");
                            if (winningNumber == 14 || winningNumber == 15 || winningNumber == 17 || winningNumber == 18) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("16"))
                        {
                            bet = ("Corner 16");
                            if (winningNumber == 16 || winningNumber == 17 || winningNumber == 19 || winningNumber == 20) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("17"))
                        {
                            bet = ("Corner 17");
                            if (winningNumber == 17 || winningNumber == 18 || winningNumber == 20 || winningNumber == 21) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("19"))
                        {
                            bet = ("Corner 19");
                            if (winningNumber == 19 || winningNumber == 20 || winningNumber == 22 || winningNumber == 23) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("20"))
                        {
                            bet = ("Corner 20");
                            if (winningNumber == 20 || winningNumber == 21 || winningNumber == 23 || winningNumber == 24) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("22"))
                        {
                            bet = ("Corner 22");
                            if (winningNumber == 22 || winningNumber == 23 || winningNumber == 25 || winningNumber == 26) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("23"))
                        {
                            bet = ("Corner 23");
                            if (winningNumber == 23 || winningNumber == 24 || winningNumber == 26 || winningNumber == 27) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("25"))
                        {
                            bet = ("Corner 25");
                            if (winningNumber == 25 || winningNumber == 26 || winningNumber == 28 || winningNumber == 29) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("26"))
                        {
                            bet = ("Corner 26");
                            if (winningNumber == 26 || winningNumber == 27 || winningNumber == 29 || winningNumber == 30) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("28"))
                        {
                            bet = ("Corner 28");
                            if (winningNumber == 28 || winningNumber == 29 || winningNumber == 31 || winningNumber == 32) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("29"))
                        {
                            bet = ("Corner 29");
                            if (winningNumber == 29 || winningNumber == 30 || winningNumber == 32 || winningNumber == 33) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("31"))
                        {
                            bet = ("Corner 31");
                            if (winningNumber == 31 || winningNumber == 32 || winningNumber == 34 || winningNumber == 35) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                        if (parser[1].Equals("32"))
                        {
                            bet = ("Corner 32");
                            if (winningNumber == 32 || winningNumber == 33 || winningNumber == 35 || winningNumber == 36) boo = true;
                            Bet me = new Bet(bet, dollars, winningNumber, boo, 9);
                            bets.Add(me);
                            return true;
                        }
                    }
                }
                if(parser.Length == 3)
                {
                    //split + int + int
                    if (parser[0].Equals("split"))
                    {
                        if (parser[1].Equals("00"))
                        {
                            if (parser[2].Equals("0"))
                            {
                                bet = ("Split 00|0");
                                if(winningNumber == 37 || winningNumber == 0 ) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("0"))
                        {
                            if (parser[2].Equals("00"))
                            {
                                bet = ("Split 0|00");
                                if (winningNumber == 37 || winningNumber == 0) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("1"))
                        {
                            if (parser[2].Equals("2"))
                            {
                                bet = ("Split 1|2");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }                        
                            if (parser[2].Equals("4"))
                            {
                                bet = ("Split 1|4");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("2"))
                        {
                            if (parser[2].Equals("1"))
                            {
                                bet = ("Split 2|1");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("3"))
                            {
                                bet = ("Split 2|3");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("5"))
                            {
                                bet = ("Split 2|5");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("3"))
                        {
                            if (parser[2].Equals("2"))
                            {
                                bet = ("Split 3|2");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("6"))
                            {
                                bet = ("Split 3|6");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("4"))
                        {
                            if (parser[2].Equals("1"))
                            {
                                bet = ("Split 4|1");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("5"))
                            {
                                bet = ("Split 4|5");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("7"))
                            {
                                bet = ("Split 4|7");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("5"))
                        {
                            if (parser[2].Equals("2"))
                            {
                                bet = ("Split 5|2");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("4"))
                            {
                                bet = ("Split 5|4");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("6"))
                            {
                                bet = ("Split 5|6");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("8"))
                            {
                                bet = ("Split 5|8");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("6"))
                        {
                            if (parser[2].Equals("3"))
                            {
                                bet = ("Split 6|3");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("5"))
                            {
                                bet = ("Split 6|5");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("9"))
                            {
                                bet = ("Split 6|9");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("7"))
                        {
                            if (parser[2].Equals("4"))
                            {
                                bet = ("Split 7|4");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("8"))
                            {
                                bet = ("Split 7|8");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("10"))
                            {
                                bet = ("Split 7|10");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("8"))
                        {
                            if (parser[2].Equals("5"))
                            {
                                bet = ("Split 8|5");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("7"))
                            {
                                bet = ("Split 8|7");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("9"))
                            {
                                bet = ("Split 8|9");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("11"))
                            {
                                bet = ("Split 8|11");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("9"))
                        {
                            if (parser[2].Equals("6"))
                            {
                                bet = ("Split 9|6");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("8"))
                            {
                                bet = ("Split 9|8");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("12"))
                            {
                                bet = ("Split 9|12");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("10"))
                        {
                            if (parser[2].Equals("7"))
                            {
                                bet = ("Split 10|7");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("11"))
                            {
                                bet = ("Split 10|11");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("13"))
                            {
                                bet = ("Split 10|13");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("11"))
                        {
                            if (parser[2].Equals("8"))
                            {
                                bet = ("Split 11|8");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("10"))
                            {
                                bet = ("Split 11|10");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("12"))
                            {
                                bet = ("Split 11|12");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("14"))
                            {
                                bet = ("Split 11|14");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("12"))
                        {
                            if (parser[2].Equals("9"))
                            {
                                bet = ("Split 12|9");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("11"))
                            {
                                bet = ("Split 12|11");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("15"))
                            {
                                bet = ("Split 12|15");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("13"))
                        {
                            if (parser[2].Equals("10"))
                            {
                                bet = ("Split 13|10");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("14"))
                            {
                                bet = ("Split 13|14");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("16"))
                            {
                                bet = ("Split 13|16");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("14"))
                        {
                            if (parser[2].Equals("11"))
                            {
                                bet = ("Split 14|11");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("13"))
                            {
                                bet = ("Split 14|13");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("15"))
                            {
                                bet = ("Split 14|15");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("17"))
                            {
                                bet = ("Split 14|17");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("15"))
                        {
                            if (parser[2].Equals("12"))
                            {
                                bet = ("Split 15|12");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("14"))
                            {
                                bet = ("Split 15|14");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("18"))
                            {
                                bet = ("Split 15|18");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("16"))
                        {
                            if (parser[2].Equals("13"))
                            {
                                bet = ("Split 16|13");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }                        
                            if (parser[2].Equals("17"))
                            {
                                bet = ("Split 16|17");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("19"))
                            {
                                bet = ("Split 16|19");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("17"))
                        {
                            if (parser[2].Equals("14"))
                            {
                                bet = ("Split 17|14");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("16"))
                            {
                                bet = ("Split 17|16");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("18"))
                            {
                                bet = ("Split 17|18");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("20"))
                            {
                                bet = ("Split 17|20");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("18"))
                        {
                            if (parser[2].Equals("15"))
                            {
                                bet = ("Split 18|15");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("17"))
                            {
                                bet = ("Split 18|17");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("21"))
                            {
                                bet = ("Split 18|21");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("19"))
                        {
                            if (parser[2].Equals("16"))
                            {
                                bet = ("Split 19|16");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("20"))
                            {
                                bet = ("Split 19|20");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("22"))
                            {
                                bet = ("Split 19|22");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("20"))
                        {
                            if (parser[2].Equals("17"))
                            {
                                bet = ("Split 20|17");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("19"))
                            {
                                bet = ("Split 20|19");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("21"))
                            {
                                bet = ("Split 20|21");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("23"))
                            {
                                bet = ("Split 20|23");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("21"))
                        {
                            if (parser[2].Equals("18"))
                            {
                                bet = ("Split 21|18");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("20"))
                            {
                                bet = ("Split 21|20");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("24"))
                            {
                                bet = ("Split 21|24");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("22"))
                        {
                            if (parser[2].Equals("19"))
                            {
                                bet = ("Split 22|19");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("23"))
                            {
                                bet = ("Split 22|23");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("25"))
                            {
                                bet = ("Split 22|25");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("23"))
                        {
                            if (parser[2].Equals("20"))
                            {
                                bet = ("Split 23|20");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("22"))
                            {
                                bet = ("Split 23|22");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("24"))
                            {
                                bet = ("Split 23|24");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("26"))
                            {
                                bet = ("Split 23|26");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("24"))
                        {
                            if (parser[2].Equals("21"))
                            {
                                bet = ("Split 24|21");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("23"))
                            {
                                bet = ("Split 24|23");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("27"))
                            {
                                bet = ("Split 24|27");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("25"))
                        {
                            if (parser[2].Equals("22"))
                            {
                                bet = ("Split 25|22");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("26"))
                            {
                                bet = ("Split 25|26");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("28"))
                            {
                                bet = ("Split 25|28");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("26"))
                        {
                            if (parser[2].Equals("23"))
                            {
                                bet = ("Split 26|23");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }                       
                            if (parser[2].Equals("25"))
                            {
                                bet = ("Split 26|25");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("27"))
                            {
                                bet = ("Split 26|27");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("29"))
                            {
                                bet = ("Split 26|29");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("27"))
                        {
                            if (parser[2].Equals("24"))
                            {
                                bet = ("Split 27|24");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("26"))
                            {
                                bet = ("Split 27|26");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("30"))
                            {
                                bet = ("Split 27|30");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("28"))
                        {
                            if (parser[2].Equals("25"))
                            {
                                bet = ("Split 28|25");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("29"))
                            {
                                bet = ("Split 28|29");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("31"))
                            {
                                bet = ("Split 28|31");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("29"))
                        {
                            if (parser[2].Equals("26"))
                            {
                                bet = ("Split 29|26");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("28"))
                            {
                                bet = ("Split 29|28");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("30"))
                            {
                                bet = ("Split 29|30");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("32"))
                            {
                                bet = ("Split 29|32");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("30"))
                        {
                            if (parser[2].Equals("27"))
                            {
                                bet = ("Split 30|27");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("29"))
                            {
                                bet = ("Split 30|29");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("33"))
                            {
                                bet = ("Split 30|33");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("31"))
                        {
                            if (parser[2].Equals("28"))
                            {
                                bet = ("Split 31|28");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("32"))
                            {
                                bet = ("Split 31|32");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("34"))
                            {
                                bet = ("Split 31|34");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("32"))
                        {
                            if (parser[2].Equals("29"))
                            {
                                bet = ("Split 32|29");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("31"))
                            {
                                bet = ("Split 32|31");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("33"))
                            {
                                bet = ("Split 32|33");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("35"))
                            {
                                bet = ("Split 32|35");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("33"))
                        {
                            if (parser[2].Equals("30"))
                            {
                                bet = ("Split 33|30");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("32"))
                            {
                                bet = ("Split 33|32");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("36"))
                            {
                                bet = ("Split 33|36");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("34"))
                        {
                            if (parser[2].Equals("31"))
                            {
                                bet = ("Split 34|31");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("35"))
                            {
                                bet = ("Split 34|35");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("35"))
                        {
                            if (parser[2].Equals("32"))
                            {
                                bet = ("Split 35|32");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("34"))
                            {
                                bet = ("Split 35|34");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("36"))
                            {
                                bet = ("Split 35|36");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                        if (parser[1].Equals("36"))
                        {
                            if (parser[2].Equals("33"))
                            {
                                bet = ("Split 36|33");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                            if (parser[2].Equals("35"))
                            {
                                bet = ("Split 36|35");
                                if (winningNumber == int.Parse(parser[1]) || winningNumber == int.Parse(parser[2])) boo = true;
                                Bet me = new Bet(bet, dollars, winningNumber, boo, 18);
                                bets.Add(me);
                                return true;
                            }
                        }
                    }
                }                
                return false;
            }
            return false;
        }
    }
}
