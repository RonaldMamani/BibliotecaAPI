using Biblioteca.Aplication.UseCases.Book.Register;
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
    public IActionResult Register([FromBody] RequestRegisterBookJson request)
    {
        var response = new RegisterBookUseCase().Execute(request);

        return Created(string.Empty, response);
    }
}
