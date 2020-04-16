using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Funcionarios
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CodigoFuncionario { get; set; }
        public long Cpf { get; set; }
        public string Funcao { get; set; }
        public int CodigoFuncao { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
