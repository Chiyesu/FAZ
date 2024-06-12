using Data;

namespace Services;

public class TeamServices
{
    public readonly ApplicationDatabaseContext _dbContext;
    public TeamServices (ApplicationDatabaseContext dbContext){
        _dbContext = dbContext;
    }
    public async Task Post(Team team){
        await _dbContext.Teams.AddAsync(team);
        await _dbContext.SaveChangesAsync();
    }
    public List<Team> Get(){
        return _dbContext.Teams.ToList();
    }
}