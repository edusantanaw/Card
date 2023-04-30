using Data.Repository;
using Domain.Entities;

namespace Infra.Repositorys
{
    public interface ICardRepository : ICreateRepository<Card, Card>
    {

    }
}