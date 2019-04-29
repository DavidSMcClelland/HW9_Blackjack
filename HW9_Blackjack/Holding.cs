/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Blackjack
{
    class Holding
    {
        // bool ToBoolean( string s)
        //{
        //    string[] trueStrings = { "1", "y", "yes", "true" };
        //    string[] falseStrings = { "0", "n", "no", "false" };


        //    if (trueStrings.Contains(s, StringComparer.OrdinalIgnoreCase))
        //        userAnswer1 = true;
        //    if (falseStrings.Contains(s, StringComparer.OrdinalIgnoreCase))
        //        return false;

        //    throw new InvalidCastException("only the following are supported for converting strings to boolean: "
        //        + string.Join(",", trueStrings)
        //        + " and "
        //        + string.Join(",", falseStrings));
        //}
      //  Console.WriteLine(userAnswer1);

                // bool userAnswer1 = Console.ReadLine();
                //   bool userCard3 = ("y" != "true");
                //    string value = "y"; bool b = bool.Parse(value);

                //         bool isString = String.TryParse(reply, out userCard3Reply);
                //Console.WriteLine(UserCard3Reply);


                //   if ()
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Blackjack
{
    class Program
    {


        static void Main(string[] args)
        {
            int bet = 0;
            //  int bet2        = 0;
            //   int dealer      = 0;
            //   int user        = 0;
            //  int userCard3 = 0;
            //  // public static bool userAnswer1;
            //   string userCard3Reply;
            int userTotal1 = 0;

            bool anotherPlay = true;
            //    bool endPlay = false;


            //    bool   userAnswer2   ;
            int dealerTotal1 = 0;
            //  int dealerCard2 = 0;

            do
            {
                Console.WriteLine("How much would you like to wager?");
                string reply = Console.ReadLine();
                bool isNumerical = int.TryParse(reply, out bet);

                Console.WriteLine($"You bet {bet}");

                Random randomCard = new Random();
                System.Threading.Thread.Sleep(20);
                int userCard1 = randomCard.Next(1, 10); Console.WriteLine();

                Random randomCard2 = new Random();
                System.Threading.Thread.Sleep(20);
                int userCard2 = randomCard2.Next(1, 10); Console.WriteLine();

                Random randomCard3 = new Random();
                System.Threading.Thread.Sleep(20);
                int dealerCard1 = randomCard3.Next(1, 10); Console.WriteLine();

                Random randomCard4 = new Random();
                System.Threading.Thread.Sleep(20);
                int dealerCard2 = randomCard4.Next(1, 10); Console.WriteLine();

                userTotal1 = userCard1 + userCard2;
                dealerTotal1 = dealerCard1 + dealerCard2;

                Console.WriteLine($"Your cards are: {userCard1} and {userCard2} for a total of {userTotal1} ");
                Console.WriteLine($"The dealer's cards are: {dealerCard1} and {dealerCard2} for a total of {dealerTotal1} ");

                Console.WriteLine($"Would you like to place another card? Enter Y or N");
                string UserReply = Console.ReadLine().ToUpper();
                Console.WriteLine($"1. User Reply  {UserReply}");
                //bool b = string userReply == "y";
                //     bool myboll = Convert.ToBoolean(UserReply);

                if (UserReply.Equals("Y"))
                {

                    Random randomCard5 = new Random();
                    System.Threading.Thread.Sleep(20);
                    int userCard3Bet = randomCard5.Next(1, 10);

                    userTotal1 = userTotal1 + userCard3Bet;
                    Console.WriteLine($"You drew a {userCard3Bet} for a total of {userTotal1} .");
                }
                //   bool isNumerical = int.TryParse(reply, out bet);

                if (UserReply.Equals("N"))
                {
                    Console.WriteLine(UserReply);
                    break;
                }

                if (dealerTotal1 > 21)
                {
                    Console.WriteLine($"Congratulations, you win!");
                }

                if (dealerTotal1 > 17)
                {
                    Console.WriteLine($"The dealer is not going to draw another card.");
                }

                if (dealerTotal1 <= 17)
                {
                    Random randomCard6 = new Random();
                    System.Threading.Thread.Sleep(20);
                    int dealerCard3 = randomCard6.Next(1, 10);

                    dealerTotal1 = dealerTotal1 + dealerCard3;
                    Console.WriteLine($"The dealer drew another card {dealerCard3} for a total of {dealerTotal1} ");
                }

                if (dealerTotal1 > userTotal1)
                {
                    Console.WriteLine($"The dealer won this hand.");
                }

                if (dealerTotal1 <= userTotal1)
                {
                    Console.WriteLine($"You won this hand.");
                }

                Console.WriteLine("If you would like to play again enter 'Y' if not enter any key.");
                string PlayAgain = Console.ReadLine().ToUpper();
                if (PlayAgain.Equals("Y"))
                {
                    anotherPlay = true;
                    Console.WriteLine($" Fred {anotherPlay}");
                }
                if (PlayAgain != "Y")
                {
                    anotherPlay = false;
                    Console.WriteLine($" Wilma {anotherPlay}");
                }
            } while (anotherPlay == true);

        }
    }
}
*/