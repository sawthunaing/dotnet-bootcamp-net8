using GameStore.Api.Data;
using GameStore.Api.Models;

namespace GameStore.Api.Features.Genres.GetGenres;

public static class GetGenresEndpoint
{
    public static void MapGetGenres(this IEndpointRouteBuilder app, GameStoreData data)
    {
        //GET /genres
        app.MapGet("/", () =>
            data.GetGenres()
                .Select(genre => new GenreDto(genre.Id, genre.Name)));
    }
}
