using DeckOfCards.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeckOfCards.Controllers;

[ApiController]
[Route("[controller]")]
public class CardsController : ControllerBase
{
    private readonly ICardService cardService;

    public CardsController(ICardService cardService) => this.cardService = cardService;

    [HttpGet(Name = "GetCards")]
    public async Task<IActionResult> GetCards(bool shuffle)
    {
        var result = await this.cardService.GetCards(shuffle);
        return Ok(result);
    }
}
