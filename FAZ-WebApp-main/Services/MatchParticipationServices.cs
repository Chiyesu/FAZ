namespace Services
{
<<<<<<< HEAD
    public class MatchParticipationServices
=======
    public readonly ApplicationDatabaseContext _dbContext;

    private readonly List<Player> player = new List<Player>();

    public Player GetPlayerByName(string name)
    {
        return player.FirstOrDefault(p => p.PlayerName.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public MatchParticipationServices (ApplicationDatabaseContext dbContext)
>>>>>>> d98226edf6ced9a1264e4e5ab0aa067a92d80933
    {
        private readonly ApplicationDatabaseContext _dbContext;

        public MatchParticipationServices(ApplicationDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Post(MatchParticipation matchParticipation)
        {
            await _dbContext.MatchParticipation.AddAsync(matchParticipation);
            await _dbContext.SaveChangesAsync();
        }

        public List<MatchParticipation> Get()
        {
            return _dbContext.MatchParticipation.ToList();
        }

        public async Task Update(MatchParticipation matchParticipation)
        {
            var existingParticipation = await _dbContext.MatchParticipation.FindAsync(matchParticipation.MatchParticipationId);
            if (existingParticipation != null)
            {
                existingParticipation.PlayerId = matchParticipation.PlayerId;
                existingParticipation.GoalScored = matchParticipation.GoalScored;
                existingParticipation.MatchId = matchParticipation.MatchId;
                existingParticipation.Card = matchParticipation.Card;

                _dbContext.MatchParticipation.Update(existingParticipation);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int matchParticipationId)
        {
            var existingParticipation = await _dbContext.MatchParticipation.FindAsync(matchParticipationId);
            if (existingParticipation != null)
            {
                _dbContext.MatchParticipation.Remove(existingParticipation);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
<<<<<<< HEAD
}
=======
    public List<MatchParticipation> Get(){
        return _dbContext.MatchParticipation.ToList();
    }
}
>>>>>>> d98226edf6ced9a1264e4e5ab0aa067a92d80933
