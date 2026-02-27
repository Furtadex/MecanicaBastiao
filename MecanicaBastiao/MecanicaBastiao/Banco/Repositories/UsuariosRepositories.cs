using Dapper;
using MecanicaBastiao.Banco.Configuracao;

namespace MecanicaBastiao.Banco.Repositories
{
    public class UsuariosRepository
    {
        private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

        public static async Task<IEnumerable<Usuario>> ObterTodos()
        {
            var usuarios = await conexaoBanco.CriarConexao()
                .QueryAsync<Usuario>(
@"
SELECT
    id,
    nome,
    email,
    cpf,
    telefone,
    data_nascimento
FROM usuarios
");

            return usuarios;
        }

        public static async Task Adicionar(Usuario usuario)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
@"
INSERT INTO usuarios
(
    nome,
    email,
    cpf,
    telefone,
    data_nascimento
)
VALUES
(
    @Nome,
    @Email,
    @Cpf,
    @Telefone,
    @DataNascimento
)
",
            usuario);
        }

        public static async Task Atualizar(Usuario usuario)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
@"
UPDATE usuarios
SET
    nome = @Nome,
    email = @Email,
    cpf = @Cpf,
    telefone = @Telefone,
    data_nascimento = @DataNascimento
WHERE id = @Id
",
            usuario);
        }

        public static async Task Deletar(int idUsuario)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
@"
DELETE FROM usuarios
WHERE id = @Id
",
            new { Id = idUsuario });
        }

        public static async Task<Usuario> ObterPorId(int idUsuario)
        {
            var usuario = await conexaoBanco.CriarConexao()
                .QueryFirstOrDefaultAsync<Usuario>(
@"
SELECT
    id,
    nome,
    email,
    cpf,
    telefone,
    data_nascimento
FROM usuarios
WHERE id = @Id
",
                new { Id = idUsuario });

            return usuario;
        }
    }
}