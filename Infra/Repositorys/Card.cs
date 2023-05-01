using Infra.Db;
using Domain.Entities;
using Data.Repository;

namespace Infra.Repositorys
{
    public class CardRepository : ICreateRepository<Card, Card>
    {
        private readonly CardDbContext _context;
        public CardRepository(CardDbContext context)
        {
            _context = context;
        }

        public Card Create(Card data)
        {
            Console.WriteLine(data);
            Console.WriteLine("db");
            _context.Cards.Add(data);
            _context.SaveChanges();
            return data;
        }

        public Card? LoadById(Guid id)
        {
            var maybeCard = _context.Cards.SingleOrDefault(e => e.Id == id);
            return maybeCard;
        }
    }
}