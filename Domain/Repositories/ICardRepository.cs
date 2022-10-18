using DeckOfCards.Domain.Entities;

namespace DeckOfCards.Domain.Repositories
{
    public interface ICardRepository
    {
        Task<ICollection<Card>> GetCards();
    }
}