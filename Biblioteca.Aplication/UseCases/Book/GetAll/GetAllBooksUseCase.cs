using Biblioteca.Communication.Responses;

namespace Biblioteca.Aplication.UseCases.Book.GetAll;

public class GetAllBooksUseCase
{
    public ResponseAllBooksJson Execute() 
    {
        return new ResponseAllBooksJson
        {
            Books = new List<ResponseMoreBookJson>
            {
                new ResponseMoreBookJson
                {
                    id = 1,
                    Title = "Bible",
                    Author = "God",
                    Genre = Communication.Enums.BookGenre.Bible,
                    price = 100.00,
                },
                new ResponseMoreBookJson
                {
                    id = 2,
                    Title = "Star Wars: Episode 4",
                    Author = "George Lukas",
                    Genre = Communication.Enums.BookGenre.Fiction,
                    price = 150.00
                }
            }
        };
    }
}

