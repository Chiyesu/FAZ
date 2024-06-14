public class Match{
    public int MatchId { get; set; }
    public int HostTeamId { get; set; }
    public int GuestTeamId { get; set; }
    public DateOnly DatePlayed { get; set; }
    public string FinalResult { get; set; }
    public int RefereeId { get; set; }
}