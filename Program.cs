using System;

namespace BLACKJACK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Blackjack");
            Console.WriteLine("Get as close to 21 without going over, say stop when you want to stop your turn");

            int player1 = 0;
            int player2 = 0;
            int player3 = 0;
            int dealer = 0;


            Console.WriteLine("Player1 " + player1);
            Console.WriteLine("Player2 " + player2);
            Console.WriteLine("Player3 " + player3);
            Console.WriteLine("Dealer  " + dealer);

            Console.ReadLine();

            Console.WriteLine("Player1 will start");

            String answer = Console.ReadLine();

            while (answer != "stop")
            {
                Random rand1 = new Random();
                int card1 = rand1.Next(1, 14);

                if (card1 > 10)
                {
                    card1 = 10;
                }
                else if (card1 < 2)
                {
                    card1 += 10;
                }

                player1 += card1;

                Console.WriteLine(card1);

                Console.WriteLine(player1);

                if (answer == "stop" || player1 > 21)
                {
                    if (player1 > 21)
                    {
                        Console.WriteLine("Player1 went over.");
                        break;
                        continue;

                    }
                    else if (player1 <= 21)
                    {
                        Console.WriteLine("Player1 gets " + player1 + " in total.");
                        break;
                        continue;
                    }

                }
                answer = Console.ReadLine();
            }


            // player2


            Console.WriteLine("Player1 " + player1);
            Console.WriteLine("Player2 " + player2);
            Console.WriteLine("Player3 " + player3);
            Console.WriteLine("Dealer  " + dealer);

            Console.WriteLine("Player2 will start");

            answer = Console.ReadLine();

            while (answer != "stop")
            {
                Random rand1 = new Random();
                int card1 = rand1.Next(1, 14);

                if (card1 > 10)
                {
                    card1 = 10;
                }
                else if (card1 < 2)
                {
                    card1 += 10;
                }

                player2 += card1;

                Console.WriteLine(card1);

                Console.WriteLine(player2);

                if (answer == "stop" || player2 > 21)
                {
                    if (player2 > 21)
                    {
                        Console.WriteLine("Player2 went over.");
                        break;
                        continue;

                    }
                    else if (player2 <= 21)
                    {
                        Console.WriteLine("Player2 gets " + player2 + " in total.");
                        break;
                        continue;
                    }

                }
                answer = Console.ReadLine();
            }

            // player3

            Console.WriteLine("Player1 " + player1);
            Console.WriteLine("Player2 " + player2);
            Console.WriteLine("Player3 " + player3);
            Console.WriteLine("Dealer  " + dealer);

            Console.ReadLine();

            Console.WriteLine("Player3 will start");

            answer = Console.ReadLine();

            while (answer != "stop")
            {
                Random rand1 = new Random();
                int card1 = rand1.Next(1, 14);

                if (card1 > 10)
                {
                    card1 = 10;
                }
                else if (card1 < 2)
                {
                    card1 += 10;
                }

                player3 += card1;

                Console.WriteLine(card1);

                Console.WriteLine(player3);

                if (answer == "stop" || player3 > 21)
                {
                    if (player3 > 21)
                    {
                        Console.WriteLine("Player3 went over.");
                        break;
                        continue;

                    }
                    else if (player3 <= 21)
                    {
                        Console.WriteLine("Player3 gets " + player3 + " in total.");
                        break;
                        continue;
                    }

                }
                answer = Console.ReadLine();
            }


            // DEALER!

            Console.WriteLine("Player1 " + player1);
            Console.WriteLine("Player2 " + player2);
            Console.WriteLine("Player3 " + player3);
            Console.WriteLine("Dealer  " + dealer);

            Console.WriteLine("The dealer will start");
            Console.ReadLine();

            while (dealer < 15)
            {

                Random rand1 = new Random();
                int card1 = rand1.Next(1, 14);

                if (card1 > 10)
                {
                    card1 = 10;
                }
                else if (card1 < 2)
                {
                    card1 += 10;
                }

                dealer += card1;

                Console.WriteLine(card1);

                Console.WriteLine(dealer);

                if (dealer > 17 || dealer > 21)
                {
                    if (dealer > 21)
                    {
                        Console.WriteLine("Dealer went over.");
                        break;
                        continue;

                    }
                    else if (dealer <= 21)
                    {
                        Console.WriteLine("Dealern gets " + dealer + " in total.");
                        break;
                        continue;
                    }

                }
            }

            Console.WriteLine("Player1 " + player1);
            Console.WriteLine("Player2 " + player2);
            Console.WriteLine("Player3 " + player3);
            Console.WriteLine("Dealer  " + dealer);

            Console.ReadLine();

            if (dealer <= 21)
            {
                if (player1 <= 21)
                {
                    if (player2 <= 21)
                    {
                        if (player3 <= 21)
                        {
                            if (dealer > player1 && dealer > player2 && dealer > player3)
                            {
                                Console.WriteLine("The dealer won!");
                            }
                            else if (player1 > dealer && player1 > player2 && player1 > player3)
                            {
                                Console.WriteLine("Player1 won!");
                            }
                            else if (player2 > dealer && player2 > player1 && player2 > player3)
                            {
                                Console.WriteLine("Player2 won!");
                            }
                            else if (player3 > dealer && player3 > player2 && player3 > player1)
                            {
                                Console.WriteLine("Player3 won!");
                            }

                        }
                        else
                        {
                            if (dealer > player1 && dealer > player2)
                            {
                                Console.WriteLine("The dealer won!");
                            }
                            else if (player1 > dealer && player1 > player2)
                            {
                                Console.WriteLine("Player1 won!");
                            }
                            else if (player2 > dealer && player2 > player1)
                            {
                                Console.WriteLine("Player2 won!");
                            }
                        }
                    }
                    else
                    {
                        if (player3 <= 21)
                        {
                            if (dealer > player1 && dealer > player3)
                            {
                                Console.WriteLine("The dealer won!");
                            }
                            else if (player1 > dealer && player1 > player3)
                            {
                                Console.WriteLine("Player1 won!");
                            }
                            else if (player3 > dealer && player3 > player1)
                            {
                                Console.WriteLine("Player3 won!");
                            }
                        }
                        else
                        {
                            if (dealer > player1)
                            {
                                Console.WriteLine("The dealer won!");
                            }
                            else if (player1 > dealer)
                            {
                               Console.WriteLine("Player1 won!");
                            }
                        }

                    }
                }
                else
                {
                    if (player2 <= 21)
                    {
                        if (player3 <= 21)
                        {
                            if (dealer > player2 && dealer > player3)
                            {
                                Console.WriteLine("The dealer won!");
                            }
                            else if (player2 > dealer && player2 > player3)
                            {
                                Console.WriteLine("Player2 won!");
                            }
                            else if (player3 > dealer && player3 > player2 && player3 > player1)
                            {
                                Console.WriteLine("Player3 won!");
                            }

                        }
                        else
                        {
                            if (dealer > player2)
                            {
                                Console.WriteLine("The dealer won!");
                            }
                            else if (player2 > dealer)
                            {
                                Console.WriteLine("Player2 won!");
                            }
                        }
                    }
                    else
                    {
                        if (player3 <= 21)
                        {
                            if (dealer > player3)
                            {
                                Console.WriteLine("The dealer won!");
                            }
                            else if (player3 > dealer)
                            {
                                Console.WriteLine("Player3 won!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The dealer won!");
                        }

                    }


                }
            }
            else
            {
                if (player1 <= 21)
                {
                    if (player2 <= 21)
                    {
                        if (player3 <= 21)
                        {
                            if (player1 > player2 && player1 > player3)
                            {
                                Console.WriteLine("Player1 won!");
                            }
                            else if (player2 > player1 && player2 > player3)
                            {
                                Console.WriteLine("Player2 won!");
                            }
                            else if (player3 > player2 && player3 > player1)
                            {
                                Console.WriteLine("Player3 won!");
                            }

                        }
                        else
                        {
                            if (player1 > player2)
                            {
                                Console.WriteLine("Player1 won!");
                            }
                            else if (player2 > player1)
                            {
                                Console.WriteLine("Player2 won!");
                            }
                        }
                    }
                    else
                    {
                        if (player3 <= 21)
                        {
                            if (player1 > player3)
                            {
                                Console.WriteLine("Player1 won!");
                            }
                            else if (player3 > player1)
                            {
                                Console.WriteLine("Player3 won!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Player1 won!");
                        }

                    }
                }
                else
                {
                    if (player2 <= 21)
                    {
                        if (player3 <= 21)
                        {
                            if (player2 > player3)
                            {
                                Console.WriteLine("Player2 won!");
                            }
                            else if (player3 > player2)
                            {
                                Console.WriteLine("Player3 won!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Player2 won!");
                        }
                    }
                    else
                    {
                        if (player3 <= 21)
                        {
                            Console.WriteLine("Player3 won!");
                        }
                        else
                        {
                            Console.WriteLine("No one won!");
                        }

                    }


                }

            }




        }
    }
}
