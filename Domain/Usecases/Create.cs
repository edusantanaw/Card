namespace Domain.Usecases;

public interface ICreateUsecase<In, Out>
{
    Out execute(In data);
}