using TaskList.Communication.Responses;
using TaskList.Domain.Tarefas;

namespace TaskList.Services.Tarefas
{
    public interface ITarefaService
    {
        Task<Response> CriarTarefa(Tarefa tarefa);
        Task<Response> ConsultarPorId(int id);
        Task<Response> ListarTodasTarefas();
        Task<Response> AtualizarTarefa(int id, TipoPrioridade prioridade, DateTime dataLimite, TipoStatus status);
        Task<Response> DeletarTarefa(int id);

    }
}
