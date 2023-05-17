using Dominio.InputModels;
using Dominio.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ToDoAPI.Controllers
{
    [Route("api/tarefa")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaServico _tarefaServico;

        public TarefaController(ITarefaServico tarefaServico)
        {
            _tarefaServico = tarefaServico;
        }

        [HttpGet] 
        public ActionResult BuscarTodos() 
        {
            var pesquisa = _tarefaServico.BuscarTodos();

            return Ok(pesquisa);
        }

        [HttpGet("{id}")]
        public ActionResult BuscarPorId(int id)
        {
            var pesquisa = _tarefaServico.BuscarPorId(id);

            if (pesquisa == null) return NotFound();

            var toJson = JsonConvert.SerializeObject(pesquisa);

            return Ok(toJson);
        }

        [HttpPost]
        public ActionResult Post([FromBody] AddTarefaInputModel inputModel)
        {
            var id = _tarefaServico.AddTarefa(inputModel);

            return Ok(CreatedAtAction(nameof(BuscarPorId), new { id = id }, inputModel));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _tarefaServico.Deletar(id);

            if (id != 0) return NoContent();

            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult Edit([FromBody] UpdateTarefaInputModel inputModel)
        {
            var id = _tarefaServico.EditTarefa(inputModel);

            return Ok(CreatedAtAction(nameof(BuscarPorId), new { id = id }, inputModel));
        }

    }
}
