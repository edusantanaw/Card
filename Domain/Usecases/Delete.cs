namespace Domain.Usecases;

public interface IDeleteUsecase
{
    bool execute(Guid id);
}