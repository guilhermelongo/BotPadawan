using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.IEntities
{
    public class PessoaPost
    {
        public string Cpf { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public  DateTime BirthDate { get; set; }
    }
}
