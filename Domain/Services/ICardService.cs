using DeckOfCards.Domain.DTO;

namespace DeckOfCards.Domain.Services
{
    public interface ICardService
    {
        Task<ICollection<CardsResponseDto>> GetCards(bool shuffle);
    }
}