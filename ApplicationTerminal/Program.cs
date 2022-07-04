using ApplicationTerminal.Handlers;
using Models.Extensions;
using System;
using System.Collections.Generic;


namespace ApplicationTerminal
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("------- BotPadawan------");

            while(true)
            {
                string commandText = Console.ReadLine();
                List<string> commands = commandText.ToCommands();
                Console.WriteLine(commandText);

                ActionHandler actionHandler = new ActionHandler();
                


                actionHandler.HandleRequest(commands);
            }
           
                        
        }
    }
}
