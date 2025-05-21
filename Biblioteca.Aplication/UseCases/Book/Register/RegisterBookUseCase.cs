using Biblioteca.Communication.Requests;
using Biblioteca.Communication.Responses;

namespace Biblioteca.Aplication.UseCases.Book.Register;

public class RegisterBookUseCase
{
    public ResponseRegisteredBookJson Execute(RequestRegisterBookJson request)
    {
        return new ResponseRegisteredBookJson
        {
            Id = request.Id,
            Title = request.Title,
            Author = request.Author,
            Description = request.Description,
        };
    }
}

