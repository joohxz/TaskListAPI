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

        public Tarefa(int id, string nome, string descricao, TipoPrioridade prioridade, DateTime dataLimite, TipoStatus status)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Prioridade = prioridade;
            DataLimite = dataLimite;
            Status = status;
        }

        public void Update(TipoPrioridade prioridade, DateTime dataLimite, TipoStatus status)
        {
            Prioridade = prioridade;
            DataLimite = dataLimite;
            Status = status;
        }

        public void Delete(int id)
        {
            return;
        }
    }
}
