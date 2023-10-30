using Domain;
using Domain.DTOs;

namespace HttpClients1.ClientInterfaces;

public interface ITodoService
{
    Task CreateAsync(TodoCreationDto dto);
    Task UpdateAsync(TodoUpdateDto dto);
    Task<TodoBasicDto> GetByIdAsync(int id);
    Task DeleteAsync(int id);

    Task<ICollection<Todo>> GetAsync(
        string? userName, 
        int? userId, 
        bool? completedStatus, 
        string? titleContains
    );
}