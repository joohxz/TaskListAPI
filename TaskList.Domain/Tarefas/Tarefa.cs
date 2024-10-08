namespace TaskList.Domain.Tarefas
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoPrioridade Prioridade { get; set; }
        public DateTime DataLimite { get; set; }
        public TipoStatus Status { get; set; }
    }
}
