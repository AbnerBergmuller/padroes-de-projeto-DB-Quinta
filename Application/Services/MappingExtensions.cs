using Application.DTOs;

namespace Application.Services;

// TODO (Grupo DTO/Mapping): Implementar conversão de Produto -> ProdutoReadDto.
// Discutir se mapping manual é suficiente ou se vão demonstrar o uso de AutoMapper (opcional).
// Possível extensão: adicionar campo calculado no DTO.
public static class MappingExtensions
{
    public static ProdutoReadDto ToReadDto(this Produto p)
    {
        // TODO: retornar nova instância de ProdutoReadDto usando p (mapping manual inicial).
        throw new NotImplementedException();
    }
}
