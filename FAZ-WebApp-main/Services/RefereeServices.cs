using Data;

namespace Services;

public class RefereeServices
{
    public readonly ApplicationDatabaseContext _dbContext;
    public RefereeServices (ApplicationDatabaseContext dbContext){
        _dbContext = dbContext;
    }
    public async Task Post(Referee referee){
        await _dbContext.Referees.AddAsync(referee);
        await _dbContext.SaveChangesAsync();
    }
    public List<Referee> Get(){
        return _dbContext.Referees.ToList();
    }
}