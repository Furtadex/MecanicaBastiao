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
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "PLAYTV",
                IntegratedSecurity = true
            };
            
            return new SqlConnection(builder.ConnectionString);
        }
    }
}
