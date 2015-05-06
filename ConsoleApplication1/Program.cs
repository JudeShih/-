using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Computer = 0;
        static int Players = 0;
        static string Player;
        static void Main(string[] args)
        {
            Enter();
        }
        public static void Enter()
        {
            Random random = new Random();
            Computer = random.Next(0,4);
            Console.WriteLine("Enter\n(Paper/Scissor/Stone)");
            Player = Console.ReadLine();
            
            if (Player == "Paper" || Player == "paper")
            {
                Players = 1;
                Game();
            }
            else if (Player == "Scissor" || Player == "scissor")
            {
                Players = 2;
                Game();
            }
            else if (Player == "Stone" || Player == "stone")
            {
                Players = 3;
                Game();
            }
            else
                Console.WriteLine("無法辨識");
            
        
        }
        
        public static void Game()
        {
            if (Players ==1 && Computer == 3)
            {
                Console.WriteLine("You Win"+"\n"+"You:"+Player+",Computer:Stone");
            }
            else if(Players == 2 && Computer == 1)
            {
                Console.WriteLine("You Win"+"\n"+"You:"+Player+",Computer:Paper");
            }
            else if(Players == 3 && Computer == 2)
            {
                Console.WriteLine("You Win"+"\n"+"You:"+Player+",Computer:Scissor");
            }

            else if (Players == 3 && Computer == 1)
            {
                Console.WriteLine("You Lose"+"\n"+"You:"+Player+",Computer:Paper");
            }
            else if (Players == 1 && Computer == 2)
            { 
            Console.WriteLine("You Lose"+"\n"+"You:"+Player+",Computer:Scissor");
            }
            else if (Players == 2 && Computer == 3)
            { 
            Console.WriteLine("You Lose"+"\n"+"You:"+Player+",Computer:Stone");
            }
            else if(Players == Computer)
            {
            Console.WriteLine("Fair"+"\n"+"You:"+Player+",Computer:"+Player);
            }
            Console.WriteLine("Try Again?\n(Y/N)");
            string Tryagain = Console.ReadLine();
            if (Tryagain == "Y" || Tryagain == "y" || Tryagain == "Yes" || Tryagain == "yes")
            {
                Enter();
            }
            
        }    
        
    }
}
