using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        
        public Cliente()
        {
            
        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool EhMaiorDeIdade()
        { 
            bool retorno = this.Idade > 17 ? true : false;
            return retorno;
        }
    }
}
