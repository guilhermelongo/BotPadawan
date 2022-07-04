using ApplicationTerminal.Handlers.ActionHandlers;
using ApplicationTerminal.Handlers.Base;
using Models.Entities;
using Models.Extensions;
using Newtonsoft.Json;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApplicationTerminal.Handlers
{

    public class ActionHandler : HandlerBase
    {
        public override void HandleRequest(List<string> commands)
        {
            string actionCommand = commands.GetNextCommand();

            _handler = null;



            if ("HELP".Equals(actionCommand))
            {
                Console.WriteLine("Doque vc precisa, amico?");
            }
            else if ("EXTRACT".Equals(actionCommand))
            {
                ExtractCpfHandler extractCpf = new ExtractCpfHandler();
                extractCpf.HandleRequest(commands);


            }
            else if ("INSERT CPF".Equals(actionCommand))
            {
            }
            else if ("SEND".Equals(actionCommand))
            {
                Console.WriteLine("calma meu filhao, estou enviando!");
                _handler = new SendHandler();
            }
            else if ("CLEAR".Equals(actionCommand))
            {
                Console.Clear();
                Console.WriteLine("-------BotPadawan-------");
            }
            else
            {
                Console.WriteLine("Como voce é burro cara .......... Que loucura...... Nao entendo o que voce diz, pq vc escreve de uma maneira tao burra ?......");
            }

            base.HandleRequest(commands);




        }
    }

}




