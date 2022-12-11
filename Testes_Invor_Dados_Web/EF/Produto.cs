using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes_Invor_Dados_Web.EF
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string fornecedor { get; set; }
       
    }
}
