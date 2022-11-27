namespace DiceGame_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerUser;
            int denzelWashington;
            int bradPitt;

            int playerUserPoints = 0;
            int denzelWashingtonPoints = 0;
            int bradPittPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");

                Console.ReadKey();


                playerUser = random.Next(1, 7);
                Console.WriteLine(" You entered " + playerUser);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                denzelWashington = random.Next(1, 7);
                Console.WriteLine(" Denzel Washington entered " + denzelWashington);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                bradPitt = random.Next(1, 7);
                Console.WriteLine(" Brad Pitt entered " + bradPitt);

                if (playerUser > denzelWashington)
                {
                    playerUserPoints++;
                    Console.WriteLine(" You win this round!");
                }
                else if (playerUser < denzelWashington)
                {
                    denzelWashington++;
                    Console.WriteLine(" Denzel Washington wins this round!");
                }
                else if (playerUser > bradPitt)
                {
                    playerUserPoints++;
                    Console.WriteLine(" You win this round!");
                }
                else if (playerUser < bradPitt)
                {
                    bradPittPoints++;
                    Console.WriteLine(" Brad Pitt wins this round!");
                }
                else if (denzelWashington > bradPitt)
                {
                    denzelWashington++;
                    Console.WriteLine(" Denzel Washington wins this round!");
                }
                else if (denzelWashington < bradPitt)
                {
                    bradPitt++;
                    Console.WriteLine(" Brad Pitt wins this round!");
                }
                else if (playerUser == denzelWashington)
                {
                    Console.WriteLine("This round is a tie!");
                }
                else if (playerUser == bradPitt)
                {
                    Console.WriteLine("This round is a tie!");
                }
                else if (denzelWashington == bradPitt)
                {
                    Console.WriteLine("This round is a tie!");
                }

                Console.WriteLine(" The score of - playerUser : " + playerUser + " Denzel Washington " + denzelWashington + " Brad Pitt " + bradPitt + ",");

                Console.ReadLine();
            }

            if (playerUserPoints > denzelWashingtonPoints)
            {
                Console.WriteLine(" You win! ");
            }
            else if (playerUserPoints < denzelWashingtonPoints)
            {
                Console.WriteLine(" Denzel Washington wins! ");
            }
            else if (playerUserPoints > bradPittPoints)
            {
                Console.WriteLine(" You win!");
            }
            else if (playerUserPoints < bradPittPoints)
            {
                Console.WriteLine(" Brad Pitt wins!");
            }
            else if (denzelWashingtonPoints > bradPittPoints)
            {
                Console.WriteLine(" Denzel Washington wins!");
            }
            else if (denzelWashingtonPoints < bradPittPoints)
            {
                Console.WriteLine(" Brad Pitt wins!");
            }

            Console.ReadKey();

        }
    }
}