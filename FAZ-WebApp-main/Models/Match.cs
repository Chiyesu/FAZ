namespace Data
{
    public class Match
    {
        public int MatchId { get; set; }
        public int HostTeamId { get; set; }
        public int GuestTeamId { get; set; }
        public string FinalResult { get; set; }
        public int RefereeId { get; set; } 
        public int AssistantReferee1Id { get; set; } = new();
        public int AssistantReferee2Id { get; set; } = new();
        public DateTime DatePlayed { get; set; }
        public string? News { get; set; }
    }
}
