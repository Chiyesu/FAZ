using Data;

namespace Services;

public class PlayerServices
{
    public readonly ApplicationDatabaseContext _dbContext;
    public PlayerServices (ApplicationDatabaseContext dbContext){
        _dbContext = dbContext;
    }
    public async Task Post(Player player){
        await _dbContext.Players.AddAsync(player);
        await _dbContext.SaveChangesAsync();
    }
    public List<Referee> Get(){
        return _dbContext.Players.ToList();
    }
}