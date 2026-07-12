namespace GameStore.Api.Features.Games.GetGames;

public record GameDetailsDto(
    Guid Id,
    string Name,
    Guid GenreId,
    decimal Price,
    DateOnly ReleaseDate,
    string Description);

