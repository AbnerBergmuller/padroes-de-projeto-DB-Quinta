namespace Application.Services;

// TODO (Grupo Factory): Centralizar criação de Produto garantindo invariantes.
// Sugestões de validação: nome não vazio, descricao não vazia, preco > 0, estoque >= 0.
// Discutir se deve lançar ArgumentException, DomainException custom ou retornar Result.
// Explicar no PR por que uma Factory faz sentido (ou se seria overkill neste tamanho) — reflexão.
public static class ProdutoFactory
{
    public static Produto Criar(string nome, string descricao, decimal preco, int estoque)
    {
        // TODO: Implementar regras e retornar instância pronta.
        throw new NotImplementedException();
    }
}
