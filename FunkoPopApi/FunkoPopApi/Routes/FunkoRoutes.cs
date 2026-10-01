using FunkoPopApi.Models;
using FunkoPopApi.Repository;

namespace FunkoPopApi.Routes;

public static class FunkoRoutes {

    public static void MapFunkoRoutes(this WebApplication app) {
        var repo = app.Services.GetRequiredService<IFunkoRepository>();
        var g = app.MapGroup("api/funkos").WithTags("Funkos");

        g.MapGet("/", () => Results.Ok(repo.GetAll()));
        
        g.MapGet("/{id:int}", (int id) =>
            repo.GetById(id) is { } funko ? Results.Ok(funko) : Results.NotFound());

        g.MapPost("/", (Funko funko) => {
            var creado = repo.Create(funko);
            return Results.Created($"/api/repos/{creado.Id}", creado);
        });

        g.MapPut("/{id:int}", (int id, Funko funko) => 
            repo.Update(id, funko) is {} actualizado? Results.Ok(funko) : Results.NotFound());

        g.MapDelete("/{id:int}", (int id) =>
            repo.Delete(id) ? Results.NoContent() : Results.NotFound());
    }
}