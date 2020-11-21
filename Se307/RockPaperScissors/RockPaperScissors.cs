using System;
/*
 * Rock crushes Scissors
 * Paper covers Rock
 * Scissors cuts Paper
 */
namespace Se307
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            Random rnd= rnd=new Random();
            
            string exit="";
            int pcCounter=0, userCounter=0;
            
            while (true)
            {
                int res;
                int pcAns = rnd.Next(3);
                pcAns++;
                
                Console.Write("Rock(1),Paper(2),Scissors(3): ");
                res = Convert.ToInt32(Console.ReadLine());
                if (pcAns == 1 && res == 2 || pcAns == 2 && res == 3 || pcAns == 3 && res == 1)
                {
                    Console.WriteLine("Computer won");
                    pcCounter++;
                    Console.WriteLine("User " +userCounter + " - "+  pcCounter +" Computer\n");
                }
                else if (res == 1 && pcAns == 2 || res == 2 && pcAns == 3 || res == 3 && pcAns == 1)
                {
                    Console.WriteLine("User won");
                    userCounter++;
                    Console.WriteLine("User " +userCounter + " - "+  pcCounter +" Computer\n");
                }
                else if (res == 9)
                {
                    if (userCounter > pcCounter)
                    {
                        Console.WriteLine("\nCongratulations! You won!\n");
                        Console.WriteLine("User " +userCounter + " - "+  pcCounter+" Computer\n");
                    }

                    else
                    {
                        Console.WriteLine("\nMaybe next time :(\n");
                        Console.WriteLine("User " +userCounter + " - "+  pcCounter+" Computer\n");
                        
                    }
                        break;
                }
                else if(pcAns==res)
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine("User " +userCounter + " - "+  pcCounter+" Computer\n");
                }
                else
                {
                    Console.WriteLine("Undefined!");
                }
                
            }
        }
    }
}
/*
    Taş>Makas
    Makas>Kağıt
    Kağıt>Taş
*/
