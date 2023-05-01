
using Domain.Usecases;
using Domain.Entities;
using Presentational.DTO;
using Data.Repository;

namespace Data.Usecases;

public class DeleteCardUsecase : IDeleteUsecase
{
    private readonly IDeleteRepository<Card> _repository;
    public DeleteCardUsecase(IDeleteRepository<Card> repository)
    {
        _repository = repository;
    }

    public bool execute(Guid id)
    {
        var cardExists = _repository.LoadById(id);
        if (cardExists == null) return false;
        _repository.Delete(id);
        return false;
    }

}