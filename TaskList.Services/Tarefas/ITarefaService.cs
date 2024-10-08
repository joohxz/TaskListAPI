namespace TaskList.Services.Tarefas
{
    public interface ITarefaService
    {
        Tarefa CriarTarefa(Tarefa tarefa);
        Tarefa ConsultarPorId(int id);
        IEnumerable<Tarefa> ListarTodasTarefas();
        void AtualizarTarefa(int id, Tarefa tarefa);
        void DeletarTarefa(int id);

    }
}
