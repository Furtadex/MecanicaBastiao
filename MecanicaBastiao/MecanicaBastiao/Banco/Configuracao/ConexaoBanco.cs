using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaBastiao.Banco.Configuracao
{
    public class ConexaoBanco
    {
        public IDbConnection CriarConexao()
        {
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=gerenciamento_funcionarios; Trusted_Connection=True;");
        }
    }
}
