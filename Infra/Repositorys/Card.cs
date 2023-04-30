using Infra.Db;
using Domain.Entities;

namespace Infra.Repositorys
{
    public class CardRepository : ICardRepository
    {
        private readonly CardDbContext _context;
        public CardRepository(CardDbContext context)
        {
            _context = context;
        }

        public Card Create(Card data)
        {
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