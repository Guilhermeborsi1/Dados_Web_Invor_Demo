using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes_Invor_Dados_Web.EF
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
    }
}
