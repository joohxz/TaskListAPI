using TaskList.Domain.Tarefas;

namespace TaskList.Services.Tarefas
{
    public class TarefaService : ITarefaService
    {

        private readonly List<Tarefa> tarefas = new List<Tarefa>();
        public Tarefa CriarTarefa(Tarefa tarefa)
        {
            //Response
            //var response = new Response();
			try
			{
                var novaTarefa = new Tarefa(
                    tarefa.Id,
                    tarefa.Nome,
                    tarefa.Descricao,
                    tarefa.Prioridade,
                    tarefa.DataLimite,
                    tarefa.Status);

                return novaTarefa;
			}
			catch (Exception ex)
			{
                //Return response with error message
                throw;
			}
        }

        public Tarefa ConsultarPorId(int id)
        {
            //var response = new Response();
            try
            {
                var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
                return tarefa;
            }
            catch (Exception ex)
            {
                //Return response with error message
                throw;
            }
        }

        public List<Tarefa> ListarTodasTarefas()
        {
            //var response = new Response();
            try
            {
                var todasTarefas = new List<Tarefa>(tarefas);
                todasTarefas = tarefas.FindAll(x => x.Id > 0).ToList();
                return todasTarefas;

            }
            catch (Exception ex)
            {
                //Return response with error message
                throw;
            }
        }

        public Tarefa AtualizarTarefa(int id, TipoPrioridade prioridade, DateTime dataLimite, TipoStatus status)
        {
            //var response = new Response();
            try
            {
                var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
                tarefa.Update(
                        prioridade, 
                        dataLimite, 
                        status);
                return tarefa;
            }
            catch (Exception)
            {
                //Return response with error message
                throw;
            }
        }

        public void DeletarTarefa(int id)
        {
            //var response = new Response();
            try
            {
                var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
                tarefa.Delete(id);
                return;
            }
            catch (Exception ex)
            {
                //Return response with error message
                throw;
            }
        }
    }
}
