using DeckOfCards.Domain.Entities.Enum;

namespace DeckOfCards.Domain.Entities
{
    public class Card : EntityBase
    {
        public CardValue Value { get; private set; }
        public string? Color { get; private set; }
    }
}