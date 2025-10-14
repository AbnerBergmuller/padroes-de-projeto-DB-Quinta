using Application.Interfaces;

namespace Application.Services;

// TODO (Grupo Service): Implementar regras de negócio aqui.
// NÃO colocar detalhes de EF Core. Usar apenas a abstração IProdutoRepository.
// Integrar posteriormente com validações (FluentValidation) e Factory.
// Sugerido: lançar exceções de domínio específicas ou retornar Result Pattern (opcional, comentar no PR).
public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repo;

    public ProdutoService(IProdutoRepository repo)
    {
        _repo = repo;
    }

    public Task<IEnumerable<Produto>> ListarAsync(CancellationToken ct = default)
    {
        // TODO: Adicionar possibilidade de filtros futuros (Specification Pattern em fases posteriores)
        throw new NotImplementedException();
    }

    public Task<Produto?> ObterAsync(int id, CancellationToken ct = default)
    {
        // TODO: Validar id > 0 e talvez normalizar algum aspecto.
        throw new NotImplementedException();
    }

    public Task<Produto> CriarAsync(string nome, string descricao, decimal preco, int estoque, CancellationToken ct = default)
    {
        // TODO: Integrar com ProdutoFactory.Criar e depois persistir via repository.
        // TODO: Tratar regras: nome não vazio, preço > 0, estoque >= 0, trimming.
        throw new NotImplementedException();
    }

    public Task<bool> RemoverAsync(int id, CancellationToken ct = default)
    {
        // TODO: Buscar, validar existência e remover.
        throw new NotImplementedException();
    }
}
