//number guessing game
using System;
using System.ComponentModel;

class sivajiGame
{
    static void Main()
    {

 Random r = new Random();

        int min = 1;
        int max = 100;
        bool playagain = true;
        int guess;
        String res;
        int guesses;
        int num;
        while (playagain)
        {
            guess = 0;      
            num = r.Next(min,max);
            res = "";
            guesses = 0;
            while (guess != num)
            {
                Console.WriteLine("guess num bw"+" "+min+"-"+max);
                guess= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("guess :"+guess);

                if (guess > num)
                {
                    Console.WriteLine("guess is too high ");
                }
                else if (guess < num)
                {
                    Console.WriteLine("guess is too low ");
                }
                guesses++;
            }

            Console.WriteLine("number is " + num);
            Console.WriteLine("congratulations !! you are win");
            Console.WriteLine(" you have guesses "+guesses+" times");

            Console.WriteLine("would you like to play again (y/n)");
            res = Console.ReadLine();
            if(res != "y")
            {
                playagain = false;
            }
            else
            {
                playagain=true;
            }
        }
        Console.WriteLine("Thanks for playing game!!");
        Console.ReadKey();
    }
}
