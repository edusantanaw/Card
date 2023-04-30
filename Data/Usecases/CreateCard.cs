using Domain.Usecases;
using Domain.Entities;
using Presentational.DTO;
using Data.Repository;

namespace Data.Usecases;

public class CreateCardUsecase : ICreateUsecase<CreaeteCardDto, Card>
{
    private readonly ICreateRepository<Card, Card> _repository;
    public CreateCardUsecase(ICreateRepository<Card, Card> repository)
    {

    }

    public Card execute(CreaeteCardDto data)
    {
        var card = new Card(data.title, data.description, data.list);
        _repository.Create(card);
        return card;
    }
}