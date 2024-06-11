using Data;

namespace Services;

public class MatchServices
{
    public readonly ApplicationDatabaseContext _dbContext;
    public MatchServices (ApplicationDatabaseContext dbContext){
        _dbContext = dbContext;
    }
    public async Task Post(Match match){
        await _dbContext.Matches.AddAsync(match);
        await _dbContext.SaveChangesAsync();
    }
    public List<Match> Get(){
        return _dbContext.Matches.ToList();
    }
}