using TaskList.Domain.Tarefas;

namespace TaskList.Services.Tarefas
{
    public interface ITarefaService
    {
        Tarefa CriarTarefa(Tarefa tarefa);
        Tarefa ConsultarPorId(int id);
        IList<Tarefa> ListarTodasTarefas();
        Tarefa AtualizarTarefa(int id, TipoPrioridade prioridade, DateTime dataLimite, TipoStatus status);
        void DeletarTarefa(int id);

    }
}
