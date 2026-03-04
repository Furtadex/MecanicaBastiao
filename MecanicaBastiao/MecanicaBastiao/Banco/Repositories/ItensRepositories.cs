using Dapper;
using MecanicaBastiao.Banco.Configuracao;

namespace MecanicaBastiao.Banco.Repositories
{
    public class ItensRepositories
    {
        private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

        public static async Task<IEnumerable<Itens>> ObterTodos()
        {
            var itens = await conexaoBanco.CriarConexao()
                .QueryAsync<Itens>(
@"
SELECT
    id,
    nome,
    descricao,
    categoria,
    url_imagem as UrlImagem,
    preco
FROM itens
");

            return itens;
        }

        public static async Task Adicionar(Itens item)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
@"
INSERT INTO itens
(
    nome,
    descricao,
    preco,
    quantidade
)
VALUES
(
    @Nome,
    @Descricao,
    @Preco,
    @Quantidade
)
",
            item);
        }

        public static async Task Editar(Itens item)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
@"
UPDATE itens
SET
    nome = @Nome,
    descricao = @Descricao,
    preco = @Preco,
    quantidade = @Quantidade
WHERE id = @Id
",
            item);
        }

        public static async Task Deletar(int idItem)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
@"
DELETE FROM itens
WHERE id = @Id
",
            new { Id = idItem });
        }

        public static async Task<Itens> ObterPorId(int idItem)
        {
            var item = await conexaoBanco.CriarConexao()
                .QueryFirstOrDefaultAsync<Itens>(
@"
SELECT
    id,
    nome,
    descricao,
    preco,
    quantidade
FROM itens
WHERE id = @Id
",
                new { Id = idItem });

            return item;
        }
       
    }
}