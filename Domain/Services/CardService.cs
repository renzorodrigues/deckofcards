using DeckOfCards.Domain.DTO;
using DeckOfCards.Domain.Entities;
using DeckOfCards.Domain.Repositories;

namespace DeckOfCards.Domain.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository cardRepository;

        public CardService(ICardRepository cardRepository) => this.cardRepository = cardRepository;
        
        public async Task<ICollection<CardsResponseDto>> GetCards(bool shuffle)
        {
            var result = await this.cardRepository.GetCards();

            var cardsDto = new List<CardsResponseDto>();

            if (shuffle)
            {
                result = this.Shuffle(result);
            }            

            foreach (var card in result)
            {
                cardsDto.Add(new CardsResponseDto()
                {
                    Id = card.Id.ToString(),
                    Color = card.Color,
                    Value = card.Value.ToString()
                });
            }

            return cardsDto;
        }

        private List<Card> Shuffle(ICollection<Card> result)
        {
            Random random = new Random();
            return result.OrderBy(a => random.Next()).ToList();
        }
    }
}