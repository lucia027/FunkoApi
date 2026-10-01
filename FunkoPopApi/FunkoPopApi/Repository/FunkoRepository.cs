using FunkoPopApi.Models;

namespace FunkoPopApi.Repository;

public class FunkoRepository : IFunkoRepository {
    
    private readonly Dictionary<int, Funko> _funkos = [];
    private int _nextId = 0;
    
    public IEnumerable<Funko> GetAll() {
        return _funkos.Values;
    }

    public Funko GetById(int id) {
        return _funkos.Values.FirstOrDefault(x => x.Id == id);
    }

    public Funko Create(Funko item) {
        var funko = item with {Id = _nextId++, CreateAt = DateTime.Now};
        _funkos.Add(funko.Id, funko);
        return funko;
    }

    public Funko? Update(Funko item, int id) {
        if(GetById(item.Id) is not {}) return null;
        
        _funkos.Remove(item.Id);
        _funkos.Add(id, item with {Id = id, UpdateAt = item.UpdateAt});
        return item;
    }

    public Funko Delete(int id)
    {
        throw new NotImplementedException();
    }
}