using Data;

namespace Services;

public class SubstitutionServices
{
    public readonly ApplicationDatabaseContext _dbContext;
    public SubstitutionServices(ApplicationDatabaseContext dbContext){
        _dbContext = dbContext;
    }
    public async Task Post(Substitution substitution){
        await _dbContext.Substitutions.AddAsync(substitution);
        await _dbContext.SaveChangesAsync();
    }
    public List<Substitution> Get(){
        return _dbContext.Substitutions.ToList();
    }
}