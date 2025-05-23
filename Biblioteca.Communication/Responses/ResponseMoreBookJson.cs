using System.Net;
using Biblioteca.Communication.Enums;

namespace Biblioteca.Communication.Responses;

public class ResponseMoreBookJson
{
    public int id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookGenre Genre { get; set; }
    public double price { get; set; }
}

