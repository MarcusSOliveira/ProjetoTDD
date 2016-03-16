using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Departamento
    {
        public virtual int IdDepartamento { get; set; }
        public virtual string Nome { get; set; }
               
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
