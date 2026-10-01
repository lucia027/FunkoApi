using FunkoPopApi.Models;

namespace FunkoApi.Repository;

public class FunkoRepository : IFunkoRepository {
    
    private readonly Dictionary<int, Funko> _funkos = [];
    private int _nextId;
    
    public FunkoRepository() {
        Create(new Funko(0, "Goku", 15.99m, 10, "Dragon Ball", DateTime.Now, DateTime.Now, false));
        Create(new Funko(0, "Naruto Uzumaki", 18.50m, 7, "Naruto", DateTime.Now, DateTime.Now, false));
        Create(new Funko(0, "Natsu Dragneel", 21.99m, 5, "Fairy Tail", DateTime.Now, DateTime.Now, false));
        Create(new Funko(0, "Gojo Satoru", 24.99m, 8, "Jujutsu Kaisen", DateTime.Now, DateTime.Now, false));
    }
    
    public IEnumerable<Funko> GetAll() {
        return _funkos.Values;
    }

    public Funko? GetById(int id) {
        return _funkos.Values.FirstOrDefault(x => x.Id == id);
    }

    public Funko Create(Funko item) {
        var funko = item with {Id = _nextId++, CreateAt = DateTime.Now};
        _funkos.Add(funko.Id, funko);
        return funko;
    }

    public Funko? Update(int id, Funko item) {
        if(GetById(item.Id) is not {}) return null;
        
        _funkos.Remove(item.Id);
        _funkos.Add(id, item with {Id = id, UpdateAt = item.UpdateAt});
        return item;
    }

    public bool Delete(int id) {
        if (GetById(id) is not { }) return false;
        _funkos.Remove(id);
        return true;
    }
}