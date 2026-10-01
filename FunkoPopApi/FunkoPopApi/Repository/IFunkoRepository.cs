using FunkoPopApi.Models;

namespace FunkoPopApi.Repository;

/// <summary>
/// Interfaz que define los metodos de repositorio
/// </summary>
public interface IFunkoRepository {

    /// <summary>
    /// Devuelve una coleccion con todos los funko encontrados.
    /// </summary>
    IEnumerable<Funko> GetAll();
    
    /// <summary>
    /// Busca un funko en base a du id.
    /// </summary>
    /// <param name="id">Id del funko</param>
    /// <returns>Funko encontrado</returns>
    Funko? GetById(int id);
    
    /// <summary>
    /// Crea un nuevo funko en el sistema
    /// </summary>
    /// <param name="item">Funko a crear</param>
    /// <returns>Funko creado</returns>
    Funko Create(Funko item);
    
    /// <summary>
    /// Actualiza un fuko del sistema
    /// </summary>
    /// <param name="item">Funko actualizado</param>
    /// <param name="id">Id del funko para actualizar</param>
    /// <returns>Funko actualizado</returns>
    Funko? Update(int id, Funko item);
    
    /// <summary>
    /// ELimina un funko del sistema
    /// </summary>
    /// <param name="id">Id del funko a eliminar</param>
    /// <returns>Funko eliminado.</returns>
    bool Delete(int id);
}