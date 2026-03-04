using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaBastiao.Banco.Repositories
{
    public class Aluguel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdItem { get; set; }
        public DateTime DataAluguel{ get; set; }
        public DateTime DataDevolucao { get; set; }
        public int Status { get; set; }
        public int Ativo { get; set; }


    }
}
