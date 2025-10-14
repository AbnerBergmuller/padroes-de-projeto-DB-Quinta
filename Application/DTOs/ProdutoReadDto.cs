namespace Application.DTOs;

// TODO: Confirmar se todos os campos devem ser expostos ao cliente.
// Possíveis extensões: adicionar campo calculado (ex: ValorEstoque = Preco * Estoque) via mapping.
// Decidir padrão de nome (PascalCase / camelCase) conforme política de serialização.

public record ProdutoReadDto(
	int Id,
	string Nome,
	string Descricao,
	decimal Preco,
	int Estoque,
	DateTime DataCriacao
);
