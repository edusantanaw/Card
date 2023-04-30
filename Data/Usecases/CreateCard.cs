using Domain.Usecases;
using Domain.Entities;

namespace Data.Usecases;

public class CreateCardUsecase : ICreateUsecase<Card, Card>
{
    public Card execute(Card data)
    {
        var card = new Card("Any", "Ant", "aaaa", null);
        throw new NotImplementedException();
    }
}