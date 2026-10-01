namespace FunkoPopApi.Models;

public record Funko(
    int Id, 
    string Nombre,
    Decimal Precio, 
    int Stock,
    string Categoria,
    DateTime CreateAt,
    DateTime UpdateAt,
    bool IsDeleted
) { }