using Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

// TODO (Grupo Repository): Implementar métodos usando AppDbContext.
// Focar em persistência apenas. NÃO adicionar regras de negócio.
// Discutir no PR: vantagens e possíveis redundâncias do padrão.
public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> GetAllAsync(CancellationToken ct = default)
    {
        // TODO: retornar lista com AsNoTracking.
        return await _context.Produtos.ToListAsync();
    }

    public async Task<Produto?> GetByIdAsync(int id, CancellationToken ct = default)
    {
        // TODO: usar FindAsync.
        return await _context.Produtos.FindAsync(id);
    }

    public async Task AddAsync(Produto produto, CancellationToken ct = default)
    {
        // TODO: AddAsync(produto, ct)
        return await _context
    }

    public Task RemoveAsync(Produto produto, CancellationToken ct = default)
    {
        // TODO: _context.Remove(produto)
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync(CancellationToken ct = default)
    {
        // TODO: _context.SaveChangesAsync(ct)
        throw new NotImplementedException();
    }
}
