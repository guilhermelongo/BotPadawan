using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Base
{
    public interface IGetPessoaRepository
    {
        public Task GetIdAsync(string valor);
        
    }
}
