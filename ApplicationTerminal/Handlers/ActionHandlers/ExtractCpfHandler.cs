using ApplicationTerminal.Handlers.Base;
using Models.Entities;
using Models.Extensions;
using Newtonsoft.Json;
using Repositories;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTerminal.Handlers.ActionHandlers
{
    public class ExtractCpfHandler : HandlerBase
    {

        public override async void HandleRequest(List<string> commands)
        {
            string actionCommand = commands.GetNextCommand();

            _handler = null;

            if ("CPF".Equals(actionCommand))
            {
                GetApiRepository apiRepository = new GetApiRepository();
                
                await apiRepository.GetIdAsync(commands[0]);
               

            }

            else
            {
                Console.WriteLine("Parametro invalido");
                base.HandleRequest(commands);
            }



        }

            //public override async void InsertRequestCpf(List<string> commands)
            //{
            //string actionCommand = commands.GetNextCommand();

            //if ("INSERT CPF".Equals(actionCommand))
            //{

            //    ICreateApiRepository apiRepository = new CreateApiRepository();
            //    await apiRepository.InsertAsync(commands[1]);
            //}
            //else
            //{
            //    Console.WriteLine("Parametro invalido");
            //}


            
           

          

            //}


         


    }
}
