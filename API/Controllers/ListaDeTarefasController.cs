using Dominio.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ToDoAPI.Controllers
{
    [Route("api/listadetarefa")]
    public class ListaDeTarefasController : ControllerBase
    {
        private readonly IListaDeTarefasServico _listaDeTarefasServico;
        public ListaDeTarefasController(IListaDeTarefasServico listaDeTarefasServico)
        {
            _listaDeTarefasServico = listaDeTarefasServico;
        }

        [HttpGet("{userId}/listas-de-tarefa")]
        public IActionResult GetListaById(int userId)
        {
            var pesquisa = _listaDeTarefasServico.GetLista(userId);

            if (pesquisa == null) return NotFound();

            return Ok(pesquisa);
        }
    }
}
