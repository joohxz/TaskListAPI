using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskList.API.Controllers
{
    public class TarefaController : TarefaBaseApiController
    {
        public readonly ITarefaService _tarefaService;

        //DI
        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(TarefaResponseJson), StatusCodes.Status201Created)]
        public IActionResult CriarTarefa([FromBody] Tarefa tarefa)
        {
            var novaTarefa = _tarefaService.CriarTarefa(tarefa);
            return Created(novaTarefa);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TarefaResponseJson), StatusCodes.Status200OK)]
        public IActionResult ConsultarTarefaId([FromRoute] int id)
        {
            var tarefa = _tarefaService.ConsultarPorId(id);
            return Ok(tarefa);
        }

        [HttpGet]
        [ProducesResponseType(typeof(TarefaResponseJson), StatusCodes.Status200OK)]
        public IActionResult ListarTarefas()
        {
            var tarefas = _tarefaService.ListarTodasTarefas;
            return Ok(tarefas);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(TarefaResponseJson), StatusCodes.Status200OK)]
        public IActionResult ListarTarefas([FromRoute] int id, [FromBody] Tarefa tarefa)
        {
            var tarefa = _tarefaService.AtualizarTarefa(tarefa.Prioridade, tarefa.DataLimite, tarefa.Status);
            return Ok(tarefa);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(TarefaResponseJson), StatusCodes.Status200OK)]
        public IActionResult DeletarTarefa([FromRoute] int id)
        {
            var tarefa = _tarefaService.DeletarTarefa(int id);
            return Ok();
        }
    }
}
