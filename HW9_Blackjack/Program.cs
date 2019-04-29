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
            bool anotherPlay   = true;
            int  bet           = 0;
            int  dealerTotal1  = 0;
            int  dealerWinning = 0;
            int  userTotal1    = 0;
            int  userWinning   = 0;
            
            


            do
            {
                Console.WriteLine("How much would you like to wager?");
                string reply = Console.ReadLine();
                bool isNumerical = int.TryParse(reply, out bet);

                Console.WriteLine($"You bet {bet}");
                Console.WriteLine();
                              
                Random randomCard = new Random();
                System.Threading.Thread.Sleep(20);
                int userCard1 = randomCard.Next(1, 10);

                Random randomCard2 = new Random();
                System.Threading.Thread.Sleep(20);
                int userCard2 = randomCard2.Next(1, 10);

                Random randomCard3 = new Random();
                System.Threading.Thread.Sleep(20);
                int dealerCard1 = randomCard3.Next(1, 10);

                Random randomCard4 = new Random();
                System.Threading.Thread.Sleep(20);
                int dealerCard2 = randomCard4.Next(1, 10);

                userTotal1 = userCard1 + userCard2;
                dealerTotal1 = dealerCard1 + dealerCard2;

                Console.WriteLine($"Your cards are: {userCard1} and {userCard2} for a total of {userTotal1} ");
                Console.WriteLine($"The dealer's cards are: {dealerCard1} and {dealerCard2} for a total of {dealerTotal1} ");
                              
                Console.WriteLine($"Would you like to draw another card? Enter Y or N");
                string UserReply = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (UserReply.Equals("Y"))
                {         
                    Random randomCard5 = new Random();
                    System.Threading.Thread.Sleep(20);
                    int userCard3Bet = randomCard5.Next(1, 10);
                     
                    userTotal1 = userTotal1 + userCard3Bet;
                    Console.WriteLine($"You drew a {userCard3Bet} for a total of {userTotal1} .");
                }
               

                if(UserReply.Equals("N"))
                {
                    Console.WriteLine("You did not to place another bet.");
                }

                if (dealerTotal1 > 21) 
                {
                    Console.WriteLine($"Congratulations, you win!");
                }

                if (dealerTotal1 > 17)
                {
                    Console.WriteLine($"The dealer is not going to draw another card.");
                }

                if (dealerTotal1<=17)
                {
                    Random randomCard6 = new Random();
                    System.Threading.Thread.Sleep(20);
                    int dealerCard3 = randomCard6.Next(1, 10);

                    dealerTotal1 = dealerTotal1 + dealerCard3;
                    Console.WriteLine($"The dealer drew another card {dealerCard3} for a total of {dealerTotal1} ");
                }

                if  (dealerTotal1 >= 21)
                        {
                    Console.WriteLine($"The dealer total is {dealerTotal1} so the dealer lost this hand.");
                    userWinning = userWinning + bet;
                }

                if (userTotal1 >= 21)
                {
                    Console.WriteLine($"Your total is {userTotal1} so the dealer won this hand.");
                    dealerWinning = dealerWinning + bet;
                }

                if (dealerTotal1 > userTotal1)
                {
                    Console.WriteLine($"The dealer won this hand.");
                    dealerWinning = dealerWinning + bet;
                }
                    
                if(dealerTotal1 <= userTotal1)
                {
                    Console.WriteLine($"You won this hand.");
                    userWinning = userWinning + bet;
                }

                Console.WriteLine();
                Console.WriteLine($"Your total winnings are {userWinning}.");
                Console.WriteLine($"The dealer's total winnings are {dealerWinning}.");
                


                Console.WriteLine("If you would like to play again enter 'Y' if not enter any key.");
                string PlayAgain = Console.ReadLine().ToUpper();
                if(PlayAgain.Equals("Y"))
                {
                    Console.WriteLine();
                    Console.WriteLine("* * * * *");
                    anotherPlay = true;
                }
                if(PlayAgain != "Y")
                {
                    anotherPlay = false;
                }
            } while (anotherPlay==true);

        }
    }
}
