using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaBastiao.Banco.Repositories
{
    public class Itens
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public string UrlImagem { get; set; }
        public bool Disponivel { get; set; }
    }
}
