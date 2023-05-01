using Infra.Db;
using Domain.Entities;
using Data.Repository;

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

        public void Delete(Guid id)
        {
            var card = _context.Cards.First((c) => c.Id == id);
            _context.Cards.Remove(card);
            _context.SaveChanges();
        }
    }
}