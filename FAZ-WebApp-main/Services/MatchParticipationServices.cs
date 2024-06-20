using Data;

namespace Services;

public class MatchParticipationServices
{
    public readonly ApplicationDatabaseContext _dbContext;

    private readonly List<Player> player = new List<Player>();

    public Player GetPlayerByName(string name)
    {
        return player.FirstOrDefault(p => p.PlayerName.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public MatchParticipationServices (ApplicationDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Post(MatchParticipation matchParticipation){
        await _dbContext.MatchParticipation.AddAsync(matchParticipation);
        await _dbContext.SaveChangesAsync();
    }
    public List<MatchParticipation> Get(){
        return _dbContext.MatchParticipation.ToList();
    }
}