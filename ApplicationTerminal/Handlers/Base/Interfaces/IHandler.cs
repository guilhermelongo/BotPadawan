
using ApplicationTerminal.Handlers.ActionHandlers;
using Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationTerminal.Handlers.Base.Interfaces
{
    public interface IHandler
    {
        public void SetHandler(HandlerBase handler);

        public void HandleRequest(List<string> commands);
    
        public void InsertRequestCpf(List<string> commands);
    }
}