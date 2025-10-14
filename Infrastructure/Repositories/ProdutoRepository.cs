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

    public Task<IEnumerable<Produto>> GetAllAsync(CancellationToken ct = default)
    {
        // TODO: retornar lista com AsNoTracking.
        throw new NotImplementedException();
    }

    public Task<Produto?> GetByIdAsync(int id, CancellationToken ct = default)
    {
        // TODO: usar FindAsync.
        throw new NotImplementedException();
    }

    public Task AddAsync(Produto produto, CancellationToken ct = default)
    {
        // TODO: AddAsync(produto, ct)
        throw new NotImplementedException();
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
