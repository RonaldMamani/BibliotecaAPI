using Biblioteca.Communication.Enums;

namespace Biblioteca.Communication.Requests;

public class RequestBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookGenre Genre { get; set; }
    public double price { get; set; }
    public int Quantities { get; set; }

}

