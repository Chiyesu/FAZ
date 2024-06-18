using Data;

namespace Services;

public class MatchParticipationServices
{
    public readonly ApplicationDatabaseContext _dbContext;
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