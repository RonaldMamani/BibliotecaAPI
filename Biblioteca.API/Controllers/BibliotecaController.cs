using Biblioteca.Aplication.UseCases.Book.Delete;
using Biblioteca.Aplication.UseCases.Book.GetAll;
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
    public IActionResult RegisterBook([FromBody] RequestBookJson request)
    {
        var response = new RegisterBookUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult UpdateBook([FromRoute] int id, [FromBody] RequestBookJson request)
    {
        var useCase = new UpdateBookUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllBooksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAllBooks() 
    {
        var useCase = new GetAllBooksUseCase();
        var response = useCase.Execute();

        if (response.Books.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult DeleteBook([FromRoute] int id) {
        var useCase = new DeleteBookBytoIdUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
