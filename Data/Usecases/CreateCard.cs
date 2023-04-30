using Domain.Usecases;
using Domain.Entities;
using Presentational.DTO;

namespace Data.Usecases;

public class CreateCardUsecase : ICreateUsecase<CreaeteCardDto, Card>
{
    public CreateCardUsecase()
    {

    }

    public Card execute(CreaeteCardDto data)
    {
        var card = new Card(data.title, data.description, data.list);
        return card;
    }
}