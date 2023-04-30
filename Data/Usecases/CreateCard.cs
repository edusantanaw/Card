using Domain.Usecases;
using Domain.Entities;

namespace Data.Usecases;

public class CreateCardUsecase : ICreateUsecase<string, Card>
{
    public Card execute(string data)
    {
        var card = new Card("Any", "Ant", "aaaa", null);
        return card;
    }
}