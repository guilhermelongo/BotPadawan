using ApplicationTerminal.Handlers.Base;
using Infrastructure.Services;
using Infrastructure.Services.Base.Interfaces;
using Models.Extensions;
using System;
using System.Collections.Generic;


namespace ApplicationTerminal.Handlers.ActionHandlers
{
    public class SendHandler : HandlerBase
    {
        IService _service;
        public override void HandleRequest(List<string> commands)
        {
            string sendCommand = commands.GetNextCommand();
            
            _handler = null;


            if ("EMAIL".Equals(sendCommand))
            {
                int quantity = int.Parse(commands.GetNextCommand());
                _service = new EmailService();
                _service.DoAction(quantity);
             
            }
            else if ("SMS".Equals(sendCommand))
            {
                Console.WriteLine("Enviando SMS!");
            }
            else
            {
                Console.WriteLine("Comando sms n identificado");
            }

            base.HandleRequest(commands);

        }
    }
}
