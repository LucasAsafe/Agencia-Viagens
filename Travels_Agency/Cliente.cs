using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travels_Agency
{
    class Cliente
    {
        public String nome;
        public String telefone;
        public String endereço;
        public String CPF;
        public String RG;
        public Cliente(String nome, String telefone, String endereço, String RG, String CPF)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereço = endereço;
            this.CPF = CPF;
            this.RG = RG;
        }
    }
}
