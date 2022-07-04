using ApplicationTerminal.Handlers.ActionHandlers;
using ApplicationTerminal.Handlers.Base.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationTerminal.Handlers.Base
{
    public abstract class HandlerBase : IHandler
    {
        protected HandlerBase _handler;
        public void SetHandler(HandlerBase handler)
        {
            _handler = handler;
        }
    

        public virtual void HandleRequest(List<string> commands)
        {
            if (_handler != null)
            {
                _handler.HandleRequest(commands);
            }
            
        }

        public virtual void InsertRequestCpf(List<string> commands)
        {
            if (_handler != null)
            {
                _handler.InsertRequestCpf(commands);
            }

        }


    }
}
