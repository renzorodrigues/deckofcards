using DeckOfCards.Data;
using DeckOfCards.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeckOfCards.Domain.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly DataBaseContext context;

        public CardRepository(DataBaseContext context)
        {
            this.context = context;
        }

        public async Task<ICollection<Card>> GetCards()
        {
            var result = await this.context.Cards.ToListAsync();
            return result;
        }
    }
}