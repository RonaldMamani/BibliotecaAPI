using Biblioteca.Aplication.UseCases.Book.Delete;
using Biblioteca.Aplication.UseCases.Book.Register;
using Biblioteca.Aplication.UseCases.Book.Update;
using Biblioteca.Communication.Requests;
using Biblioteca.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BibliotecaController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestBookJson request)
    {
        var response = new RegisterBookUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestBookJson request)
    {
        var useCase = new UpdateBookUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Delete([FromRoute] int id) {
        var useCase = new DeleteBookBytoIdUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
