using System;
using System.Threading;



namespace Project_X_VS_2
{
    public class Vars
    {
       public string userInput = Console.ReadLine();
    }

    class Program
    {

        
        static void Main(string[] args)
        {
           
        Console.WriteLine("Hello and welcome to the text adventure");

            Console.WriteLine("1 or 2?:");
          
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Decision 1 test");
                    Thread.Sleep(300);

                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Decision 2 test");
                    Thread.Sleep(300);
                    break;
             
            }

            

        }
    }
}